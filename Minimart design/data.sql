use Minimart

INSERT INTO Categories (CategoryName, CategoryDescription) VALUES
('Beverages', 'Drinks and liquids including sodas, juices, and water'),
('Snacks', 'Packaged snack foods such as chips, cookies, and candy'),
('Dairy', 'Milk, cheese, butter, and other dairy products'),
('Fruits', 'Fresh and canned fruits like apples, bananas, and peaches'),
('Vegetables', 'Fresh and canned vegetables such as carrots, spinach, and beans'),
('Frozen Foods', 'Frozen meals, vegetables, and ice cream'),
('Bakery', 'Bread, cakes, and other baked goods'),
('Personal Care', 'Personal hygiene and beauty products'),
('Cleaning Supplies', 'Household cleaning materials and tools'),
('Health', 'Vitamins, supplements, and health-related items');

INSERT INTO Suppliers (SupplierName, SupplierPhoneNumber, SupplierAddress, SupplierEmail) VALUES
('Fresh Foods Supplier', '0123456789', '123 Fresh St, Food City', 'contact@freshfoods.com'),
('Snack World', '0234567890', '456 Snack Ave, Snacktown', 'info@snackworld.com'),
('Dairy Best', '0345678901', '789 Dairy Rd, Milktown', 'sales@dairybest.com'),
('Fruit Farm', '0456789012', '101 Orchard Dr, Fruitville', 'orders@fruitfarm.com'),
('Veggie Co', '0567890123', '202 Green Ln, Veggietown', 'support@veggieco.com'),
('Frozen Delights', '0678901234', '303 Ice Cream Blvd, Freeze City', 'contact@frozendelights.com'),
('Bake It Fresh', '0789012345', '404 Cake Rd, Bakerytown', 'hello@bakeitfresh.com'),
('Beauty Plus', '0890123456', '505 Beauty Ln, Glamour City', 'service@beautyplus.com'),
('Clean Sweep', '0901234567', '606 Clean Ave, Sanitize City', 'info@cleansweep.com'),
('Wellness Shop', '0102345678', '707 Health Rd, Wellness City', 'customerservice@wellnessshop.com');

INSERT INTO MeasurementUnits (UnitName, UnitDescription, IsContinuous) VALUES
('kg', 'Kilogram - Weight measurement', 1),
('liters', 'Liter - Volume measurement', 1),
('pcs', 'Pieces - Unit count', 0),
('g', 'Gram - Weight measurement', 1),
('ml', 'Milliliter - Volume measurement', 1),
('box', 'Box - A box containing multiple items', 0),
('m', 'Meter - Length measurement', 1),
('cm', 'Centimeter - Length measurement', 1),
('yard', 'Yard - Length measurement', 1),
('inch', 'Inch - Length measurement', 1);

-- Insert 15 ProductTypes into ProductTypes Table
INSERT INTO ProductTypes (ProductName, ProductDescription, CategoryID, SupplierID, Price, StockAmount, MeasurementUnitID)
VALUES
    ('Cola', 'Carbonated soft drink', 1, 1, 1.99, 100, 5),  -- Beverages, Fresh Foods Supplier, Price 1.99, 100 pcs, liters
    ('Orange Juice', 'Freshly squeezed orange juice', 1, 4, 3.49, 50, 5),  -- Beverages, Fruit Farm, Price 3.49, 50 pcs, liters
    ('Chips', 'Potato chips in various flavors', 2, 2, 1.49, 200, 3),  -- Snacks, Snack World, Price 1.49, 200 pcs, grams
    ('Chocolate Bar', 'Milk chocolate bar', 2, 2, 0.99, 150, 3),  -- Snacks, Snack World, Price 0.99, 150 pcs, grams
    ('Cheddar Cheese', 'Aged cheddar cheese', 3, 3, 5.99, 80, 4),  -- Dairy, Dairy Best, Price 5.99, 80 pcs, kg
    ('Milk', 'Whole milk', 3, 3, 2.49, 120, 5),  -- Dairy, Dairy Best, Price 2.49, 120 pcs, liters
    ('Bananas', 'Fresh ripe bananas', 4, 4, 0.69, 300, 2),  -- Fruits, Fruit Farm, Price 0.69, 300 pcs, kg
    ('Apple', 'Red apples', 4, 4, 1.29, 250, 2),  -- Fruits, Fruit Farm, Price 1.29, 250 pcs, kg
    ('Carrots', 'Fresh organic carrots', 5, 5, 0.89, 150, 2),  -- Vegetables, Veggie Co, Price 0.89, 150 pcs, kg
    ('Spinach', 'Organic spinach', 5, 5, 2.99, 120, 2),  -- Vegetables, Veggie Co, Price 2.99, 120 pcs, kg
    ('Frozen Pizza', 'Frozen pepperoni pizza', 6, 6, 4.99, 50, 6),  -- Frozen Foods, Frozen Delights, Price 4.99, 50 pcs, box
    ('Ice Cream', 'Chocolate ice cream', 6, 6, 3.49, 80, 5),  -- Frozen Foods, Frozen Delights, Price 3.49, 80 pcs, liters
    ('Bread', 'Freshly baked bread', 7, 7, 2.49, 100, 6),  -- Bakery, Bake It Fresh, Price 2.49, 100 pcs, box
    ('Cake', 'Chocolate cake', 7, 7, 5.99, 60, 6),  -- Bakery, Bake It Fresh, Price 5.99, 60 pcs, box
    ('Shampoo', 'Hair care shampoo', 8, 8, 4.99, 150, 3);  -- Personal Care, Beauty Plus, Price 4.99, 150 pcs, liters
