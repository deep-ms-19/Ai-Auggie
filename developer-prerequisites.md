# Developer Prerequisites
## Agentic AI WhatsApp RFQ Bot — Fenestration Industry Platform

> **Classification:** Internal Use Only  
> **Scope:** POC Initiation through Production Readiness  
> **Stack:** FastAPI · WhatsApp Business Cloud API · Anthropic Claude · PostgreSQL · Redis

---

## Table of Contents

1. [Overview](#overview)
2. [Platform Subscriptions & Access](#platform-subscriptions--access)
3. [Mandatory vs. Optional Subscriptions](#mandatory-vs-optional-subscriptions)
4. [Documentation Required by Phase](#documentation-required-by-phase)
5. [Infrastructure Provisioning Checklist](#infrastructure-provisioning-checklist)
6. [Environment & Secrets Setup](#environment--secrets-setup)
7. [Development Toolchain Requirements](#development-toolchain-requirements)
8. [Pre-Production Readiness Gates](#pre-production-readiness-gates)

---

## Overview

This document consolidates all prerequisites for building the Agentic AI WhatsApp RFQ Bot. It covers every external platform account, API subscription, infrastructure dependency, and piece of documentation a developer needs before writing the first line of code through to deploying a production-ready system.

The platform is built on four core integration pillars:

- **Meta / WhatsApp Business Cloud API** — inbound/outbound messaging channel
- **Anthropic Claude API** — primary LLM for text extraction, vision/OCR, and agentic tool use
- **OpenAI API** — speech-to-text (Whisper) and LLM fallback
- **AWS** — cloud hosting, object storage, and secrets management

---

## Platform Subscriptions & Access

### 1. Meta / WhatsApp Business Platform

| Requirement | Description | Tier |
|---|---|---|
| **Meta Business Account** | A verified Meta Business Manager account is the root identity for all WhatsApp API access | **Mandatory** |
| **WhatsApp Business Account (WABA)** | Created under the Meta Business Manager; hosts phone numbers and message templates | **Mandatory** |
| **Meta App (Developer App)** | A Meta developer app with the WhatsApp product added; provides App ID, App Secret, and access tokens | **Mandatory** |
| **WhatsApp Business Cloud API Access** | Cloud-hosted API; no on-premise BSP required. Enabled through the Meta App | **Mandatory** |
| **Meta Solution Partner / Tech Provider Status** | Required if the platform will onboard multiple client WABAs via Embedded Signup (SaaS mode). Not required for single-tenant MVP, but mandatory for multi-tenant production | **Mandatory for multi-tenant / SaaS** |
| **Verified Business Phone Number** | A phone number registered and verified within the WABA for sending/receiving messages | **Mandatory** |
| **Approved Message Templates** | WhatsApp requires pre-approved templates for all business-initiated messages (RFQ broadcasts, notifications) | **Mandatory** |
| **Embedded Signup Flow** | Required if clients bring their own WhatsApp numbers or migrate from another BSP. Only available to Meta Solution Partners | **Mandatory for Scenario B (existing numbers)** |

> **Critical Note on Meta Partner Status:** There is no alternative or workaround to bypass the Meta Solution Partner / Technology Provider requirement for SaaS onboarding. It is a foundational prerequisite enabling Embedded Signup, client WABA authorization, coexistence mode, and number migration workflows.

**Meta documentation to review before starting:**
- [WhatsApp Cloud API Getting Started](https://developers.facebook.com/docs/whatsapp/cloud-api/get-started)
- [WhatsApp Embedded Signup](https://developers.facebook.com/docs/whatsapp/embedded-signup)
- [Message Templates](https://developers.facebook.com/docs/whatsapp/message-templates)
- [Webhook Setup and Signature Verification](https://developers.facebook.com/docs/whatsapp/cloud-api/webhooks)

---

### 2. Anthropic (Claude API)

| Requirement | Description | Tier |
|---|---|---|
| **Anthropic API Account** | Account at console.anthropic.com with billing configured | **Mandatory** |
| **API Key** | Used for all Claude calls: text extraction, Vision LLM (PDF/image OCR), and agentic Tool Use | **Mandatory** |
| **Model Access: `claude-sonnet-4-20250514`** | Primary model for all text, vision, and function-calling tasks. Must confirm model availability on the account | **Mandatory** |
| **Tool Use / Function Calling API** | Anthropic's Tool Use API is used for the voice-to-DB intent extraction and agentic routing workflows | **Mandatory** |
| **Sufficient Quota / Rate Limits** | Development and testing will issue many LLM calls concurrently; confirm rate limits support the throughput required (100 concurrent RFQ sessions target) | **Mandatory** |

**Anthropic documentation to review:**
- [Anthropic API Quickstart](https://docs.anthropic.com/en/api/getting-started)
- [Tool Use (Function Calling)](https://docs.anthropic.com/en/docs/tool-use)
- [Vision / Image Input](https://docs.anthropic.com/en/docs/vision)
- [Rate Limits](https://docs.anthropic.com/en/api/rate-limits)

---

### 3. OpenAI API

| Requirement | Description | Tier |
|---|---|---|
| **OpenAI API Account** | Account at platform.openai.com with billing configured | **Mandatory** |
| **API Key** | Used for Whisper speech-to-text transcription (primary STT engine) | **Mandatory** |
| **Whisper API Access (`whisper-1`)** | Transcribes supplier voice notes and manufacturer voice commands. Must handle English, Hindi, and Hinglish | **Mandatory** |
| **GPT-4o Access** | Fallback LLM if Anthropic Claude is unavailable. GPT-4o Vision used as fallback for OCR pipeline | **Optional (fallback)** |

**OpenAI documentation to review:**
- [OpenAI Whisper API](https://platform.openai.com/docs/guides/speech-to-text)
- [GPT-4o Vision (fallback)](https://platform.openai.com/docs/guides/vision)

---

### 4. AWS (Cloud Infrastructure)

| Requirement | Description | Tier |
|---|---|---|
| **AWS Account** | Root or IAM account with programmatic access | **Mandatory** |
| **EC2 or ECS Fargate** | `t3.medium` (EC2) or Fargate for hosting FastAPI app and Celery workers | **Mandatory** |
| **S3 Bucket** | Object storage for all inbound media: PDFs, images, audio files. Path structure: `s3://rfq-media/{rfq_id}/{supplier_id}/{timestamp}.{ext}` | **Mandatory** |
| **AWS Secrets Manager** | Secure storage of all API keys (Meta, Anthropic, OpenAI, DB credentials). No keys in environment files in production | **Mandatory** |
| **Domain Name + SSL Certificate** | A public domain is required; WhatsApp webhooks only accept HTTPS endpoints. Let's Encrypt (Certbot) acceptable for MVP | **Mandatory** |
| **IAM Roles and Policies** | Least-privilege IAM roles for EC2/ECS to access S3 and Secrets Manager | **Mandatory** |
| **GitHub Actions (CI/CD)** | Repository with Actions enabled for lint, test, build, and deploy pipeline | **Mandatory** |

**AWS documentation to review:**
- [S3 Getting Started](https://docs.aws.amazon.com/AmazonS3/latest/userguide/GetStartedWithS3.html)
- [AWS Secrets Manager](https://docs.aws.amazon.com/secretsmanager/latest/userguide/intro.html)
- [ECS Fargate Getting Started](https://docs.aws.amazon.com/AmazonECS/latest/developerguide/getting-started-fargate.html)

---

### 5. Supporting Platform Accounts

| Platform | Purpose | Tier |
|---|---|---|
| **Sentry** | Application error tracking and alerting | Mandatory |
| **Prometheus + Grafana** | LLM latency dashboards and error rate alerting | Mandatory (or equivalent) |
| **GitHub** | Source control and CI/CD via GitHub Actions | Mandatory |
| **Docker Hub / ECR** | Container image registry for CI/CD builds | Mandatory |
| **MinIO** (alternative) | Self-hosted S3-compatible object storage; acceptable alternative to AWS S3 for local dev | Optional |
| **HashiCorp Vault** | Alternative to AWS Secrets Manager for secrets at rest | Optional |
| **Google Speech-to-Text v2** | Fallback STT if Whisper is unavailable | Optional (fallback) |

---

## Mandatory vs. Optional Subscriptions

### Mandatory (MVP cannot function without these)

1. Meta Business Account + WABA + Meta Developer App
2. Verified WhatsApp Business Phone Number
3. Approved WhatsApp Message Templates (for broadcast)
4. WhatsApp Cloud API access with webhook HTTPS endpoint
5. Anthropic API key with `claude-sonnet-4-20250514` access (Tool Use enabled)
6. OpenAI API key with `whisper-1` access
7. AWS account with S3 bucket, EC2/ECS, and Secrets Manager
8. Public domain with valid SSL/TLS certificate
9. GitHub repository with Actions enabled

### Mandatory for Production / Multi-Tenant SaaS (not required for single-tenant POC)

1. **Meta Solution Partner / Technology Provider Status** — required for Embedded Signup (client WABA onboarding), coexistence mode, and number migration
2. **Production-grade secrets management** (AWS Secrets Manager or Vault; no `.env` files in prod)
3. **Sentry + Prometheus/Grafana** monitoring stack
4. **PII encryption at rest** (AES-256 for supplier contact data)
5. **GDPR-compliant data retention policies** documented and enforced

### Optional / Fallback Only

1. GPT-4o (OpenAI) — LLM fallback if Anthropic is unavailable
2. GPT-4o Vision — OCR fallback
3. Google Speech-to-Text v2 — STT fallback
4. HashiCorp Vault — alternative to AWS Secrets Manager
5. MinIO — local dev alternative to AWS S3

---

## Documentation Required by Phase

### Phase 0: POC Initiation (Before Week 1)

The following must be in place before any development begins.

**Account & Access Documentation**

- [ ] Meta Business Manager account verified and approved
- [ ] WABA created and phone number verified; confirm the number is not associated with a personal WhatsApp account
- [ ] Meta Developer App created with WhatsApp product added; App ID and App Secret recorded
- [ ] WhatsApp Cloud API test credentials (temporary access token) issued
- [ ] At least one WhatsApp Message Template drafted and submitted for review (RFQ broadcast template)
- [ ] Anthropic API key created; model `claude-sonnet-4-20250514` confirmed available
- [ ] OpenAI API key created; `whisper-1` access confirmed
- [ ] AWS account provisioned; IAM user/role created with S3 + Secrets Manager + EC2/ECS access
- [ ] Domain name registered; DNS configured; SSL certificate issued (Let's Encrypt)

**Architecture & Design Documentation**

- [ ] PRD reviewed and accepted by development lead (covers all 4 workflows and acceptance criteria)
- [ ] Database schema (PRD Section 6) reviewed; all tables and constraints understood
- [ ] WhatsApp UX flows (Flows 1A–2B) reviewed; bot message formats finalized
- [ ] Backend sequence diagrams (Sections 3.1–3.4) reviewed; all service boundaries understood
- [ ] Edge cases and error handling matrix (PRD Section 5) reviewed

**Environment Setup Documentation**

- [ ] Local Docker Compose environment defined (FastAPI, PostgreSQL 16, Redis 7.x, Celery worker)
- [ ] Alembic migration structure initialized with base schema
- [ ] `.env.example` file created documenting all required environment variables (see [Environment & Secrets Setup](#environment--secrets-setup))
- [ ] GitHub repository created; branch protection rules and CI/CD workflow scaffolded

---

### Phase 1: Core Infrastructure (Weeks 1–3)

**Technical Prerequisites**

- [ ] WhatsApp webhook URL registered in Meta App (must be HTTPS)
- [ ] HMAC-SHA256 webhook signature verification implemented and tested; App Secret stored in Secrets Manager
- [ ] `X-Hub-Signature-256` header validation confirmed working end-to-end
- [ ] PostgreSQL schema fully migrated; all tables from PRD Section 6 present with correct constraints and indexes
- [ ] Redis session store operational; `session:{phone_number}` key structure confirmed
- [ ] Celery + Redis broker task queue running; basic task enqueue/consume tested
- [ ] FastAPI `/health` endpoint returning `200 OK`

**Phase 1 Acceptance Gate**

- Webhook receives and validates inbound WhatsApp messages end-to-end
- Bot can send a text reply to any inbound message
- Docker Compose starts all services cleanly
- CI pipeline (lint, test, build) runs green

---

### Phase 2: RFQ Generation & Multimodal Pipeline (Weeks 4–8)

**Additional Prerequisites**

- [ ] Anthropic API client integrated with retry/timeout handling (Pydantic output schemas validated)
- [ ] Minimum 5 real supplier WhatsApp numbers registered in the `suppliers` table for end-to-end broadcast testing (required by Week 5)
- [ ] Sample dataset of 20+ supplier quotes in all four formats (text, PDF, image, audio) assembled and stored (required by Week 6)
- [ ] WhatsApp RFQ broadcast template approved by Meta (required before broadcast engine can send business-initiated messages)
- [ ] S3 bucket created and credentials configured; media download + upload pipeline tested
- [ ] `pdf2image` and Pillow image preprocessing dependencies installed and tested in Docker image
- [ ] Whisper API (`whisper-1`) tested with Hindi and Hinglish audio samples

**Confidence & Validation Documentation**

- [ ] Confidence threshold values documented and configurable: text >= 0.85, image >= 0.75, audio >= 0.70
- [ ] Price range guardrails per product category defined (e.g., 4mm glass: INR 80–500/sqft)
- [ ] Cross-field math validation rules documented (total ~= unit_price x qty x (1 + gst/100), within 5% tolerance)

---

### Phase 3: Comparison Engine & Voice-to-DB (Weeks 9–12)

**Additional Prerequisites**

- [ ] Anthropic Tool Use API confirmed working with multi-tool invocation (update_pricing, update_inventory)
- [ ] Intent classification threshold documented (confidence >= 0.80 required before proceeding without clarification)
- [ ] Entity resolution logic for ambiguous product references (e.g., `p1` -> `product_id` lookup) designed and documented
- [ ] Atomic transaction rollback behavior tested for DB write failures
- [ ] Audit log schema (`audit_log` table) verified to capture: `performed_by`, `source_medium`, `source_artifact_id`, `old_value`, `new_value`
- [ ] 10-minute confirmation timeout behavior implemented and tested

**Security Review Checklist (before staging deployment)**

- [ ] SQL injection prevention: all queries use parameterized statements; no raw string interpolation
- [ ] HMAC signature validation confirmed on 100% of inbound webhook requests
- [ ] All API keys confirmed stored in Secrets Manager; zero hardcoded secrets in code or Docker images
- [ ] PII (supplier contact data) encrypted at rest (AES-256)
- [ ] Redis session TTL set to 24 hours; confirmed no stale sessions persist
- [ ] LLM API call logs confirmed to contain request/response hashes only (no PII)

---

### Production Readiness (Post-Week 12, UAT + Hardening)

**Infrastructure Documentation**

- [ ] Nginx reverse proxy configured: SSL termination, rate limiting at edge
- [ ] Dead letter queue (DLQ) configured for failed WhatsApp outbound messages
- [ ] Exponential backoff retry policy confirmed: 3 retries for failed deliveries, 3x retries with 30s intervals for expired media URLs
- [ ] Database connection pooling configured: min 5, max 50 connections
- [ ] WhatsApp API per-number rate limiter implemented (1,000 msgs/day limit enforced via token bucket)
- [ ] Graceful degradation path documented: if Vision LLM unavailable, quote flagged for manual entry and manufacturer notified

**Monitoring & Observability**

- [ ] Sentry DSN configured; error alerts routed to on-call channel
- [ ] Prometheus metrics exposed from FastAPI; Grafana dashboards created for LLM latency and error rates
- [ ] Uptime target documented: 99.5% SLA (~4 hours downtime/month)
- [ ] Health check endpoint (`/health`) confirmed monitored by uptime tool

**Compliance Documentation**

- [ ] GDPR data retention policy written and implemented
- [ ] Supplier PII handling procedure documented
- [ ] Audit log retention period defined
- [ ] Backup and recovery procedure documented for PostgreSQL

---

## Infrastructure Provisioning Checklist

The following infrastructure must be provisioned in the order listed before Phase 1 begins (target: complete by end of Week 3).

| Order | Component | Service | Required By |
|---|---|---|---|
| 1 | Domain + DNS | Registrar of choice | Week 1 |
| 2 | SSL Certificate | Let's Encrypt / Certbot | Week 1 |
| 3 | AWS S3 Bucket (`rfq-media`) | AWS S3 | Week 1 |
| 4 | AWS Secrets Manager setup | AWS Secrets Manager | Week 1 |
| 5 | PostgreSQL 16 instance | AWS RDS or Docker | Week 1 |
| 6 | Redis 7.x instance | AWS ElastiCache or Docker | Week 1 |
| 7 | EC2 `t3.medium` or ECS Fargate | AWS | Week 2 |
| 8 | Nginx reverse proxy | Docker container | Week 2 |
| 9 | GitHub Actions CI/CD pipeline | GitHub | Week 1 |
| 10 | Sentry project | Sentry | Week 3 |
| 11 | Prometheus + Grafana | Docker or managed | Week 3 |

---

## Environment & Secrets Setup

All secrets must be stored in AWS Secrets Manager (or HashiCorp Vault) in production. A `.env` file is acceptable only for local development and must never be committed to version control.

The following environment variables are required:

```env
# Meta / WhatsApp
META_APP_ID=
META_APP_SECRET=
WHATSAPP_PHONE_NUMBER_ID=
WHATSAPP_ACCESS_TOKEN=
WHATSAPP_WEBHOOK_VERIFY_TOKEN=
WHATSAPP_BUSINESS_ACCOUNT_ID=

# Anthropic
ANTHROPIC_API_KEY=

# OpenAI
OPENAI_API_KEY=

# PostgreSQL
DATABASE_URL=postgresql+asyncpg://user:password@host:5432/rfqbot

# Redis
REDIS_URL=redis://host:6379/0

# AWS
AWS_ACCESS_KEY_ID=
AWS_SECRET_ACCESS_KEY=
AWS_REGION=
S3_BUCKET_NAME=rfq-media

# Application
ENVIRONMENT=development|staging|production
SECRET_KEY=
LOG_LEVEL=INFO
```

---

## Development Toolchain Requirements

### Runtime

- Python 3.11+
- Docker + Docker Compose (all services containerized from Day 1)
- Node.js (for GitHub Actions tooling only)

### Core Python Dependencies

| Package | Purpose |
|---|---|
| `fastapi` | Async API framework |
| `uvicorn` | ASGI server |
| `celery[redis]` | Async task queue |
| `sqlalchemy[asyncio]` (v2.0) | ORM |
| `alembic` | Database migrations |
| `pydantic` (v2) | Runtime validation for all LLM outputs |
| `redis` | Session store client |
| `httpx` | Async HTTP client (WhatsApp media downloads) |
| `anthropic` | Anthropic API client |
| `openai` | OpenAI API client (Whisper) |
| `pdf2image` | PDF to image conversion for Vision pipeline |
| `Pillow` | Image preprocessing (rotation, contrast) |
| `boto3` | AWS S3 and Secrets Manager client |
| `python-dotenv` | Local `.env` loading |

### Code Quality

| Tool | Purpose |
|---|---|
| `ruff` | Linter |
| `black` | Code formatter |
| `mypy` | Static type checking |
| `pytest` + `pytest-asyncio` | Test framework (coverage target: >80%) |
| `pytest-httpx` | WhatsApp API mocking |
| `factory_boy` | Database fixture generation |

---

## Pre-Production Readiness Gates

A deployment to production is only permitted after all of the following gates pass:

1. **All PRD Section 3 acceptance criteria verified** across all four workflows (RFQ generation, multimodal ingestion, comparison, voice-to-DB)
2. **Security review completed:** HMAC validation, parameterized queries, secrets audit, PII encryption confirmed
3. **Load test passed:** 100 concurrent RFQ sessions without performance degradation
4. **Latency targets met** across all operations (text parse <3s, PDF <15s, audio <20s, DB write <5s post-YES)
5. **Monitoring stack live:** Sentry alerts configured, Grafana dashboards showing LLM latency and error rates
6. **Staging environment deployed and UAT completed** with real supplier phone numbers
7. **Dead letter queue and retry policies** verified through failure injection testing
8. **Audit log integrity verified:** every DB write traceable to source (voice note ID, message ID, or manual action)
9. **Meta message templates approved** for all business-initiated message types
10. **Documentation complete:** API docs auto-generated at `/docs`, deployment runbook written, rollback procedure documented

---

*Document prepared for Senior Python Developer / AIML — MVP Edition v1.0*  
*Sources: WhatsApp SaaS Platform Architecture Decision Framework; Fenestration RFQ Bot PRD/SOW/Wireframes*
