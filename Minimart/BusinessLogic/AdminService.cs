using Microsoft.EntityFrameworkCore;
using Minimart.DatabaseAccess;
using Minimart.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class AdminService : GenericService<Admin>
    {
        private readonly GenericDAO<AdminRole> _daoAdminRole;

        public AdminService() : base()
        {
            var context = new MinimartDbContext();
            _daoAdminRole = new GenericDAO<AdminRole>(context);
        }

        public async Task<Admin> GetByUsernameAsync(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username cannot be empty or null.");
            }

            return await _dao.GetAll()
                .Include(a => a.Employee)  // Include related Employee data
                .Include(a => a.AdminRole) // Include related AdminRole data
                .FirstOrDefaultAsync(a => a.Username == username);
        }

        public async Task<List<Admin>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(a => a.Employee)  // Join with Employee table
                .Include(a => a.AdminRole) // Join with AdminRoles table
                .ToListAsync();
        }

        public async Task<string> GetRoleNameByIdAsync(int adminRoleId)
        {
            var adminRole = await _daoAdminRole.GetAll()
                                               .FirstOrDefaultAsync(ar => ar.AdminRoleID == adminRoleId);

            return adminRole?.RoleName ?? "Unknown Role";
        }

        public override async Task AddAsync(Admin entity)
        {
            ValidateEntity(entity);

            var existingAdminByUsername = await _dao.GetAll()
                .AnyAsync(a => a.Username == entity.Username);

            if (existingAdminByUsername)
            {
                throw new InvalidOperationException("Username must be unique.");
            }

            var existingAdminByEmployee = await _dao.GetAll()
                .AnyAsync(a => a.EmployeeID == entity.EmployeeID);

            if (existingAdminByEmployee)
            {
                throw new InvalidOperationException("Each employee can only have one admin account.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(Admin entity)
        {
            ValidateEntity(entity);

            var existingAdminByUsername = await _dao.GetAll()
                .AnyAsync(a => a.Username == entity.Username && a.AdminID != entity.AdminID);

            if (existingAdminByUsername)
            {
                throw new InvalidOperationException("Username must be unique.");
            }

            var existingAdminByEmployee = await _dao.GetAll()
                .AnyAsync(a => a.EmployeeID == entity.EmployeeID && a.AdminID != entity.AdminID);

            if (existingAdminByEmployee)
            {
                throw new InvalidOperationException("Each employee can only have one admin account.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(Admin entity)
        {
            if (string.IsNullOrWhiteSpace(entity.Username))
            {
                throw new ArgumentException("Username cannot be empty or null.");
            }

            if (entity.Username.Length > 255)
            {
                throw new ArgumentException("Username cannot exceed 255 characters.");
            }

            if (entity.PasswordHash == null || entity.PasswordHash.Length == 0)
            {
                throw new ArgumentException("Password hash cannot be empty.");
            }

            if (entity.Salt == null || entity.Salt.Length == 0)
            {
                throw new ArgumentException("Salt cannot be empty.");
            }
        }
    }
}
