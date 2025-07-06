# MVCProjects

# 💼 Expense Tracker – ASP.NET Core MVC (Code First)

A personal expense tracking web application built using **ASP.NET Core MVC**, **Entity Framework Core (Code First)**, and **SQL Server**. This project allows users to manage their expenses by category, date, and amount, and lays the foundation to import and link real **bank transactions** for deeper analysis.

---

## 🔧 Tech Stack

- ASP.NET Core MVC (.NET 6/7)
- Entity Framework Core (Code First)
- SQL Server / LocalDB
- Razor Views
- Bootstrap 5
- C#

---

## 📦 Features

- ✅ Add, edit, delete expenses
- ✅ Categorize expenses (Food, Transport, Medical, etc.)
- ✅ View all expenses in a list
- ✅ Automatically seed categories on first run
- ✅ Validation for form inputs
- ✅ Chart-ready structure for future dashboard/analytics
- ✅ Designed for extensibility (bank import, reports, etc.)

---

## 🛠️ Setup Instructions

### 1. Clone the Repository

```bash
git clone https://github.com/yourusername/MVCProject.git
cd MVCProject
2. Configure the Database
In appsettings.json, update your SQL Server connection string:

json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=ExpenseTrackerDb;Trusted_Connection=True;"
}
💡 You can use LocalDB or full SQL Server instance.

3. Apply Migrations & Seed Data
Using the .NET CLI:

bash
Copy
Edit
dotnet ef migrations add InitialCreate
dotnet ef database update
This creates the database and tables, and seeds default categories.

4. Run the Project
bash
Copy
Edit
dotnet run
Navigate to: https://localhost:5001
Default route: /Expenses/Index

📁 Project Structure
java
Copy
Edit
MVCProject/
│
├── Controllers/         → MVC Controllers (ExpenseController, etc.)
├── Models/              → EF Code-First Models (Expense, Category)
├── Views/               → Razor Views (Create, Edit, Index, etc.)
├── Data/                → AppDbContext (DbContext & seeding)
├── wwwroot/             → Static files (CSS, JS)
└── appsettings.json     → Connection strings & config
💡 Future Enhancements
⬆️ Import bank transactions via CSV

🔄 Auto-match transactions to expenses

📊 Dashboard with category-wise & monthly charts

🔐 Authentication & user-specific expenses

📤 Export reports (PDF, Excel)

🤝 Contributing
Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change or add.

📜 License
This project is licensed under the MIT License.
