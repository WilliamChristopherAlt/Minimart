using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class SaleDetailService : GenericService<SaleDetail>
    {
        public async Task<List<SaleDetail>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(sd => sd.Sale)            // Include Sale
                .Include(sd => sd.ProductType)     // Include ProductType
                .ToListAsync();
        }

        public override async Task AddAsync(SaleDetail entity)
        {
            ValidateEntity(entity);

            // Ensure the product exists in the ProductTypes table
            var productExists = await _dao.GetAll()
                .AnyAsync(pt => pt.ProductTypeID == entity.ProductTypeID);

            if (!productExists)
            {
                throw new InvalidOperationException("Product type does not exist.");
            }

            // Check if the sale exists (for foreign key integrity)
            var saleExists = await _dao.GetAll()
                .AnyAsync(s => s.SaleID == entity.SaleID);

            if (!saleExists)
            {
                throw new InvalidOperationException("Sale does not exist.");
            }

            // Ensure that the quantity is greater than 0
            if (entity.Quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(SaleDetail entity)
        {
            ValidateEntity(entity);

            // Ensure the sale exists (foreign key check)
            var saleExists = await _dao.GetAll()
                .AnyAsync(s => s.SaleID == entity.SaleID);

            if (!saleExists)
            {
                throw new InvalidOperationException("Sale does not exist.");
            }

            // Ensure the product exists (foreign key check)
            var productExists = await _dao.GetAll()
                .AnyAsync(pt => pt.ProductTypeID == entity.ProductTypeID);

            if (!productExists)
            {
                throw new InvalidOperationException("Product type does not exist.");
            }

            // Ensure the quantity is greater than 0
            if (entity.Quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(SaleDetail entity)
        {
            // Check if SaleID is valid (exists)
            if (entity.SaleID <= 0)
            {
                throw new ArgumentException("Invalid SaleID.");
            }

            // Check if ProductTypeID is valid (exists)
            if (entity.ProductTypeID <= 0)
            {
                throw new ArgumentException("Invalid ProductTypeID.");
            }

            // Ensure quantity is valid
            if (entity.Quantity <= 0)
            {
                throw new ArgumentException("Quantity must be greater than zero.");
            }
        }
    }
}
