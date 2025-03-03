using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class EmployeeService : GenericService<Employee>
    {
        public async Task<List<Employee>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(e => e.Role)
                .ToListAsync();
        }

        public override async Task AddAsync(Employee entity)
        {
            ValidateEntity(entity);

            // Check if the employee's email, phone number, or citizen ID already exists
            var existingEmployee = await _dao.GetAll()
                .AnyAsync(e => e.Email == entity.Email || e.PhoneNumber == entity.PhoneNumber || e.CitizenID == entity.CitizenID);

            if (existingEmployee)
            {
                throw new InvalidOperationException("Employee email, phone number, or citizen ID must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(Employee entity)
        {
            ValidateEntity(entity);

            // Check if the email, phone number, or citizen ID exists for another employee (excluding the current one)
            var existingEmployee = await _dao.GetAll()
                .AnyAsync(e => (e.Email == entity.Email || e.PhoneNumber == entity.PhoneNumber || e.CitizenID == entity.CitizenID) && e.EmployeeID != entity.EmployeeID);

            if (existingEmployee)
            {
                throw new InvalidOperationException("Employee email, phone number, or citizen ID must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(Employee entity)
        {
            if (string.IsNullOrWhiteSpace(entity.FirstName))
            {
                throw new ArgumentException("First name cannot be empty or null.");
            }

            if (string.IsNullOrWhiteSpace(entity.LastName))
            {
                throw new ArgumentException("Last name cannot be empty or null.");
            }

            if (string.IsNullOrWhiteSpace(entity.Email))
            {
                throw new ArgumentException("Email cannot be empty or null.");
            }

            if (string.IsNullOrWhiteSpace(entity.PhoneNumber))
            {
                throw new ArgumentException("Phone number cannot be empty or null.");
            }

            if (!entity.Email.Contains("@"))
            {
                throw new ArgumentException("Email must be valid.");
            }

            if (entity.PhoneNumber.Length != 10 || !entity.PhoneNumber.All(char.IsDigit))
            {
                throw new ArgumentException("Phone number must be exactly 10 digits.");
            }

            if (entity.Salary.HasValue && entity.Salary < 0)
            {
                throw new ArgumentException("Salary cannot be negative.");
            }

            if (entity.BirthDate > DateTime.Now)
            {
                throw new ArgumentException("Birth date cannot be in the future.");
            }

            if (entity.CitizenID.Length < 10)
            {
                throw new ArgumentException("Citizen ID should be at least 10 characters long.");
            }
        }
    }
}