GO

INSERT INTO Customers (FirstName, LastName, Email, PhoneNumber) VALUES
('Sophia', 'Taylor', 'sophia.taylor@email.com', '0555202001'),
('Liam', 'Martin', 'liam.martin@email.com', '0555202002'),
('Olivia', 'Anderson', 'olivia.anderson@email.com', '0555202003'),
('Noah', 'Thomas', 'noah.thomas@email.com', '0555202004'),
('Ava', 'Jackson', 'ava.jackson@email.com', '0555202005'),
('James', 'White', 'james.white@email.com', '0555202006'),
('Isabella', 'Harris', 'isabella.harris@email.com', '0555202007'),
('Mason', 'Clark', 'mason.clark@email.com', '0555202008'),
('Mia', 'Rodriguez', 'mia.rodriguez@email.com', '0555202009'),
('Ethan', 'Lewis', 'ethan.lewis@email.com', '0555202010');

INSERT INTO EmployeeRoles (RoleName, RoleDescription)
VALUES 
    ('Sales Associate', 'Responsible for assisting customers, managing product sales, and handling transactions at the register.'),
    ('Inventory Manager', 'Oversees product stock, manages inventory levels, and coordinates reordering of products.'),
    ('Customer Service Representative', 'Handles customer inquiries, complaints, and returns/exchanges.'),
    ('Store Manager', 'Responsible for overseeing store operations, staff management, and ensuring customer satisfaction.'),
    ('Cashier', 'Operates the cash register, processes payments, and assists with checkout.'),
    ('Marketing Coordinator', 'Plans and executes marketing strategies to promote the store and its products.'),
    ('Security Officer', 'Ensures the safety and security of the store and its customers by monitoring surveillance systems and preventing theft.'),
    ('Product Specialist', 'Specializes in a particular product category, providing expertise and support to customers and staff.'),
    ('Operations Supervisor', 'Oversees the daily operations of the store, ensuring efficiency and adherence to procedures.'),
    ('HR Manager', 'Manages employee recruitment, payroll, benefits, and personnel records.');
GO

