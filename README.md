# InventoryManagementSystem

Inventory Management System – User
Manual

🖲️ 1. Introduction
    This Inventory Management System is a desktop application built using C# Windows Forms
    and SQL Server.
    It is designed for small businesses to manage Products, Suppliers, Customers, and Sales
    efficiently.
    
🖲️ 2. System Requirements
    🌏 Operating System: Windows 10 or later
    🌏 Software:
    🌏 Microsoft Visual Studio (2019 or later)
    🌏 .NET Framework (4.7.2 or later)
    🌏 Microsoft SQL Server (Express / Standard)
    🌏 Database: MyProject
    
🖲️ 3. Installation
    1. 2. 3. Clone or download the repository from GitHub.
    Open the solution file (InventorySystem.sln) in Visual Studio.
    Update the connection string in each form if needed:
    4. Server=DESKTOP-7JUK9DS\SQLEXPRESS04; Database=MyProject;
    Trusted_Connection=True;
    5. 6. Run the SQL script provided (DatabaseScript.sql) to create required tables.
    Build and run the project.
🖲️ 4. Login Form
    ✅ Purpose: To authenticate users before accessing the system.
    ✅ Enter Username and Password → click Login.
🖲️ 5. Home Form
    ✅ Displays low stock products immediately after login.
    ✅ Helps the business quickly identify items that need re-ordering.
🖲️ 6. Dashboard
    🚀 The main control panel of the system.
    🚀 Navigation buttons for:
    o Products
    o Suppliers
    o Customers
    o Sales / Orders
    o Reports
🖲️ 7. Product Management
     Add Product: Enter ProductID, Name, Category, Quantity, Price,Reorder
    level,Supplier ID
     Update Product: Select from the list → Edit details → Save.
     Delete Product: Select product → Delete.
     View Products: Displays a table of all products.
🖲️ 8. Supplier Management
     Add Supplier: Enter SupplierID, Name, Contact, Address,Email.
     Update Supplier: Modify supplier details.
     Delete Supplier: Remove supplier.
     View Suppliers: Displays all suppliers.
🖲️ 9. Sales / Orders
     Add Products to Cart: Select product, enter quantity, and add to cart.
     View Cart: Displays selected items with quantity and total price.
     Complete Sale: Confirm and save sale → stock is updated automatically.
     View Sales: Shows sales history with date, product, customer, and total amount.
🖲️ 10. Reports
     Filter Sales by Date: Select a date range (From and To) to view sales.
     Export Report: Export sales data to a CSV or Excel file for analysis.
     Generate Excel Report: Creates a formatted Excel sheet for business use.
🖲️ 11. Logout & Exit
     Use the Logout button to return to the login screen.
     Use the Exit button to close the application.
