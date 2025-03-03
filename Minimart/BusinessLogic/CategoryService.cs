using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class CategoryService : GenericService<Category>
    {
        public override async Task AddAsync(Category entity)
        {
            ValidateEntity(entity);

            var existingCategory = await _dao.GetAll()
                .AnyAsync(c => c.CategoryName == entity.CategoryName);

            if (existingCategory)
            {
                throw new InvalidOperationException("Category name must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(Category entity)
        {
            ValidateEntity(entity);

            var existingCategory = await _dao.GetAll()
                .AnyAsync(c => c.CategoryName == entity.CategoryName && c.CategoryID != entity.CategoryID);

            if (existingCategory)
            {
                throw new InvalidOperationException("Category name must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(Category entity)
        {
            if (string.IsNullOrWhiteSpace(entity.CategoryName))
            {
                throw new ArgumentException("Category name cannot be empty or null.");
            }

            if (entity.CategoryName.Length > 255)
            {
                throw new ArgumentException("Category name cannot exceed 255 characters.");
            }
        }
    }
}
