USE Minimart;
GO

-- Create Categories Table (Product categorization)
CREATE TABLE Categories (
    CategoryID INT PRIMARY KEY IDENTITY(1,1),  
    CategoryName VARCHAR(255) NOT NULL UNIQUE,  
    CategoryDescription TEXT NULL  
);

-- Create Suppliers Table (Track suppliers)
CREATE TABLE Suppliers (
    SupplierID INT PRIMARY KEY IDENTITY(1,1),  
    SupplierName VARCHAR(255) NOT NULL UNIQUE,  
    SupplierPhoneNumber VARCHAR(50) NOT NULL,
    SupplierAddress VARCHAR(255) NULL,  
    SupplierEmail VARCHAR(255) NOT NULL UNIQUE
);

-- Create MeasurementUnits Table (Track product measurement units)
CREATE TABLE MeasurementUnits (
    MeasurementUnitID INT PRIMARY KEY IDENTITY(1,1),
    UnitName VARCHAR(50) NOT NULL UNIQUE,  -- e.g., kg, liters, pieces
    UnitDescription TEXT NULL
);

-- Create ProductTypes Table (Products that exist in the store catalog)
CREATE TABLE ProductTypes (
    ProductTypeID INT PRIMARY KEY IDENTITY(1,1),  
    ProductName VARCHAR(255) NOT NULL UNIQUE,  
    ProductDescription TEXT NULL,  
    CategoryID INT NOT NULL,  
    SupplierID INT NOT NULL,  
    Price DECIMAL(10,2) NOT NULL CHECK (Price >= 0),  -- Price should always be >= 0
    StockAmount DECIMAL(10,2) DEFAULT 0 CHECK (StockAmount >= 0),  -- Quantity should be >= 0
    MeasurementUnitID INT NOT NULL,  -- Reference to MeasurementUnits table
    IsActive BIT DEFAULT 1,  
    DateAdded DATETIME DEFAULT GETDATE(),  
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID) ON DELETE CASCADE,
    FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID) ON DELETE CASCADE,
    FOREIGN KEY (MeasurementUnitID) REFERENCES MeasurementUnits(MeasurementUnitID) ON DELETE CASCADE
);

-- Create Customers Table (Track buyers)
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),  
    FirstName VARCHAR(255) NOT NULL,  
    LastName VARCHAR(255) NOT NULL,  
    Email VARCHAR(255) NOT NULL UNIQUE,
    PhoneNumber VARCHAR(50) NOT NULL UNIQUE
);

-- Create EmployeeRoles Table (Define roles for employees)
CREATE TABLE EmployeeRoles (
    RoleID INT PRIMARY KEY IDENTITY(1,1),  
    RoleName VARCHAR(255) NOT NULL UNIQUE,  -- e.g., Sales, Inventory, etc.
    RoleDescription TEXT NULL  
);

-- Create Employees Table (Track staff)
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),  
    FirstName VARCHAR(255) NOT NULL,  
    LastName VARCHAR(255) NOT NULL,  
    Email VARCHAR(255) NOT NULL UNIQUE,  
    PhoneNumber VARCHAR(50) NOT NULL UNIQUE,  
    Gender VARCHAR(20) NOT NULL CHECK (Gender IN ('Male', 'Female', 'Non-Binary', 'Prefer not to say')),  
    BirthDate DATE NOT NULL DEFAULT '2000-01-01',   
    CitizenID VARCHAR(100) NOT NULL UNIQUE,  
    Salary DECIMAL(10,2) CHECK (Salary >= 0) NULL,  
    HireDate DATETIME DEFAULT GETDATE(),
    RoleID INT NOT NULL,
    FOREIGN KEY (RoleID) REFERENCES EmployeeRoles(RoleID) ON DELETE CASCADE
);

-- Create PaymentMethods Table (Store available payment methods)
CREATE TABLE PaymentMethods (
    PaymentMethodID INT PRIMARY KEY IDENTITY(1,1),  
    MethodName VARCHAR(50) NOT NULL UNIQUE  -- e.g., Cash, Credit Card, Debit Card, etc.
);
GO