-- Insert 20 Employees
INSERT INTO Employees (FirstName, LastName, Email, PhoneNumber, Gender, BirthDate, CitizenID, Salary, HireDate, RoleID)
VALUES 
    ('John', 'Doe', 'john.doe@example.com', '0123456789', 'Male', '1985-07-12', 'A123456789', 35000.00, '2022-01-15', 1),  -- Sales Associate
    ('Jane', 'Smith', 'jane.smith@example.com', '0123456790', 'Female', '1990-03-20', 'B987654321', 40000.00, '2021-03-20', 2),  -- Inventory Manager
    ('Michael', 'Johnson', 'michael.johnson@example.com', '0123456791', 'Male', '1983-08-05', 'C123987654', 32000.00, '2023-05-10', 3),  -- Customer Service Representative
    ('Emily', 'Davis', 'emily.davis@example.com', '0123456792', 'Female', '1995-11-25', 'D456654321', 50000.00, '2019-11-25', 4),  -- Store Manager
    ('David', 'Williams', 'david.williams@example.com', '0123456793', 'Male', '1988-12-22', 'E678912345', 30000.00, '2020-08-02', 5),  -- Cashier
    ('Sarah', 'Miller', 'sarah.miller@example.com', '0123456794', 'Female', '1992-01-18', 'F123456789', 45000.00, '2021-01-18', 6),  -- Marketing Coordinator
    ('Robert', 'Moore', 'robert.moore@example.com', '0123456795', 'Male', '1987-06-13', 'G987654321', 38000.00, '2022-06-30', 7),  -- Security Officer
    ('Laura', 'Taylor', 'laura.taylor@example.com', '0123456796', 'Female', '1991-09-22', 'H234567890', 42000.00, '2018-09-22', 8),  -- Product Specialist
    ('James', 'Anderson', 'james.anderson@example.com', '0123456797', 'Male', '1985-04-10', 'I987654321', 46000.00, '2020-12-05', 9),  -- Operations Supervisor
    ('Linda', 'Thomas', 'linda.thomas@example.com', '0123456798', 'Female', '1978-02-19', 'J234567890', 55000.00, '2017-02-19', 10),  -- HR Manager
    ('Mark', 'Jackson', 'mark.jackson@example.com', '0123456799', 'Male', '1993-07-13', 'K123987654', 37000.00, '2021-07-13', 1),  -- Sales Associate
    ('Patricia', 'White', 'patricia.white@example.com', '0123456800', 'Female', '1989-03-30', 'L234567891', 42000.00, '2022-03-22', 2),  -- Inventory Manager
    ('William', 'Harris', 'william.harris@example.com', '0123456801', 'Male', '1995-05-01', 'M123456789', 34000.00, '2023-06-01', 3),  -- Customer Service Representative
    ('Elizabeth', 'Martin', 'elizabeth.martin@example.com', '0123456802', 'Female', '1982-05-14', 'N234567890', 48000.00, '2019-05-14', 4),  -- Store Manager
    ('Joseph', 'Lee', 'joseph.lee@example.com', '0123456803', 'Male', '1990-09-10', 'O987654321', 29000.00, '2021-09-10', 5),  -- Cashier
    ('Jessica', 'Gonzalez', 'jessica.gonzalez@example.com', '0123456804', 'Female', '1991-12-05', 'P234567890', 46000.00, '2020-11-28', 6),  -- Marketing Coordinator
    ('Charles', 'Lopez', 'charles.lopez@example.com', '0123456805', 'Male', '1992-02-07', 'Q987654321', 38000.00, '2022-02-07', 7),  -- Security Officer
    ('Karen', 'Perez', 'karen.perez@example.com', '0123456806', 'Female', '1986-12-17', 'R234567890', 41000.00, '2018-12-17', 8),  -- Product Specialist
    ('Thomas', 'Clark', 'thomas.clark@example.com', '0123456807', 'Male', '1989-04-15', 'S123987654', 47000.00, '2023-04-15', 9),  -- Operations Supervisor
    ('Nancy', 'Rodriguez', 'nancy.rodriguez@example.com', '0123456808', 'Female', '1980-10-04', 'T234567890', 53000.00, '2019-10-04', 10); -- HR Manager
GO

-- Insert Payment Methods into PaymentMethods Table
INSERT INTO PaymentMethods (MethodName)
VALUES 
    ('Cash'),
    ('Credit Card'),
    ('Debit Card');
GO

-- Insert 15 Sales transactions using PaymentMethodID with specific times
INSERT INTO Sales (SaleDate, CustomerID, EmployeeID, PaymentMethodID)
VALUES 
    ('2024-02-01 08:30:00', 1, 3, 2),  -- Credit Card
    ('2024-02-02 09:45:00', 2, 5, 1),  -- Cash
    ('2024-02-03 10:00:00', 3, 7, 3),  -- Debit Card
    ('2024-02-04 11:15:00', 4, 2, 2),  -- Credit Card
    ('2024-02-05 12:30:00', 5, 6, 1),  -- Cash
    ('2024-02-06 13:45:00', 6, 10, 2), -- Credit Card
    ('2024-02-07 14:00:00', 7, 12, 3), -- Debit Card
    ('2024-02-08 15:15:00', 8, 1, 1),  -- Cash
    ('2024-02-09 16:30:00', 9, 4, 2),  -- Credit Card
    ('2024-02-10 17:45:00', 10, 9, 1), -- Cash
    ('2024-02-11 18:00:00', NULL, 13, 2),  -- Non-registered customer (Credit Card)
    ('2024-02-12 19:15:00', NULL, 15, 3),  -- Non-registered customer (Debit Card)
    ('2024-02-13 20:30:00', 1, 16, 2),  -- Credit Card
    ('2024-02-14 21:45:00', 3, 18, 1),  -- Cash
    ('2024-02-15 22:00:00', 6, 20, 3);  -- Debit Card
GO


