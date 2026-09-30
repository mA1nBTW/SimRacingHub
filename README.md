# 🏎️ SimRacingHub Backend

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet)](https://dotnet.microsoft.com/)
[![PostgreSQL](https://img.shields.io/badge/PostgreSQL-16-336791?style=flat&logo=postgresql)](https://www.postgresql.org/)
[![Docker](https://img.shields.io/badge/Docker-Compose-2496ED?style=flat&logo=docker)](https://www.docker.com/)
[![Status](https://img.shields.io/badge/Status-In%20Development-orange?style=flat)](#)

A modular RESTful backend service designed for sim racing enthusiasts and community league management. The platform provides telemetry session tracking, driver statistics aggregation, and championship standings calculation across sim racing platforms.

> ⚠️ **Project Status:** Under active development. Core domain logic, database schemas, and API scaffolding are currently being implemented.

---

## 🛠️ Architecture & Tech Stack

This project focuses on applying clean architectural principles and industry-standard design patterns to handle high-throughput telemetry data and complex league calculations.

* **Framework:** C# / ASP.NET Core Web API (.NET 8)
* **Architecture Pattern:** CQRS (Command Query Responsibility Segregation) via **MediatR**
* **Persistence & ORM:** PostgreSQL, Entity Framework Core (Code-First migrations)
* **Containerization:** Docker & Docker Compose (for local development database and environment provisioning)
* **API Documentation:** Swagger / OpenAPI UI

---

## 📐 Key Design Highlights

* **Decoupled Business Logic:** Clean separation between API endpoints, MediatR command/query handlers, and domain models.
* **Database Modeling:** Relational schema designed for drivers, teams, race events, session results, and telemetry lap times with proper indexing.
* **Containerized Infrastructure:** One-command database environment bootstrap via `docker-compose.yml`.
* **Validation & Pipeline Behaviors:** Centralized validation and error handling using MediatR pipeline behaviors and FluentValidation.

---

## 🚀 Getting Started (Development Setup)

### Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download)
* [Docker Desktop](https://www.docker.com/products/docker-desktop/)

### 1. Clone the repository
```bash
git clone [https://github.com/mA1nBTW/SimRacingHub.git](https://github.com/mA1nBTW/SimRacingHub.git)
cd SimRacingHub
