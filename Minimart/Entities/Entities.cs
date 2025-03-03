using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Minimart.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }

    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierEmail { get; set; }
    }

    public class MeasurementUnit
    {
        public int MeasurementUnitID { get; set; }
        public string UnitName { get; set; }
        public string UnitDescription { get; set; }
        public bool IsContinuous { get; set; }
    }

    public class ProductType
    {
        public int ProductTypeID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
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

        public string FullName => $"{FirstName} {LastName} ({CustomerID})";
    }


    public class EmployeeRole
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    }

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string CitizenID { get; set; }
        public decimal? Salary { get; set; }
        public DateTime HireDate { get; set; }
        public int RoleID { get; set; }

        public EmployeeRole Role { get; set; }

        public string FullName => $"{FirstName} {LastName} ({EmployeeID})";
    }

    public class PaymentMethod
    {
        public int PaymentMethodID { get; set; }
        public string MethodName { get; set; }
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

        public string FormattedSale => $"{SaleDate:dd/MM/yyyy} ({SaleID})";
    }

    public class SaleDetail
    {
        public int SaleDetailID { get; set; }
        public int SaleID { get; set; }
        public int ProductTypeID { get; set; }
        public decimal Quantity { get; set; }

        public Sale Sale { get; set; }
        public ProductType ProductType { get; set; }
    }

    public class AdminRole
    {
        public int AdminRoleID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public bool CanViewCategories { get; set; }
        public bool CanEditCategories { get; set; }
        public bool CanViewSuppliers { get; set; }
        public bool CanEditSuppliers { get; set; }
        public bool CanViewMeasurementUnits { get; set; }
        public bool CanEditMeasurementUnits { get; set; }
        public bool CanViewProductTypes { get; set; }
        public bool CanEditProductTypes { get; set; }
        public bool CanViewCustomers { get; set; }
        public bool CanEditCustomers { get; set; }
        public bool CanViewEmployeeRoles { get; set; }
        public bool CanEditEmployeeRoles { get; set; }
        public bool CanViewEmployees { get; set; }
        public bool CanEditEmployees { get; set; }
        public bool CanViewPaymentMethods { get; set; }
        public bool CanEditPaymentMethods { get; set; }
        public bool CanViewSales { get; set; }
        public bool CanEditSales { get; set; }
        public bool CanViewSaleDetails { get; set; }
        public bool CanEditSaleDetails { get; set; }
        public bool CanViewAdminRoles { get; set; }
        public bool CanEditAdminRoles { get; set; }
        public bool CanViewAdmins { get; set; }
        public bool CanEditAdmins { get; set; }
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

        public void SetHashAndSalt(string password)
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                Salt = new byte[32];
                rng.GetBytes(Salt);
            }

            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] combinedBytes = new byte[passwordBytes.Length + Salt.Length];

                Buffer.BlockCopy(Salt, 0, combinedBytes, 0, Salt.Length);
                Buffer.BlockCopy(passwordBytes, 0, combinedBytes, Salt.Length, passwordBytes.Length);

                PasswordHash = sha256.ComputeHash(combinedBytes);
            }
        }

        public bool VerifyPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] combinedBytes = new byte[passwordBytes.Length + Salt.Length];

                Buffer.BlockCopy(Salt, 0, combinedBytes, 0, Salt.Length);
                Buffer.BlockCopy(passwordBytes, 0, combinedBytes, Salt.Length, passwordBytes.Length);

                byte[] computedHash = sha256.ComputeHash(combinedBytes);

                return StructuralComparisons.StructuralEqualityComparer.Equals(PasswordHash, computedHash);
            }
        }
    }
}
