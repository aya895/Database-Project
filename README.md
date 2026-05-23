# 🛎️ The Boutique Hospitality — Database Management System
A relational database system for managing hotel reservations, guests, suites, concierge services, and curated guest experiences.

---

## 🖥️ Application Features

### CRUD Operations

Each of the 7 tables supports full **Create, Read, Update, and Delete** operations. The form dynamically reconfigures its input fields based on the selected table.

- **Insert** — Add new records with parameterized input fields
- **Update** — Edit existing records by entering the ID and updated values
- **Delete** — Remove records by primary key; composite delete supported for tables with 2 primary keys
- **Clear** — remove and clear input fields

### JOIN Query Views

Three pre-built cross-table JOIN queries available from the Joins dropdown:

1. **Reservations & Guests** — INNER JOIN across `RESERVATION`, `GUEST`, and `SUITE`; shows reservation ID, guest name, suite number, dates, total price, and status
2. **Experiences & Concierge** — INNER JOIN across `EXPERIENCE` and `CONCIERGE`; shows each experience alongside its managing concierge
3. **Reservation Experiences** — Three-way JOIN across `RESERVATION_EXPERIENCE`, `RESERVATION`, `GUEST`, and `EXPERIENCE`; shows which experiences are linked to which guest reservations

---

## 🗄️ Database Schema & Tables

The database contains 7 normalized tables connected through primary and foreign key relationships.

**HOTEL**
- `HOTEL_ID` (PK), `HOTEL_NAME`, `LOCATION`, `THEME`

**SUITE**
- `SUITE_ID` (PK), `HOTEL_ID` (FK → HOTEL), `SUITE_NUMBER`, `SUITE_CLASS`, `PRICE_PER_NIGHT`, `AMENITIES`

**GUEST**
- `GUEST_ID` (PK), `GUEST_NAME`, `EMAIL`, `PHONE`, `REGISTRATION_DATE`, `BILLING_ADDRESS`

**CONCIERGE**
- `CONCIERGE_ID` (PK), `CONCIERGE_NAME`, `SPECIALIZED_SKILLS`

**EXPERIENCE**
- `EXPERIENCE_ID` (PK), `CONCIERGE_ID` (FK → CONCIERGE), `EXPERIENCE_NAME`, `DESCRIPTION`

**RESERVATION**
- `RESERVATION_ID` (PK), `GUEST_ID` (FK → GUEST), `SUITE_ID` (FK → SUITE), `START_DATE`, `END_DATE`, `TOTAL_PRICE`, `RESERVATION_STATUS`

**RESERVATION_EXPERIENCE** *(junction table)*
- `RES_EXP_ID` (PK), `RESERVATION_ID` (FK → RESERVATION), `EXPERIENCE_ID` (FK → EXPERIENCE)

### Relationships

- **HOTEL → SUITE** — one hotel has many suites
- **GUEST → RESERVATION** — one guest has many reservations
- **SUITE → RESERVATION** — one suite appears in many reservations
- **CONCIERGE → EXPERIENCE** — one concierge manages many experiences
- **RESERVATION ✕ EXPERIENCE** — many-to-many via RESERVATION_EXPERIENCE

---

## 🛠️ Tech Stack

| Layer | Technology |
|---|---|
| Database | Microsoft SQL Server — T-SQL, constraints, foreign keys |
| Data Access | ADO.NET (`System.Data.SqlClient`) — `SqlConnection`, `SqlCommand`, `SqlDataAdapter` |
| Front-End | Windows Forms (WinForms) — .NET Framework |
| Language | C# (.NET Framework) |
| Authentication | Integrated Security (Windows Auth) via localhost connection string |
| UI Controls | `DataGridView`, `ComboBox`, `TextBox`, `Button`, `Label` |
| Query Pattern | Parameterized queries throughout — prevents SQL injection |
| Design Artifacts | Conceptual & Physical ER diagrams included in project folder |

---

## 👥 Team Members

- **Dina Ali Hamed**
- **Sama Hussein Mohamed**
- **Doaa Hany Abdelrahman**
- **Mayada Ahmed Hilmy**
- **Nada Mahmoud Morad**
- **Aya Safwat Kamel**

---
