🎓 Student Management System – ASP.NET MVC

A web-based Student Management System built using ASP.NET MVC and Entity Framework, designed to perform complete CRUD operations with a clean UI and reusable Upsert functionality.

🚀 Project Overview

This project allows administrators to manage student records efficiently.
It follows MVC architecture, uses Entity Framework (Code First) for database operations, and implements a single Upsert form for both Create and Update actions.

✨ Features

✅ Student CRUD Operations (Create, Read, Update, Delete)

🔁 Upsert Functionality (Single form for Add & Edit)

📋 Student List with Edit, Details & Delete actions

🎨 Bootstrap-based responsive UI

🟢 Color-coded action buttons (Create, Edit, Details, Delete)

🗄️ Entity Framework Code First approach

🧱 Clean MVC folder structure

🛠️ Technologies Used

ASP.NET MVC 5

C#

Entity Framework 6 (Code First)

SQL Server

Bootstrap

HTML / CSS / Razor Views

Visual Studio

📂 Project Structure
StudentManagementSystem
│
├── Controllers
│   └── StudentController.cs
│
├── Models
│   └── Student.cs
│
├── Views
│   └── Student
│       ├── Index.cshtml
│       ├── Upsert.cshtml
│       ├── Details.cshtml
│       └── Delete.cshtml
│
├── Data
│   └── ApplicationDbContext.cs
│
└── wwwroot / Content

🔁 Upsert Logic Explained

If StudentId == 0 → Create Student

If StudentId > 0 → Update Student

Same view (Upsert.cshtml) is reused for both actions

Reduces code duplication and improves maintainability

🎨 UI Button Standards
Action	Color
Add Student	🟢 Green
Edit	🔵 Blue
Details	🔷 Info
Delete	🔴 Red
📸 Screenshots (Optional)

You can add screenshots here to make the project more attractive
Example:

<img width="1339" height="918" alt="Screenshot 2026-02-08 170547" src="https://github.com/user-attachments/assets/5ad588fc-47d0-463b-9aab-5959551850c3" />

<img width="1765" height="907" alt="Screenshot 2026-02-08 170613" src="https://github.com/user-attachments/assets/6ac95532-98bd-4856-8f91-0c1c55261dff" />


📌 Future Enhancements

🔐 Authentication & Role-based Authorization (Admin / Student)

🔍 Search & Filter Students

📄 Pagination

📤 Export to Excel / PDF

🎓 Course & Department Management

📊 Dashboard with analytics

🧑‍💻 Author
Manish Chauhan


⭐ Show Your Support

If you like this project, please ⭐ star the repository — it really helps!
