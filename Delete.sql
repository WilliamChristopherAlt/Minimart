USE Minimart;
GO

-- Disable foreign key constraints temporarily
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT ALL";

-- Delete rows from all tables in the correct order to avoid foreign key violations

-- Start by deleting from child tables first
DELETE FROM SaleDetails;    -- Dependent on Sales and ProductTypes and PaymentMethods
DELETE FROM Sales;          -- Dependent on Customers and Employees
DELETE FROM Admins;         -- Dependent on Employees and AdminRoles
DELETE FROM Employees;      -- Dependent on EmployeeRoles
DELETE FROM ProductTypes;   -- Dependent on Categories, Suppliers, and MeasurementUnits
DELETE FROM Categories;     -- No dependencies
DELETE FROM Suppliers;      -- No dependencies
DELETE FROM Customers;      -- No dependencies
DELETE FROM MeasurementUnits; -- No dependencies
DELETE FROM EmployeeRoles;  -- No dependencies
DELETE FROM AdminRoles;     -- No dependencies
DELETE FROM PaymentMethods;     -- No dependencies

-- Re-enable foreign key constraints
EXEC sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL";
GO

-- Reset identity columns for all tables
DBCC CHECKIDENT ('Categories', RESEED, 0);
DBCC CHECKIDENT ('Suppliers', RESEED, 0);
DBCC CHECKIDENT ('ProductTypes', RESEED, 0);
DBCC CHECKIDENT ('Customers', RESEED, 0);
DBCC CHECKIDENT ('Employees', RESEED, 0);
DBCC CHECKIDENT ('Admins', RESEED, 0);
DBCC CHECKIDENT ('Sales', RESEED, 0);
DBCC CHECKIDENT ('SaleDetails', RESEED, 0);
DBCC CHECKIDENT ('MeasurementUnits', RESEED, 0);
DBCC CHECKIDENT ('EmployeeRoles', RESEED, 0);
DBCC CHECKIDENT ('AdminRoles', RESEED, 0);
DBCC CHECKIDENT ('PaymentMethods', RESEED, 0);
GO
