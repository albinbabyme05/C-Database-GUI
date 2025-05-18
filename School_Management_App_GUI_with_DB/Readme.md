# 🏫 School Management App (WinForms + PostgreSQL)

This is a simple Windows Forms (WinForms) application that allows school administrators or teachers to **mark attendance**, **view student lists**, and **track attendance history** using a **PostgreSQL database**.

## 📦 Features

- ✅ Mark student attendance (Present/Absent)
- 📅 Pick a date and store attendance records
- 👨‍🎓 View student list from the database
- 📊 View attendance history per student
- ♻️ Reset form to default state

## 💻 Technologies Used

- C# (WinForms)
- PostgreSQL (via Npgsql)
- Visual Studio
- .NET Framework (or .NET 6+ if upgraded)

## 🗂️ Project Structure

School_Management_App_GUI_with_DB/
├── Core/
│ └── DataBaseManager.cs # Handles DB operations
| └──    Student.cs
├── Validators/
│ └──  DataVaildator.cs
├── Form1.cs # Main GUI logic
├── Form1.Designer.cs # Auto-generated UI layout
├── README.md # This file



## 🛠️ Prerequisites

- PostgreSQL installed and running locally on port `5432`
- A database named `School` with the relevant schema (students, attendance tables)
- update the connection string accordingly

## Outputs
![121](https://github.com/user-attachments/assets/03d37cdb-ad0b-4cdd-b819-ceeb19192fd3)
![122](https://github.com/user-attachments/assets/5f0f6c47-f7b4-4e93-9759-5959d84a6cf5)
![123](https://github.com/user-attachments/assets/80f3fd6b-6185-41ef-ab4a-2e21edd16bc5)




