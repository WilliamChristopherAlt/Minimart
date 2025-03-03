using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class SupplierService : GenericService<Supplier>
    {
        private static readonly Regex PhoneRegex = new Regex(@"^0\d{9}$"); // Ensures 10 digits, starts with 0
        private static readonly Regex EmailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Basic email validation

        public override async Task AddAsync(Supplier entity)
        {
            ValidateEntity(entity);

            // Ensure SupplierName, SupplierEmail, and SupplierPhoneNumber are unique
            var existingSupplier = await _dao.GetAll()
                .AnyAsync(s => s.SupplierName == entity.SupplierName
                            || s.SupplierEmail == entity.SupplierEmail
                            || s.SupplierPhoneNumber == entity.SupplierPhoneNumber);

            if (existingSupplier)
            {
                throw new InvalidOperationException("Supplier name, email, and phone number must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(Supplier entity)
        {
            ValidateEntity(entity);

            // Ensure updated SupplierName, SupplierEmail, and SupplierPhoneNumber are still unique (excluding current supplier)
            var existingSupplier = await _dao.GetAll()
                .AnyAsync(s => (s.SupplierName == entity.SupplierName
                                || s.SupplierEmail == entity.SupplierEmail
                                || s.SupplierPhoneNumber == entity.SupplierPhoneNumber)
                                && s.SupplierID != entity.SupplierID);

            if (existingSupplier)
            {
                throw new InvalidOperationException("Updated supplier name, email, and phone number must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(Supplier entity)
        {
            if (string.IsNullOrWhiteSpace(entity.SupplierName))
            {
                throw new ArgumentException("Supplier name cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(entity.SupplierPhoneNumber) || !PhoneRegex.IsMatch(entity.SupplierPhoneNumber))
            {
                throw new ArgumentException("Invalid phone number format. It must be exactly 10 digits and start with '0'.");
            }

            if (string.IsNullOrWhiteSpace(entity.SupplierEmail) || !EmailRegex.IsMatch(entity.SupplierEmail))
            {
                throw new ArgumentException("Invalid email format.");
            }

            if (string.IsNullOrWhiteSpace(entity.SupplierAddress) || entity.SupplierAddress.Length < 5)
            {
                throw new ArgumentException("Supplier address must be at least 5 characters long.");
            }
        }
    }
}
