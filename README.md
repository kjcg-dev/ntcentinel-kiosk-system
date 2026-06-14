# NTCentinel: Automated Student Violation Management System

[![SDG Goal 4: Quality Education](https://img.shields.io/badge/SDG-Goal%204-gold)](https://sdgs.un.org/goals/goal4)
[![SDG Goal 11: Sustainable Cities and Communities](https://img.shields.io/badge/SDG-Goal%2011-orange)](https://sdgs.un.org/goals/goal11)

## Project Title & SDG Goal
**Project Title:** NTCentinel  
**Primary SDG Goal:** **Goal 4: Quality Education** & **Goal 11: Sustainable Cities and Communities**

**NTCentinel** is an award-winning, hardware-integrated enterprise kiosk solution engineered to eliminate manual operational bottlenecks and optimize entry-point traffic flow. **Awarded 1st Place Champion & Best System Architecture**, the platform digitizes and automates end-to-end incident tracking while ensuring strict legal and data compliance (SDG 4) and mitigating hazardous pedestrian sidewalk congestion at school gates (SDG 11).

---

## Project Description

### The Problem
The traditional manual logging system at NTC relies on physical logbooks. This leads to:
* **Manual Bottlenecks:** Processing each student takes significant time, causing long lines that spill onto public streets, posing physical safety risks.
* **Data Integrity Issues:** Administrative overhead and text legibility issues make it difficult for the Office of Student Affairs (OSA) to audit, decode, and encode data accurately.
* **Security Risks:** Physical logbooks containing sensitive student data are vulnerable to unauthenticated visibility and lack data governance.

### The Solution: NTCentinel
NTCentinel is a digital kiosk solution that integrates hardware and software to streamline perimeter security and incident tracking. It utilizes high-speed QR code scanning for near-instant identity verification and an intuitive touchscreen interface for security operators to log preset violations seamlessly.

### Architecture Justification
The system follows a scalable **Client-Server Architecture** optimized for Local Area Network (LAN) deployment:
* **QR Integration:** Chosen for high-speed data retrieval (decoding under 1 second), crucial for maintaining peak checkpoint traffic flow.
* **Centralized Database (SQL):** Ensures real-time synchronization between the entry kiosk and the administrative backend, enabling an automated policy enforcement engine.
* **Thermal Printing Module:** Drives immediate physical receipt generation for transparent accountability and strict adherence to organizational policy.
* **Role-Based Access Control (RBAC):** Fully compliant with the legal protections defined in the Data Privacy Act of 2012, ensuring zero unauthorized access to sensitive records.

---

## Key Features
* **Operational Efficiency:** Accelerated checkpoint processing speeds to **under 3 seconds per user** via QR integration, eliminating entrance congestion.
* **Automated Policy Enforcement:** Built automated business logic to track repeat incidents, calculate escalations dynamically, and trigger instant system flags ("3-Strike Rule").
* **Digital Audit Trail:** Eliminates human encoding errors and equips management with data integrity and real-time operational analytics.
* **Network Fault Tolerance:** Implements robust edge-caching to store transaction layers locally during network drops, syncing automatically upon reconnection.

---

## Contributor
| Role / Lead Architect | Primary Contribution / Assigned Module |
| :--- | :--- |
| **Gracias, Kevin Jay C.** <br> *Project Lead & Systems Automation Architect* | End-to-end Project Management, System Architecture, Database Schema Design, SRS Engineering, Hardware Integration, UI/UX Design, and Frontend Development. |

---

## Technical Stack
* **Language:** VB.NET (Windows Forms Architecture)
* **Database:** SQL-Based Relational Database (Structured Schema)
* **Hardware:** Embedded QR Scanner, Thermal Receipt Printer, Heavy-Duty Touchscreen Kiosk
* **Network:** Local Area Network (LAN) with Local Edge-Caching

---
*Maintained as an Enterprise Portfolio Asset | Developed as a System Analysis & Design Blueprint.*
