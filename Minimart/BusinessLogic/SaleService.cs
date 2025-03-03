using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class SaleService : GenericService<Sale>
    {
        // Method to get all sales with related PaymentMethod, Customer, and Employee details
        public async Task<List<Sale>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(s => s.PaymentMethod)   // Including PaymentMethod details
                .Include(s => s.Customer)        // Including Customer details (if any)
                .Include(s => s.Employee)        // Including Employee details
                .ToListAsync();
        }

        // Method to get a sale by its ID with related details
        public async Task<Sale> GetByIdWithDetailsAsync(int saleId)
        {
            return await _dao.GetAll()
                .Where(s => s.SaleID == saleId)
                .Include(s => s.PaymentMethod)   // Including PaymentMethod details
                .Include(s => s.Customer)        // Including Customer details (if any)
                .Include(s => s.Employee)        // Including Employee details
                .FirstOrDefaultAsync();
        }

        // Add a new sale, including validation and uniqueness check
        public override async Task AddAsync(Sale entity)
        {
            ValidateEntity(entity);

            // Optional: Check if the sale already exists (based on your business rules)
            var existingSale = await _dao.GetAll()
                .AnyAsync(s => s.SaleDate == entity.SaleDate && s.EmployeeID == entity.EmployeeID && s.PaymentMethodID == entity.PaymentMethodID);

            if (existingSale)
            {
                throw new InvalidOperationException("Duplicate sale entry detected.");
            }

            await base.AddAsync(entity);
        }

        // Update an existing sale, including validation and uniqueness check
        public override async Task UpdateAsync(Sale entity)
        {
            ValidateEntity(entity);

            var existingSale = await _dao.GetAll()
                .AnyAsync(s => s.SaleDate == entity.SaleDate && s.EmployeeID == entity.EmployeeID && s.PaymentMethodID == entity.PaymentMethodID && s.SaleID != entity.SaleID);

            if (existingSale)
            {
                throw new InvalidOperationException("Duplicate sale entry detected.");
            }

            await base.UpdateAsync(entity);
        }

        // Validate sale entity to ensure the values are valid
        public override void ValidateEntity(Sale entity)
        {
            if (entity.EmployeeID <= 0)
            {
                throw new ArgumentException("Employee ID is required.");
            }

            if (entity.PaymentMethodID <= 0)
            {
                throw new ArgumentException("Payment method is required.");
            }

            if (entity.SaleDate == default)
            {
                throw new ArgumentException("Sale date is required.");
            }
        }
    }
}