-- Insert 50 SaleDetails rows into SaleDetails Table
INSERT INTO SaleDetails (SaleID, ProductTypeID, Quantity)
VALUES
    (1, 1, 3),    -- Sale 1: Cola (3 liters)
    (1, 2, 2),    -- Sale 1: Orange Juice (2 liters)
    (1, 5, 5),    -- Sale 1: Cheddar Cheese (5 kg)
    (2, 3, 10),   -- Sale 2: Chips (10 kg)
    (2, 4, 6),    -- Sale 2: Chocolate Bar (6 pcs)
    (2, 8, 3),    -- Sale 2: Shampoo (3 liters)
    (3, 6, 2),    -- Sale 3: Frozen Pizza (2 boxes)
    (3, 9, 8),    -- Sale 3: Bread (8 boxes)
    (3, 1, 5),    -- Sale 3: Cola (5 liters)
    (4, 4, 12),   -- Sale 4: Bananas (12 kg)
    (4, 5, 7),    -- Sale 4: Carrots (7 kg)
    (4, 10, 4),   -- Sale 4: Spinach (4 kg)
    (5, 6, 3),    -- Sale 5: Ice Cream (3 liters)
    (5, 2, 5),    -- Sale 5: Orange Juice (5 liters)
    (5, 7, 10),   -- Sale 5: Milk (10 liters)
    (6, 3, 15),   -- Sale 6: Chips (15 kg)
    (6, 1, 7),    -- Sale 6: Cola (7 liters)
    (6, 9, 6),    -- Sale 6: Bread (6 boxes)
    (7, 8, 2),    -- Sale 7: Shampoo (2 liters)
    (7, 4, 20),   -- Sale 7: Bananas (20 kg)
    (7, 10, 10),  -- Sale 7: Spinach (10 kg)
    (8, 7, 8),    -- Sale 8: Milk (8 liters)
    (8, 5, 5),    -- Sale 8: Cheddar Cheese (5 kg)
    (8, 6, 4),    -- Sale 8: Frozen Pizza (4 boxes)
    (9, 1, 3),    -- Sale 9: Cola (3 liters)
    (9, 2, 4),    -- Sale 9: Orange Juice (4 liters)
    (9, 3, 8),    -- Sale 9: Chips (8 kg)
    (10, 9, 2),   -- Sale 10: Bread (2 boxes)
    (10, 10, 6),  -- Sale 10: Spinach (6 kg)
    (10, 4, 4),   -- Sale 10: Chocolate Bar (4 pcs)
    (11, 5, 12),  -- Sale 11: Cheddar Cheese (12 kg)
    (11, 6, 5),   -- Sale 11: Ice Cream (5 liters)
    (11, 3, 7),   -- Sale 11: Chips (7 kg)
    (12, 7, 10),  -- Sale 12: Milk (10 liters)
    (12, 1, 2),   -- Sale 12: Cola (2 liters)
    (12, 4, 5),   -- Sale 12: Chocolate Bar (5 pcs)
    (13, 2, 8),   -- Sale 13: Orange Juice (8 liters)
    (13, 6, 6),   -- Sale 13: Frozen Pizza (6 boxes)
    (13, 10, 4),  -- Sale 13: Spinach (4 kg)
    (14, 3, 4),   -- Sale 14: Chips (4 kg)
    (14, 5, 9),   -- Sale 14: Cheddar Cheese (9 kg)
    (14, 8, 1),   -- Sale 14: Shampoo (1 liter)
    (15, 9, 3),   -- Sale 15: Bread (3 boxes)
    (15, 1, 6),   -- Sale 15: Cola (6 liters)
    (15, 7, 15);  -- Sale 15: Milk (15 liters)
GO

-- Insert roles with corrected permissions for all tables
INSERT INTO AdminRoles (RoleName, RoleDescription, 
    CanViewCategories, CanEditCategories, 
    CanViewSuppliers, CanEditSuppliers, 
    CanViewMeasurementUnits, CanEditMeasurementUnits, 
    CanViewProductTypes, CanEditProductTypes, 
    CanViewCustomers, CanEditCustomers, 
    CanViewEmployeeRoles, CanEditEmployeeRoles, 
    CanViewEmployees, CanEditEmployees, 
    CanViewSales, CanEditSales, 
    CanViewSaleDetails, CanEditSaleDetails, 
    CanViewAdminRoles, CanEditAdminRoles, 
    CanViewAdmins, CanEditAdmins,
    CanViewPaymentMethods, CanEditPaymentMethods)
