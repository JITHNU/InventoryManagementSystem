# 🏪 Inventory Management System

## 1. Introduction
This **Inventory Management System** is a desktop application built using **C# Windows Forms** and **SQL Server**.  
It is designed for small businesses to manage **Products**, **Suppliers**, **Customers**, and **Sales** efficiently.

---

## 2. System Requirements
- **Operating System:** Windows 10 or later  
- **Software:**
  - Microsoft Visual Studio (2019 or later)  
  - .NET Framework (4.7.2 or later)  
  - Microsoft SQL Server (Express / Standard)  
- **Database:** MyProject

---

## 3. Installation
1. Clone or download the repository from GitHub.  
2. Open the solution file (`InventorySystem.sln`) in Visual Studio.  
3. Update the connection string in each form if needed:  

     Export Report: Export sales data to a CSV or Excel file for analysis.
     Generate Excel Report: Creates a formatted Excel sheet for business use.
4. Run the SQL script provided (`DatabaseScript.sql`) to create required tables.  
5. Build and run the project.

---

## 4. 🔑 Login Form
- **Purpose:** To authenticate users before accessing the system.  
- **Usage:** Enter **Username** and **Password** → click **Login**  
![Add Screenshot Here](link)

---

## 5. 🏠 Home Form
- Displays **low stock products** immediately after login.  
- Helps the business quickly identify items that need **re-ordering**.  
![Add Screenshot Here](link)

---

## 6. 📊 Dashboard
- The main **control panel** of the system.  
- Navigation buttons for:
- Products  
- Suppliers  
- Customers  
- Sales / Orders  
- Reports  
![Add Screenshot Here](link)

---

## 7. 📦 Product Management
- **Add Product:** Enter `ProductID`, `Name`, `Category`, `Quantity`, `Price`, `Reorder level`, `Supplier ID`  
- **Update Product:** Select from the list → Edit details → Save  
- **Delete Product:** Select product → Delete  
- **View Products:** Displays a table of all products  
![Add Screenshot Here](link)

---

## 8. 🏭 Supplier Management
- **Add Supplier:** Enter `SupplierID`, `Name`, `Contact`, `Address`, `Email`  
- **Update Supplier:** Modify supplier details  
- **Delete Supplier:** Remove supplier  
- **View Suppliers:** Displays all suppliers  
![Add Screenshot Here](link)

---

## 9. 🛒 Sales / Orders
- **Add Products to Cart:** Select product, enter quantity, and add to cart  
- **View Cart:** Displays selected items with quantity and total price  
- **Complete Sale:** Confirm and save sale → stock is updated automatically  
- **View Sales:** Shows sales history with date, product, customer, and total amount  
![Add Screenshot Here](link)

---

## 10. 📑 Reports
- **Filter Sales by Date:** Select a date range (From and To) to view sales  
- **Export Report:** Export sales data to CSV or Excel  
- **Generate Excel Report:** Creates a formatted Excel sheet for business use  
![Add Screenshot Here](link)

---

## 11. 🔒 Logout & Exit
- **Logout:** Return to the login screen  
- **Exit:** Close the application

---

## 12. 🛠️ Technologies Used
- **C#**  
- **Windows Forms**  
- **SQL Server**  
- **.NET Framework**

---

## 13. 📧 Contact
For issues, feedback, or collaboration, feel free to contact me:

- Email: `jithnukaweerasingha@gmail.com`  
- LinkedIn: https://linkedin.com/in/jithnuka-weerasinghe-b9408b25a

    
🖲️ 11. Logout & Exit
     Use the Logout button to return to the login screen.
     Use the Exit button to close the application.
