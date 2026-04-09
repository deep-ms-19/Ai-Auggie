# Production Prerequisites
## Agentic AI WhatsApp RFQ Bot — Production Readiness

> **Classification:** Internal Use Only  
> **Scope:** Post-Phase 3 (Post-Week 12) through Live Production Deployment  
> **Goal:** A hardened, monitored, secure, and fully tested system ready for real manufacturer and supplier traffic

---

## Table of Contents

1. [What Production Readiness Means in This Project](#what-production-readiness-means-in-this-project)
2. [Platform & Subscription Upgrades from POC](#platform--subscription-upgrades-from-poc)
3. [Infrastructure Hardening Requirements](#infrastructure-hardening-requirements)
4. [Security & Compliance Requirements](#security--compliance-requirements)
5. [Monitoring & Observability Stack](#monitoring--observability-stack)
6. [Performance & Load Targets](#performance--load-targets)
7. [Multi-Tenant / SaaS Readiness (Post-MVP)](#multi-tenant--saas-readiness-post-mvp)
8. [Production Deployment Checklist](#production-deployment-checklist)
9. [Pre-Go-Live Gates](#pre-go-live-gates)

---

## What Production Readiness Means in This Project

Production readiness is achieved at the end of the **2-week post-Phase 3 UAT and hardening buffer**. It is complete when:

- All four workflows (RFQ generation, multimodal ingestion, comparison, voice-to-DB) pass acceptance criteria from PRD Section 3
- The system handles 100 concurrent RFQ sessions without degradation
- All latency targets from the PRD are consistently met under load
- Security review is passed: HMAC, SQL injection, secrets, PII encryption, audit log
- Monitoring, alerting, and on-call runbooks are in place
- Staging environment has been validated with real supplier phone numbers
- Every Meta Message Template is approved and functional

---

## Platform & Subscription Upgrades from POC

The following items were deferred or partially configured during POC and must be fully resolved before production go-live.

### Meta / WhatsApp Business Platform

| Item | POC State | Production Requirement |
|---|---|---|
| **Access Token** | Temporary (24hr) or system user token | **Permanent system user token** with `whatsapp_business_messaging` and `whatsapp_business_management` permissions; never expires |
| **Message Templates** | Drafted and pending (POC did not require broadcast) | **All templates approved** by Meta before go-live: RFQ broadcast template, quote acknowledgement template, comparison notification template, DB update confirmation template |
| **Phone Number Quality Rating** | Not yet rated (new number) | Monitor and maintain "High" quality rating; breaching limits risks number restriction |
| **WhatsApp API Rate Limit Management** | Not enforced | **Token bucket rate limiter** enforced at application layer: 1,000 msgs/day per business number (WhatsApp Cloud API hard limit) |
| **Webhook SSL Certificate** | Let's Encrypt acceptable | Let's Encrypt acceptable in production if auto-renewed; configure Certbot cron for automatic renewal before 90-day expiry |
| **Meta Solution Partner Status** | Not required for single-tenant MVP | **Mandatory if onboarding multiple client WABAs** (SaaS/multi-tenant mode post-MVP); apply during MVP development — approval takes weeks |

### Anthropic Claude API

| Item | POC State | Production Requirement |
|---|---|---|
| **API Key** | Stored in Secrets Manager; not yet used | In active use; confirm billing tier supports sustained throughput |
| **Rate Limits** | Unknown | Confirm tier supports minimum 100 concurrent inference requests without throttling; upgrade plan if needed |
| **Model: `claude-sonnet-4-20250514`** | Confirmed available | Pin the exact model string in application config; do not use floating aliases in production |
| **Tool Use API** | Not tested in POC | Fully tested with all four tool definitions: `update_pricing`, `update_inventory`, `get_comparison`, `create_rfq` |
| **Fallback Handling** | None | If Anthropic API returns 5xx or times out (>30s), retry once; on second failure, route to manual review queue and notify manufacturer |

### OpenAI API

| Item | POC State | Production Requirement |
|---|---|---|
| **Whisper API** | Key stored; not tested | Fully tested with English, Hindi, and Hinglish audio; latency target <20s for 60s clip confirmed |
| **Rate Limits** | Unknown | Confirm sufficient audio processing quota for expected concurrent voice note volume |
| **GPT-4o Fallback** | Not configured | Fallback routing code written, tested, and documented; activates automatically if Anthropic is unavailable |

### AWS

| Item | POC State | Production Requirement |
|---|---|---|
| **EC2 / ECS Fargate** | Single instance acceptable for POC | **Auto-scaling configured**: minimum 2 instances for high availability; scale out on CPU >70% or task queue depth >100 |
| **S3 Bucket** | Created; not yet in use | In active use; **versioning enabled**; lifecycle policy configured (e.g., archive media files >90 days to S3 Glacier) |
| **AWS Secrets Manager** | Basic setup | All secrets stored; **secret rotation policy** configured; application code reads secrets at startup, not hardcoded |
| **RDS PostgreSQL** | Docker or basic RDS | **Multi-AZ RDS** in production for failover; automated daily backups enabled with 7-day retention minimum |
| **VPC & Security Groups** | Open for POC convenience | **Locked down**: FastAPI/EC2 only accessible via Nginx; PostgreSQL and Redis not publicly accessible; inbound 443 only from Nginx |
| **CloudWatch / ALB** | Not configured | Application Load Balancer with health checks if using ECS; CloudWatch alarms on high CPU, memory, and error rates |

---

## Infrastructure Hardening Requirements

### Networking & Access Control

- Nginx configured with:
  - SSL/TLS 1.3 only (disable TLS 1.0, 1.1)
  - HSTS header enabled
  - Rate limiting at edge: max 100 requests/minute per IP on `/webhook`
  - Request body size limit: reject payloads >10MB at Nginx layer (before they reach FastAPI)
- PostgreSQL and Redis bound to private subnet only; no public IP
- All inter-service communication within Docker network or VPC; no plaintext internal traffic
- SSH key-based access only to EC2; password authentication disabled; SSH port changed from default 22

### Database

- Connection pooling: min 5, max 50 connections (SQLAlchemy `pool_size=5`, `max_overflow=45`)
- All DB writes wrapped in transactions with explicit `ROLLBACK` on exception
- `audit_log` table write must be part of the same transaction as the entity write it records — they commit or roll back together
- Database user for the application has only `SELECT`, `INSERT`, `UPDATE` permissions on application tables; no `DROP`, `CREATE`, or `TRUNCATE`
- Separate read-only DB user for any analytics or reporting queries

### Redis

- Session TTL: 24 hours (enforced via `EXPIRE` on every session write)
- Redis `requirepass` configured in production; password stored in Secrets Manager
- Redis `maxmemory-policy` set to `allkeys-lru` to prevent unbounded memory growth

### Celery Workers

- Worker concurrency configured for expected load (start with `--concurrency=4` per worker instance)
- Task visibility timeout set to 35 seconds (slightly above max LLM timeout of 30s)
- Dead letter queue (DLQ) configured for tasks that exceed max retries
- Failed WhatsApp outbound messages routed to DLQ with original payload preserved for manual retry

### Docker & Container Security

- All Docker images built from `python:3.11-slim` base; no `root` user in production containers
- Multi-stage Docker build: separate build stage and runtime stage to minimize image size
- No secrets in Docker images or Dockerfiles; all secrets injected at runtime via environment
- Container image scanning in CI pipeline (e.g., Trivy or Docker Scout) before deployment

---

## Security & Compliance Requirements

All items below are **mandatory before go-live**. None are optional.

### Authentication & Request Integrity

- [ ] **HMAC-SHA256 webhook validation** on 100% of inbound `/webhook` POST requests
  - Raw body read before JSON parsing
  - Timing-safe comparison (`hmac.compare_digest`)
  - Invalid signature → `HTTP 403`, security event logged, processing stopped
- [ ] **Webhook verify token** stored in Secrets Manager; not hardcoded
- [ ] **App Secret** stored in Secrets Manager; rotated if exposed
- [ ] **No API keys** in source code, Docker images, CI logs, or environment files on any server

### Database Security

- [ ] All queries use parameterized statements via SQLAlchemy ORM; zero raw SQL string interpolation
- [ ] Database credentials stored in Secrets Manager; rotated quarterly
- [ ] No direct database access from the public internet

### PII & Data Protection

- [ ] Supplier `whatsapp_number` and contact details encrypted at rest using AES-256
- [ ] Encryption keys stored in AWS KMS or Secrets Manager; not in the database
- [ ] GDPR-compliant data retention policy documented and enforced:
  - Supplier quotes retained for a defined period (e.g., 12 months)
  - Audit logs retained for a minimum of 24 months
  - Automated purge job scheduled for expired records
- [ ] Supplier PII handling procedure documented and reviewed
- [ ] No PII written to application logs; LLM API call logs contain only request/response hashes

### LLM Safety

- [ ] All extracted numeric values (prices, quantities) validated against configurable min/max range per product category before any DB write
- [ ] Cross-field consistency check enforced: `total_price ~= unit_price × qty × (1 + gst/100)` within 5% tolerance; discrepancy flags for review
- [ ] Vision pipeline logs bounding box coordinates for every extracted numeric value (source traceability for audit)
- [ ] No DB write ever executes without an explicit human `YES` confirmation via WhatsApp quick reply
- [ ] Confidence thresholds enforced and non-configurable at runtime:
  - Text: ≥ 0.85
  - Image: ≥ 0.75
  - Audio: ≥ 0.70
  - Voice command intent: ≥ 0.80

### Session Security

- [ ] Redis session TTL: 24 hours; confirmed no stale sessions persist beyond TTL
- [ ] DB confirmation state (`awaiting_db_confirm`) times out after 10 minutes of no reply; operation cancelled and state reset
- [ ] Session key format: `session:{e164_phone_number}` — no PII other than the phone number itself in the session key

---

## Monitoring & Observability Stack

All three layers must be operational before go-live.

### Layer 1: Error Tracking (Sentry)

| Requirement | Detail |
|---|---|
| **Sentry DSN configured** | `SENTRY_DSN` environment variable set in Secrets Manager |
| **Unhandled exceptions** | All unhandled exceptions auto-captured and routed to Sentry |
| **LLM parsing failures** | Custom Sentry events for: low-confidence extraction, hallucination flag, Anthropic API error, Whisper error |
| **Webhook validation failures** | Security event logged to Sentry with inbound IP and payload hash |
| **Alert routing** | Sentry alerts routed to on-call Slack channel or email; P1 issues page immediately |

### Layer 2: Metrics & Dashboards (Prometheus + Grafana)

The following metrics must be instrumented and visible in Grafana before go-live:

| Metric | Alert Threshold |
|---|---|
| LLM call latency (p50, p95, p99) | p95 > 25s → warning |
| Whisper transcription latency | p95 > 18s → warning |
| Webhook inbound rate (msgs/min) | Spike > 500/min → alert |
| Celery queue depth | Queue depth > 200 → alert |
| PostgreSQL connection pool utilization | > 80% → warning |
| Redis memory utilization | > 75% → warning |
| Failed WhatsApp outbound messages (DLQ size) | > 10 → alert |
| DB write success rate | < 99% → P1 alert |
| Confidence score distribution per modality | Track weekly; regression alert if mean drops >5% |

### Layer 3: Application Health

| Requirement | Detail |
|---|---|
| **`/health` endpoint** | Returns `HTTP 200 OK` with `{"status": "healthy", "db": "ok", "redis": "ok"}` |
| **Uptime monitoring** | External uptime check on `/health` every 60 seconds (UptimeRobot, Pingdom, or equivalent) |
| **Uptime SLA** | 99.5% (≤ ~4 hours downtime/month) |
| **On-call runbook** | Written and accessible; covers: service restart, Redis flush, DB rollback, webhook re-registration |

---

## Performance & Load Targets

All of the following must be verified under load testing before go-live. Load tests should simulate 100 concurrent RFQ sessions with all four message modalities active simultaneously.

### Latency Targets (from PRD Section 4.1)

| Operation | Max Acceptable Latency | Test Method |
|---|---|---|
| Text message parse (webhook → reply) | < 3 seconds | Locust / k6 load test |
| RFQ broadcast (50 suppliers) | < 60 seconds | End-to-end broadcast test with mock supplier numbers |
| PDF parsing (10-page PDF) | < 15 seconds | Pipeline test with 20+ real supplier PDFs |
| Image / photo OCR | < 10 seconds | Pipeline test with handwritten and printed samples |
| Audio transcription + extraction | < 20 seconds | 60-second Hinglish voice notes |
| Voice-to-DB intent extraction | < 5 seconds (post-transcription) | Agentic tool-use pipeline test |
| DB confirmation + write | < 5 seconds (post-YES) | End-to-end voice-to-DB flow test |
| Comparison report generation | < 8 seconds (20 suppliers) | Automated test with seeded quote data |

### Scalability Targets

- 100 concurrent RFQ sessions without performance degradation (horizontal scaling via Docker/Kubernetes)
- FastAPI application stateless; all state in PostgreSQL + Redis
- Celery workers horizontally scalable; no shared in-memory state between workers
- Database connection pooling: min 5, max 50 connections; no connection exhaustion under load

### Retry & Resilience Targets

| Scenario | Behaviour |
|---|---|
| Failed WhatsApp outbound delivery | Retry up to 3 times with exponential backoff; failures to DLQ; manufacturer notified |
| Expired WhatsApp media URL (>5 min) | Retry download 3× with 30s intervals; if all fail, mark `media_expired`, notify manufacturer |
| LLM API timeout (>30s) | Retry once; if second attempt fails, route to manual review queue, notify manufacturer |
| DB write failure | `ROLLBACK` transaction; notify manufacturer; queue for retry |
| WhatsApp API rate limit hit | Token bucket rate limiter; queue excess messages with priority ordering |
| Vision LLM unavailable | Graceful degradation: flag quote for manual entry, notify manufacturer; do not silently drop |

---

## Multi-Tenant / SaaS Readiness (Post-MVP)

The following is **out of scope for MVP** but must be architected correctly from the start to avoid re-platforming. Document the decisions made during MVP for each item below.

| Item | MVP Decision to Document | Post-MVP Requirement |
|---|---|---|
| **Meta Solution Partner Status** | Applied for during MVP; approval timeline tracked | Required before onboarding any client WABA |
| **Embedded Signup Flow** | Not implemented in MVP | Required for client WABA onboarding (Scenario A and B) |
| **Coexistence Mode** | Not implemented | Required for clients using existing WhatsApp Business App numbers |
| **Number Migration** | Not implemented | Required for clients migrating from other BSPs (360dialog, MessageBird, etc.) |
| **Multi-tenant data isolation** | Single tenant (one manufacturer) | Each client's WABA credentials, sessions, and data must be fully isolated |
| **Webhook tenant routing** | Not required | Webhook must resolve tenant context from recipient phone number |
| **Per-tenant configuration** | Not required | Product catalogs, supplier lists, and confidence thresholds configurable per tenant |

---

## Production Deployment Checklist

### Code & Build

- [ ] All tests passing; coverage ≥ 80% for core pipeline
- [ ] Ruff lint clean; mypy type checks passing; black formatting enforced
- [ ] No `TODO`, `FIXME`, or `raise NotImplementedError` in production code paths
- [ ] Docker image built from `python:3.11-slim`; no root user; image size documented
- [ ] Container image security scan passed (no critical CVEs)
- [ ] GitHub Actions CI pipeline green on `main` branch

### Configuration

- [ ] All environment variables documented in `.env.example`
- [ ] All production secrets stored in AWS Secrets Manager; zero secrets in code, Dockerfiles, or CI logs
- [ ] `ENVIRONMENT=production` set; `LOG_LEVEL=INFO` (not DEBUG) in production
- [ ] Model name pinned: `ANTHROPIC_MODEL=claude-sonnet-4-20250514`
- [ ] Confidence thresholds configured and immutable at runtime
- [ ] Price range guardrails per product category seeded in the database

### Database

- [ ] All Alembic migrations applied; `alembic current` shows head
- [ ] All core tables present with correct indexes and constraints
- [ ] Product catalog and supplier list seeded with real data
- [ ] Database backup tested: restore procedure verified end-to-end
- [ ] Multi-AZ RDS enabled (or equivalent HA configuration)

### WhatsApp & Meta

- [ ] All required Message Templates approved by Meta
- [ ] Permanent system user access token active (not expiring)
- [ ] Webhook URL registered and verified in Meta App
- [ ] HMAC signature validation tested with known-good and tampered payloads
- [ ] Phone number quality rating confirmed "High"
- [ ] Rate limit (1,000 msgs/day) enforced at application layer

### Security

- [ ] Nginx TLS 1.3 only; HSTS enabled
- [ ] All endpoints except `/webhook` and `/health` require internal-only access
- [ ] SQL injection prevention: parameterized queries confirmed in all DB-touching code paths
- [ ] PII encryption at rest: supplier contact data encrypted (AES-256)
- [ ] LLM logs confirmed PII-free (hashes only)
- [ ] GDPR retention policy automated purge job scheduled and tested
- [ ] Security review sign-off obtained from technical lead

### Monitoring

- [ ] Sentry DSN configured; test exception captured and visible in Sentry dashboard
- [ ] All Prometheus metrics instrumented; Grafana dashboards displaying live data
- [ ] All alert thresholds configured; test alert fired and received
- [ ] `/health` endpoint monitored by external uptime checker
- [ ] On-call runbook written, reviewed, and accessible to all team members

### Testing & UAT

- [ ] Load test completed: 100 concurrent sessions; all latency targets met
- [ ] End-to-end test completed with real supplier phone numbers (minimum 5)
- [ ] All 4 modalities tested with real-world samples: text, PDF (20+ docs), image (handwritten + printed), audio (English + Hindi)
- [ ] Voice-to-DB flow tested end-to-end: voice note → transcription → intent → confirmation → DB write → audit log
- [ ] Hallucination guardrails tested: out-of-range price rejected, cross-field mismatch flagged
- [ ] All error/edge cases from PRD Section 5 tested: corrupt PDF, blurry image, inaudible audio, expired media URL, unknown supplier
- [ ] UAT completed with at least one real procurement manager user

---

## Pre-Go-Live Gates

**No deployment to production is permitted until all 10 gates below are cleared and signed off.**

| # | Gate | Sign-Off Required |
|---|---|---|
| 1 | All PRD Section 3 acceptance criteria verified across all 4 workflows | Technical Lead |
| 2 | Security review completed: HMAC, parameterized queries, secrets audit, PII encryption | Technical Lead |
| 3 | Load test passed: 100 concurrent sessions, all latency targets met | Technical Lead |
| 4 | All Meta Message Templates approved and functional | Project Manager |
| 5 | Monitoring stack live: Sentry + Grafana with active alerts | DevOps |
| 6 | Staging UAT completed with real supplier phone numbers | Product Owner |
| 7 | DLQ and retry policies verified via failure injection testing | Technical Lead |
| 8 | Audit log integrity verified: every DB write traceable to source | Technical Lead |
| 9 | Database backup and restore procedure tested end-to-end | DevOps |
| 10 | On-call runbook written, reviewed, and distributed | Technical Lead |

---

*Document prepared for Senior Python Developer / AIML — Production Readiness*  
*Sources: WhatsApp SaaS Platform Architecture Decision Framework; Fenestration RFQ Bot PRD/SOW v1.0*