VALUES 
('Sales Manager', 'Manages customer interactions and sales transactions. No access to inventory, pricing, or admin-related tables.', 
    0, 0, -- Categories (No access)
    0, 0, -- Suppliers (No access)
    0, 0, -- MeasurementUnits (No access)
    0, 0, -- ProductTypes (No access)
    1, 1, -- Customers (View and Edit)
    1, 1, -- Sales (View and Edit)
    1, 1, -- SaleDetails (View and Edit)
    0, 0, -- EmployeeRoles (No access)
    0, 0, -- Employees (No access)
    0, 0, -- AdminRoles (No access)
    0, 0, -- Admins (No access)
    1, 1), -- PaymentMethods (View and Edit)

('Inventory Manager', 'Manages products, stock levels, categories, and suppliers. No access to financial records, sales, or admin-related tables.', 
    1, 1, -- Categories (View and Edit)
    1, 1, -- Suppliers (View and Edit)
    1, 1, -- MeasurementUnits (View and Edit)
    1, 1, -- ProductTypes (View and Edit)
    0, 0, -- Customers (No access)
    0, 0, -- Sales (No access)
    0, 0, -- SaleDetails (No access)
    0, 0, -- EmployeeRoles (No access)
    1, 0, -- Employees (View only)
    0, 0, -- AdminRoles (No access)
    0, 0, -- Admins (No access)
    0, 0), -- PaymentMethods (No access)

('HR & Payroll Admin', 'Manages employee records, salaries, and role assignments. No access to sales or inventory.', 
    0, 0, -- Categories (No access)
    0, 0, -- Suppliers (No access)
    0, 0, -- MeasurementUnits (No access)
    0, 0, -- ProductTypes (No access)
    0, 0, -- Customers (No access)
    0, 0, -- Sales (No access)
    0, 0, -- SaleDetails (No access)
    1, 1, -- EmployeeRoles (View and Edit)
    1, 1, -- Employees (View and Edit)
    0, 0, -- AdminRoles (No access)
    0, 0, -- Admins (No access)
    0, 0), -- PaymentMethods (No access)

('Finance & Accounting Admin', 'Manages financial records related to sales, revenue tracking, and supplier payments. No access to inventory, HR, or admin settings.', 
    0, 0, -- Categories (No access)
    1, 1, -- Suppliers (View and Edit)
    0, 0, -- MeasurementUnits (No access)
    0, 0, -- ProductTypes (No access)
    0, 0, -- Customers (No access)
    0, 0, -- Sales (No access)
    0, 0, -- SaleDetails (No access)
    0, 0, -- EmployeeRoles (No access)
    0, 0, -- Employees (No access)
    1, 1, -- AdminRoles (View and Edit)
    0, 0, -- Admins (No access)
    1, 0), -- PaymentMethods (View only)

('System Administrator', 'The highest-level admin with complete access to all tables, including managing admin accounts and system-wide settings.', 
    1, 1, -- Categories (View and Edit)
    1, 1, -- Suppliers (View and Edit)
    1, 1, -- MeasurementUnits (View and Edit)
    1, 1, -- ProductTypes (View and Edit)
    1, 1, -- Customers (View and Edit)
    1, 1, -- Sales (View and Edit)
    1, 1, -- SaleDetails (View and Edit)
    1, 1, -- EmployeeRoles (View and Edit)
    1, 1, -- Employees (View and Edit)
    1, 1, -- AdminRoles (View and Edit)
    1, 1, -- Admins (View and Edit)
    1, 1); -- PaymentMethods (View and Edit)

-- Insert multiple admin roles in one command
INSERT INTO Admins (EmployeeID, Username, PasswordHash, Salt, AdminRoleID)
VALUES 
    (2, 'smith_ima', 0x3D2A1C5A9F9C8C9A5F00D38D824D4951D1440D8A2B5A9A1BDEBC1B6B6A895D8F, 0xA5F4C7F9812C834F, 2),
    (4, 'davis_sma', 0x79F7C1B2F9C5F2C1D4B073C01C7A6C1D6B9E5A15B8A90F3F4C74A7E7B1BB1DA, 0xE62D894FE1CBB890, 3),
    (10, 'thomas_hra', 0x2A8F3E4A58C3B61F3B383BC3F3A94576A62360E17B22D2E4D1FAF64A8E7436F4, 0x7B9F1635A4CCAA13, 4),
    (13, 'white_faa', 0x9FBD53615A8712B19320C9C87237F45F7D8896F87B8A00A2F3093D0C20D89D89, 0xB2A16E5F20D9E5B7, 5),
    (1, 'doe_sya', 0x4B63AC8D634C220F5B3213A175BB26C1D9A3D10F4F6B08A2C53342C1A7089E2D, 0xE3D4A2407F310ACD, 1);

