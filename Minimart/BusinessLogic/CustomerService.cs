using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class CustomerService : GenericService<Customer>
    {
        public override async Task AddAsync(Customer entity)
        {
            ValidateEntity(entity);

            // Check if the email or phone number already exists
            var existingCustomer = await _dao.GetAll()
                .AnyAsync(c => c.Email == entity.Email || c.PhoneNumber == entity.PhoneNumber);

            if (existingCustomer)
            {
                throw new InvalidOperationException("Email or phone number must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(Customer entity)
        {
            ValidateEntity(entity);

            // Check if the email or phone number already exists but not for the current customer
            var existingCustomer = await _dao.GetAll()
                .AnyAsync(c => (c.Email == entity.Email || c.PhoneNumber == entity.PhoneNumber) && c.CustomerID != entity.CustomerID);

            if (existingCustomer)
            {
                throw new InvalidOperationException("Email or phone number must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(Customer entity)
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

            if (entity.PhoneNumber.Length != 10)
            {
                throw new ArgumentException("Phone number must be exactly 10 digits.");
            }

            if (entity.Email.Length > 255)
            {
                throw new ArgumentException("Email cannot exceed 255 characters.");
            }

            if (entity.FirstName.Length > 255)
            {
                throw new ArgumentException("First name cannot exceed 255 characters.");
            }

            if (entity.LastName.Length > 255)
            {
                throw new ArgumentException("Last name cannot exceed 255 characters.");
            }
        }
    }
}