-- Update Sales Table to reference PaymentMethods
CREATE TABLE Sales (
    SaleID INT PRIMARY KEY IDENTITY(1,1),  
    SaleDate DATETIME DEFAULT GETDATE(),  
    CustomerID INT NULL,  -- Customer can be NULL (i.e., non-registered customer)
    EmployeeID INT NOT NULL,  
    PaymentMethodID INT NOT NULL,  -- Reference to PaymentMethods table
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE,
    FOREIGN KEY (PaymentMethodID) REFERENCES PaymentMethods(PaymentMethodID) ON DELETE CASCADE
);
GO

-- Create SaleDetails Table (Line items of each sale)
CREATE TABLE SaleDetails (
    SaleDetailID INT PRIMARY KEY IDENTITY(1,1),  
    SaleID INT NOT NULL,  
    ProductTypeID INT NOT NULL,  
    Quantity DECIMAL(10,2) NOT NULL CHECK (Quantity > 0),
    FOREIGN KEY (SaleID) REFERENCES Sales(SaleID) ON DELETE CASCADE,  
    FOREIGN KEY (ProductTypeID) REFERENCES ProductTypes(ProductTypeID) ON DELETE CASCADE
);

-- Create AdminRoles Table (Permissions for admins)
CREATE TABLE AdminRoles (
    AdminRoleID INT PRIMARY KEY IDENTITY(1,1),
    RoleName VARCHAR(255) NOT NULL UNIQUE,
    RoleDescription TEXT NULL,
    -- Permissions for each table (View and Edit access)
    CanViewCategories BIT DEFAULT 0,
    CanEditCategories BIT DEFAULT 0,
    CanViewSuppliers BIT DEFAULT 0,
    CanEditSuppliers BIT DEFAULT 0,
    CanViewMeasurementUnits BIT DEFAULT 0,
    CanEditMeasurementUnits BIT DEFAULT 0,
    CanViewProductTypes BIT DEFAULT 0,
    CanEditProductTypes BIT DEFAULT 0,
    CanViewCustomers BIT DEFAULT 0,
    CanEditCustomers BIT DEFAULT 0,
    CanViewEmployeeRoles BIT DEFAULT 0,
    CanEditEmployeeRoles BIT DEFAULT 0,
    CanViewEmployees BIT DEFAULT 0,
    CanEditEmployees BIT DEFAULT 0,
	CanViewPaymentMethods BIT DEFAULT 0,
    CanEditPaymentMethods BIT DEFAULT 0,
	CanViewSales BIT DEFAULT 0,
    CanEditSales BIT DEFAULT 0,
    CanViewSaleDetails BIT DEFAULT 0,
    CanEditSaleDetails BIT DEFAULT 0,
    CanViewAdminRoles BIT DEFAULT 0,
    CanEditAdminRoles BIT DEFAULT 0,
    CanViewAdmins BIT DEFAULT 0,
    CanEditAdmins BIT DEFAULT 0
);

-- Create Admins Table (System Administrators)
CREATE TABLE Admins (
    AdminID INT PRIMARY KEY IDENTITY(1,1),  
    EmployeeID INT UNIQUE NOT NULL,  -- Added Foreign Key to Employees
    Username VARCHAR(255) UNIQUE NOT NULL,  
    PasswordHash VARBINARY(64) NOT NULL,  
    Salt VARBINARY(32) NOT NULL,  
    AdminRoleID INT NOT NULL,  -- Reference to AdminRoles table
    CreatedAt DATETIME DEFAULT GETDATE(),  
    LastLogin DATETIME NULL,  
    IsActive BIT DEFAULT 1,
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID) ON DELETE CASCADE,
    FOREIGN KEY (AdminRoleID) REFERENCES AdminRoles(AdminRoleID) ON DELETE CASCADE
);
GO
