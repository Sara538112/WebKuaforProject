# Beauty Corner – Online Beauty Salon Reservation System 💇‍♀️

> ASP.NET MVC Web Application — Sakarya University  
> Course: Web Programlama


## Overview

Beauty Corner is a full-stack web application for managing a beauty salon's daily operations. It allows customers to book appointments, employees to manage their schedules, and managers to approve daily plans — all through a role-based interface.

---

## Features

### Customer
- Browse services and team members
- Create appointments by selecting department, available employee, and time slot
- View personal appointment history

### Admin / Manager
- Add and manage employees and managers
- Review and approve daily schedules
- Access full appointment list

### AI Feature
- Employees can upload a photo to get AI-powered style suggestions
- Returns 5 recommended images based on the uploaded photo

---

## Tech Stack

| Layer | Technology |
|---|---|
| Framework | ASP.NET Core MVC (Code-First) |
| Database | PostgreSQL |
| ORM | Entity Framework Core |
| Authentication | ASP.NET Core Identity |
| Authorization | Role-based (Admin, Manager, Employee, Customer) |
| API | REST API + HttpClient consumption |
| Frontend | HTML / CSS / Razor Views |

---

## Architecture

### Models
| Model | Description |
|---|---|
| `User` | Base class inheriting from `IdentityUser` |
| `Employee` | Inherits from User, represents salon staff |
| `Manager` | Inherits from User, manages schedules |
| `Department` | Represents service categories (Hair Cut, Manicure, etc.) |
| `Appointment` | Customer booking with date, time, department and employee |

### Relationship Models
| Model | Relationship |
|---|---|
| `AppointmentEmployee` | Links Appointment ↔ Employee |
| `DepEmployee` | Links Department ↔ Employee |
| `EmployeeManager` | Links Employee ↔ Manager |

### Controllers
- **HomeController** — Public pages: Index, Services, Team, MyAppointments, Schedule, SubmitApprovals
- **AppointmentController** — Department selection → available employees → available time slots
- **ManagerController** — Pending schedule approvals
- **AdminController** — Admin panel
- **EmployeeController** — Employee management
- **AIController** — AI-powered style recommendation
- **ApiController** — REST API for appointment deletion
- **ApiConsumeController** — HTTP client consumption

---

## Roles
-Admin     → Full access
-Manager   → Approve/manage schedules
-Employee  → View assigned appointments
-Customer  → Create and view appointments

---

## Services Offered

Hair Cut · Hair Care · Hair Dye · Manicure · Pedicure

## Database

- **PostgreSQL** database named `BeautySalon`
- Connection configured via `appsettings.json`
- Schema managed through Entity Framework Core Migrations
- Roles seeded in `ApplicationDbContext`

---
