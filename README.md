# Sales Control System


## Description ( This project contains a project that is using texts in Portuguese )



Welcome to the Sales Control System project! This application is designed to manage sales, employees, suppliers, and customers with ease. Built with Windows Forms and connected to a MySQL database, it leverages the VIACEP API for address lookup. This robust system features user registration and login, access levels, and roles to ensure secure and efficient operations.

![cliente](https://github.com/user-attachments/assets/b54358af-8b87-47ce-957d-99b5e6c03aa3)



## Features 

- **User Registration and Login**: Secure user authentication with role-based access control.
  - Roles: Manager, Employee
  - Access Levels: User, Administrator
- **Sales Management**:
  - Record new sales
  - View sales history
- **Employee Management**:
  - Register and manage employees
  - Search and update employee details
- **Supplier Management**:
  - Register and manage suppliers
  - Search and update supplier details
- **Customer Management**:
  - Register and manage customers
  - Search and update customer details
- **Product Sales Control**:
  - Manage product sales
  - Track inventory and sales performance
- **Historical Data**:
  - View historical sales data for analysis

## Technologies Used

- **Windows Forms**: For the graphical user interface.
- **MySQL**: For database management.
- **VIACEP API**: For address lookup and validation.

## Getting Started

### Prerequisites

- Visual Studio
- MySQL Server
- Internet access for VIACEP API

### Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/DenianRamos/Sales-Control-System.git
## Database Configuration
- Ensure your MySQL server is running.
- Import the database schema provided in the db folder.
- Update the connection string in the app.config file:
- ```cs
  <connectionStrings>
  <add name="bdvendas" connectionString="server=localhost;database=bdvendas;uid=root;pwd=yourpassword;" providerName="MySql.Data.MySqlClient"/></connectionStrings>```

### Database Configuration

- Ensure your MySQL server is running.
- Import the database schema provided in the `db` folder.
  - You can find the SQL script [here](https://drive.google.com/file/d/1i169xuiI0lI6Kb2yK3mSSfOs47YQnnQK/view).



  

### Usage
## Login:
- Use your credentials to log in. Administrators have full access, while users have limited access based on their roles.
## Manage Entities:
- Navigate through the menu to manage employees, suppliers, customers, and products.
## Sales Operations:
- Record new sales and view the sales history.
## Address Lookup:
- Use the integrated VIACEP API for accurate address information during registration.

  
