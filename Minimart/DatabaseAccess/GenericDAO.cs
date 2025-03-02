using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Minimart.DatabaseAccess
{
    public class GenericDAO<T> where T : class
    {
        protected readonly MinimartDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericDAO(MinimartDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return _context.Set<T>(); // This just returns a queryable collection.
        }


        // Get all records asynchronously
        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                return await _dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log exception here (e.g., using a logging framework)
                throw new InvalidOperationException("Error fetching all records.", ex);
            }
        }

        // Get a record by primary key (ID) asynchronously
        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                // Log exception here (e.g., using a logging framework)
                throw new InvalidOperationException($"Error fetching record by ID: {id}", ex);
            }
        }

        // Add a new record asynchronously
        public async Task AddAsync(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log exception here (e.g., using a logging framework)
                throw new InvalidOperationException("Error adding entity", ex);
            }
        }

        // Update an existing record asynchronously
        public async Task UpdateAsync(T entity)
        {
            try
            {
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                // Log exception here (e.g., using a logging framework)
                throw new InvalidOperationException("Error updating entity", ex);
            }
        }

        // Delete a record by ID asynchronously
        public async Task DeleteAsync(int id)
        {
            try
            {
                var entity = await _dbSet.FindAsync(id);
                if (entity != null)
                {
                    _dbSet.Remove(entity);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    throw new KeyNotFoundException($"Entity with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                // Log exception here (e.g., using a logging framework)
                throw new InvalidOperationException($"Error deleting entity with ID: {id}", ex);
            }
        }
    }

}
