using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class ProductTypeService : GenericService<ProductType>
    {
        public async Task<List<ProductType>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(pt => pt.Category)
                .Include(pt => pt.Supplier)
                .Include(pt => pt.MeasurementUnit)
                .ToListAsync();
        }

        public override async Task AddAsync(ProductType entity)
        {
            ValidateEntity(entity);

            var existingProduct = await _dao.GetAll()
                .AnyAsync(pt => pt.ProductName == entity.ProductName);

            if (existingProduct)
            {
                throw new InvalidOperationException("Product name must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(ProductType entity)
        {
            ValidateEntity(entity);

            var existingProduct = await _dao.GetAll()
                .AnyAsync(pt => pt.ProductName == entity.ProductName && pt.ProductTypeID != entity.ProductTypeID);

            if (existingProduct)
            {
                throw new InvalidOperationException("Product name must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(ProductType entity)
        {
            if (string.IsNullOrWhiteSpace(entity.ProductName))
            {
                throw new ArgumentException("Product name cannot be empty or null.");
            }

            if (entity.ProductName.Length > 255)
            {
                throw new ArgumentException("Product name cannot exceed 255 characters.");
            }

            if (entity.Price < 0)
            {
                throw new ArgumentException("Price cannot be negative.");
            }

            if (entity.StockAmount < 0)
            {
                throw new ArgumentException("Stock amount cannot be negative.");
            }
        }
    }

}
