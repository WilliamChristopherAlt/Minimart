using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore; // Required for DbContext
using Minimart.Entities;

namespace Minimart.DatabaseAccess
{
    public class GenericDAO<T> where T : class
    {
        protected readonly MinimartDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericDAO()
        {
            _context = new MinimartDbContext();
            _dbSet = _context.Set<T>(); // Dynamically gets the corresponding table
        }

        // Get all records
        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }

        // Get a record by primary key (ID)
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        // Add a new record
        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        // Update an existing record
        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        // Delete a record by ID
        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }
    }
}
