using System;

namespace Minimart.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }

    public class MeasurementUnit
    {
        public int MeasurementUnitID { get; set; }
        public string UnitName { get; set; }
        public string Description { get; set; }
    }

    public class ProductType
    {
        public int ProductTypeID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public int SupplierID { get; set; }
        public decimal Price { get; set; }
        public decimal StockAmount { get; set; }
        public int MeasurementUnitID { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateAdded { get; set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class EmployeeRole
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public decimal? Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int RoleID { get; set; }

        public EmployeeRole Role { get; set; }
    }

    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public string PaymentMethodName { get; set; }
    }

    public class Sale
    {
        public int SaleID { get; set; }
        public DateTime SaleDate { get; set; }
        public int? CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int PaymentMethodID { get; set; }

        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public class SaleDetail
    {
        public int SaleDetailID { get; set; }
        public int SaleID { get; set; }
        public int ProductTypeID { get; set; }
        public decimal Quantity { get; set; }
        public int MeasurementUnitID { get; set; }

        public Sale Sale { get; set; }
        public ProductType ProductType { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }

        public decimal GetTotalAmount()
        {
            return Quantity * ProductType.Price;
        }
    }

    public class AdminRole
    {
        public int AdminRoleID { get; set; }
        public string RoleName { get; set; }
        public string Description { get; set; }
        public bool CanView_Categories { get; set; }
        public bool CanEdit_Categories { get; set; }
        public bool CanView_Suppliers { get; set; }
        public bool CanEdit_Suppliers { get; set; }
        public bool CanView_MeasurementUnits { get; set; }
        public bool CanEdit_MeasurementUnits { get; set; }
        public bool CanView_ProductTypes { get; set; }
        public bool CanEdit_ProductTypes { get; set; }
        public bool CanView_Customers { get; set; }
        public bool CanEdit_Customers { get; set; }
        public bool CanView_EmployeeRoles { get; set; }
        public bool CanEdit_EmployeeRoles { get; set; }
        public bool CanView_Employees { get; set; }
        public bool CanEdit_Employees { get; set; }
        public bool CanView_Sales { get; set; }
        public bool CanEdit_Sales { get; set; }
        public bool CanView_SaleDetails { get; set; }
        public bool CanEdit_SaleDetails { get; set; }
        public bool CanView_AdminRoles { get; set; }
        public bool CanEdit_AdminRoles { get; set; }
        public bool CanView_Admins { get; set; }
        public bool CanEdit_Admins { get; set; }
    }

    public class Admin
    {
        public int AdminID { get; set; }
        public int EmployeeID { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] Salt { get; set; }
        public int AdminRoleID { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }

        public Employee Employee { get; set; }
        public AdminRole AdminRole { get; set; }
    }
}
