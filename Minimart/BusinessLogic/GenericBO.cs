using System.Collections.Generic;
using System.Threading.Tasks;
using Minimart.DatabaseAccess;
using Minimart.Entities;
using Microsoft.EntityFrameworkCore;

namespace Minimart.BusinessLogic
{
    public class GenericService<T> where T : class
    {
        protected readonly GenericDAO<T> _dao;

        public GenericService()
        {
            var context = new MinimartDbContext();
            _dao = new GenericDAO<T>(context);
        }

        // Get all records asynchronously
        public async Task<List<T>> GetAllAsync()
        {
            return await _dao.GetAllAsync();
        }

        // Get a record by ID asynchronously
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dao.GetByIdAsync(id);
        }

        public virtual async Task AddAsync(T entity)
        {
            await _dao.AddAsync(entity);
        }

        public virtual async Task UpdateAsync(T entity)
        {
            await _dao.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
            await _dao.DeleteAsync(id);
        }

        public virtual void ValidateEntity(T entity)
        {
        }

    }
}
