# POC Prerequisites
## Agentic AI WhatsApp RFQ Bot — Proof of Concept

> **Classification:** Internal Use Only  
> **Scope:** Pre-Development Setup through End of Phase 1 (Weeks 0–3)  
> **Goal:** A working WhatsApp webhook that can receive messages, echo replies, and has a fully deployed database schema

---

## Table of Contents

1. [What POC Means in This Project](#what-poc-means-in-this-project)
2. [Account & API Access Required](#account--api-access-required)
3. [Infrastructure Required](#infrastructure-required)
4. [Secrets & Environment Setup](#secrets--environment-setup)
5. [Codebase Bootstrapping](#codebase-bootstrapping)
6. [POC Acceptance Checklist](#poc-acceptance-checklist)
7. [Known Blockers & Lead Times](#known-blockers--lead-times)

---

## What POC Means in This Project

The POC is scoped to **Phase 1 of the SOW (Weeks 1–3)**. It is complete when:

- The FastAPI app is running in Docker and reachable over HTTPS
- The Meta/WhatsApp webhook is registered, validated, and receiving inbound messages
- The bot can send a plain text reply to any inbound WhatsApp message
- All PostgreSQL tables from the PRD schema are migrated and healthy
- Redis session management is operational
- The CI/CD pipeline runs green

The POC does **not** require LLM calls, multimodal parsing, RFQ broadcasting, or any AI functionality. Those belong to Phases 2 and 3.

---

## Account & API Access Required

### 1. Meta / WhatsApp Business Platform

All of the following must be set up before Week 1, Day 1.

| Item | Action Required | Where |
|---|---|---|
| **Meta Business Account** | Create and verify a Meta Business Manager account | [business.facebook.com](https://business.facebook.com) |
| **WhatsApp Business Account (WABA)** | Create inside Meta Business Manager | Meta Business Manager > Accounts > WhatsApp Accounts |
| **Meta Developer App** | Create a new app; add the WhatsApp product | [developers.facebook.com](https://developers.facebook.com) |
| **Verified Phone Number** | Add and verify a phone number inside the Meta Developer App (can be a test number for POC) | Meta App > WhatsApp > Getting Started |
| **Permanent Access Token** | Generate a system user token (the temporary token from the Getting Started page expires in 24 hours — do not use it for development) | Meta Business Manager > System Users |
| **Webhook Verify Token** | Choose any arbitrary string; you will register this in the Meta App and store it in your environment | Self-defined |
| **App Secret** | Recorded from Meta App > Settings > Basic | Meta Developer Dashboard |

> **POC Note:** For the POC, you do not need an approved Message Template. Inbound replies (session messages) do not require templates. Templates are only needed when the bot initiates a message to a user — that is not required until Phase 2 (RFQ broadcast).

---

### 2. Anthropic API

The Anthropic API is **not used in the POC** (LLM calls begin in Week 4). However, the API key should be obtained and stored in Secrets Manager during POC setup so Week 4 has no blocking dependency.

| Item | Action Required |
|---|---|
| **Anthropic Account** | Create at [console.anthropic.com](https://console.anthropic.com) |
| **API Key** | Generate and store in AWS Secrets Manager under key `ANTHROPIC_API_KEY` |
| **Model Availability Check** | Confirm `claude-sonnet-4-20250514` is accessible on the account tier |

---

### 3. OpenAI API

The OpenAI Whisper API is **not used in the POC** (audio transcription begins in Phase 2). Obtain the key now to avoid a blocker at Week 6.

| Item | Action Required |
|---|---|
| **OpenAI Account** | Create at [platform.openai.com](https://platform.openai.com) |
| **API Key** | Generate and store in AWS Secrets Manager under key `OPENAI_API_KEY` |
| **Whisper Access Check** | Confirm `whisper-1` is available on the account |

---

### 4. AWS Account

| Item | Required for POC | Notes |
|---|---|---|
| **AWS Account** | Yes | Root or IAM with programmatic access |
| **S3 Bucket (`rfq-media`)** | Partially — create the bucket now, integration in Phase 2 | Bucket name must match `S3_BUCKET_NAME` env var |
| **AWS Secrets Manager** | Yes — all API keys stored here from Day 1 | Create one secret per key; never use `.env` in any deployed environment |
| **EC2 `t3.medium` or ECS Fargate** | Yes — application must be publicly reachable for webhook | WhatsApp only sends webhooks to HTTPS public URLs |
| **IAM Role** | Yes | Least-privilege: S3 read/write + Secrets Manager read |

---

### 5. Domain & SSL

| Item | Required for POC | Notes |
|---|---|---|
| **Public Domain Name** | Yes | WhatsApp webhook validation requires a publicly resolvable HTTPS URL |
| **SSL Certificate** | Yes | Let's Encrypt (Certbot) is acceptable for POC and MVP |
| **Nginx Reverse Proxy** | Yes | SSL termination; proxies HTTPS to FastAPI on port 8000 |

> **Important:** Meta's webhook verification makes an outbound HTTP GET to your `/webhook` endpoint during registration. The endpoint must be publicly reachable, return HTTP 200, and echo back the `hub.challenge` parameter. This cannot be tested on localhost without a tunneling tool (e.g., ngrok) — and ngrok URLs are not stable for production use. Provision real infrastructure before attempting webhook registration.

---

### 6. GitHub

| Item | Required |
|---|---|
| **GitHub Repository** | Yes — create before Week 1 |
| **GitHub Actions** | Yes — CI pipeline (lint, test, build) must run on every push |
| **Branch Protection Rules** | Recommended — protect `main`; require CI to pass before merge |

---

## Infrastructure Required

All of the following must be provisioned and healthy before Phase 1 coding begins.

| Order | Component | Technology | Target |
|---|---|---|---|
| 1 | Domain + DNS | Any registrar | Week 1, Day 1 |
| 2 | SSL Certificate | Let's Encrypt / Certbot | Week 1, Day 1 |
| 3 | PostgreSQL 16 | AWS RDS or Docker container | Week 1, Day 1 |
| 4 | Redis 7.x | AWS ElastiCache or Docker container | Week 1, Day 1 |
| 5 | AWS Secrets Manager | AWS | Week 1, Day 1 |
| 6 | AWS S3 Bucket | AWS S3 | Week 1 (integration deferred to Phase 2) |
| 7 | EC2 `t3.medium` or ECS Fargate | AWS | Week 2 |
| 8 | Nginx reverse proxy | Docker container | Week 2 |
| 9 | GitHub Actions CI pipeline | GitHub | Week 1 |

### Docker Compose Services (Local Development)

The following services must be running locally via Docker Compose from Day 1:

```yaml
services:
  api:          # FastAPI app (uvicorn)
  worker:       # Celery worker
  postgres:     # PostgreSQL 16
  redis:        # Redis 7.x
```

---

## Secrets & Environment Setup

### Local Development Only (`.env` file — never commit)

```env
# Meta / WhatsApp
META_APP_ID=
META_APP_SECRET=
WHATSAPP_PHONE_NUMBER_ID=
WHATSAPP_ACCESS_TOKEN=
WHATSAPP_WEBHOOK_VERIFY_TOKEN=
WHATSAPP_BUSINESS_ACCOUNT_ID=

# Anthropic (store now, use in Phase 2)
ANTHROPIC_API_KEY=

# OpenAI (store now, use in Phase 2)
OPENAI_API_KEY=

# PostgreSQL
DATABASE_URL=postgresql+asyncpg://user:password@localhost:5432/rfqbot

# Redis
REDIS_URL=redis://localhost:6379/0

# AWS
AWS_ACCESS_KEY_ID=
AWS_SECRET_ACCESS_KEY=
AWS_REGION=ap-south-1
S3_BUCKET_NAME=rfq-media

# Application
ENVIRONMENT=development
SECRET_KEY=
LOG_LEVEL=DEBUG
```

### Deployed Environment (AWS Secrets Manager)

In any deployed environment (staging, production), every key above must be stored as a named secret in AWS Secrets Manager. The application must retrieve secrets at startup via `boto3` — no `.env` file on any server.

---

## Codebase Bootstrapping

The following must be in place before the webhook integration begins (end of Week 1).

### Repository Structure

```
rfq-bot/
├── app/
│   ├── main.py              # FastAPI app entry point
│   ├── routers/
│   │   └── webhook.py       # POST /webhook, GET /webhook (verify)
│   ├── services/
│   ├── models/              # SQLAlchemy models
│   ├── schemas/             # Pydantic schemas
│   └── core/
│       ├── config.py        # Pydantic Settings (reads from env/Secrets Manager)
│       └── security.py      # HMAC-SHA256 signature validation
├── alembic/                 # Database migrations
├── tests/
├── docker-compose.yml
├── Dockerfile
├── .env.example             # Template — no real values
├── .github/
│   └── workflows/
│       └── ci.yml           # Lint, test, build pipeline
└── requirements.txt
```

### Alembic Migration Baseline

All core tables from PRD Section 6 must be present in the initial migration:

- `users`
- `suppliers`
- `product_categories`
- `products`
- `rfq_sessions`
- `rfq_line_items`
- `supplier_quotes`
- `quote_line_items`
- `inventory`
- `pricing`
- `audit_log`

Run `alembic upgrade head` as part of the Docker Compose startup sequence.

### HMAC Webhook Signature Validation

This must be implemented in Week 2 and is non-negotiable. Meta sends a `X-Hub-Signature-256` header on every inbound webhook request. The implementation must:

1. Read the raw request body before any JSON parsing
2. Compute `HMAC-SHA256(body, APP_SECRET)`
3. Compare with the value in the header using a timing-safe comparison
4. Return `HTTP 403` and log a security event if validation fails
5. Return `HTTP 200` immediately after validation (before any processing)

---

## POC Acceptance Checklist

The POC is complete when every item below is checked off.

### Infrastructure

- [ ] Docker Compose starts cleanly: FastAPI, PostgreSQL, Redis, Celery worker all healthy
- [ ] FastAPI `/health` endpoint returns `HTTP 200 OK`
- [ ] Application deployed to EC2/ECS and reachable over HTTPS at the registered domain
- [ ] Nginx reverse proxy terminating SSL and forwarding to FastAPI
- [ ] GitHub Actions CI pipeline runs green (lint + tests pass)

### WhatsApp Integration

- [ ] Meta App webhook URL registered and verified (GET `/webhook` with `hub.challenge` echo working)
- [ ] HMAC-SHA256 signature validation implemented and tested: valid requests pass, tampered requests return 403
- [ ] Inbound text message received from a real WhatsApp number and logged
- [ ] Bot sends a plain text reply to any inbound message (echo bot behavior acceptable for POC)
- [ ] Inbound message types parsed and routed: `text`, `audio`, `document`, `image`, `interactive`
- [ ] Sender identity check implemented: looks up phone number in `suppliers` and `users` tables; unknown numbers quarantined

### Database

- [ ] All tables from PRD Section 6 migrated with correct columns, constraints, and indexes
- [ ] Alembic migration history clean; `alembic current` shows head revision
- [ ] Basic CRUD operations tested for `suppliers`, `products`, `rfq_sessions`

### Session Management

- [ ] Redis session store operational; `session:{phone_number}` key created on first message
- [ ] Session TTL set to 24 hours
- [ ] Session state readable from within Celery task worker

### Celery Task Queue

- [ ] Inbound webhook handler enqueues task to Celery within 200ms (to avoid Meta webhook retry)
- [ ] Celery worker picks up and processes task successfully
- [ ] Task failure visible in Redis dead letter queue

---

## Known Blockers & Lead Times

These items have external dependencies with non-trivial lead times. Start them on Day 1.

| Blocker | Lead Time | Risk if Delayed |
|---|---|---|
| Meta Business Account verification | 1–5 business days | Cannot create WABA or register webhook without a verified account |
| WABA creation and phone number verification | 1–2 business days after Meta account approved | Entire WhatsApp integration blocked |
| Meta Message Template approval | 2–5 business days | Blocks RFQ broadcast (Phase 2, Week 5) — not a POC blocker but start early |
| AWS account provisioning and IAM setup | Same day if account exists; 1–2 days if new | Blocks EC2/S3/Secrets Manager setup |
| Domain registration and DNS propagation | Up to 48 hours | Blocks SSL certificate issuance and webhook HTTPS endpoint |
| SSL certificate issuance (Let's Encrypt) | Minutes once DNS propagates | Blocks webhook registration |
| Anthropic API billing approval | Usually same day | Not a POC blocker; needed for Phase 2 Week 4 |

> **Recommendation:** Submit Meta Business Account verification and Message Template drafts on Day 1, in parallel with local development environment setup. These are the longest external dependencies in the entire project.

---

*Document prepared for Senior Python Developer / AIML — POC Phase*  
*Sources: WhatsApp SaaS Platform Architecture Decision Framework; Fenestration RFQ Bot PRD/SOW v1.0*
