using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class AdminRoleService : GenericService<AdminRole>
    {
        public async Task<List<AdminRole>> GetAllWithPermissionsAsync()
        {
            return await _dao.GetAll()
                .ToListAsync();
        }

        public override async Task AddAsync(AdminRole entity)
        {
            ValidateEntity(entity);

            var existingRole = await _dao.GetAll()
                .AnyAsync(ar => ar.RoleName == entity.RoleName);

            if (existingRole)
            {
                throw new InvalidOperationException("Role name must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(AdminRole entity)
        {
            ValidateEntity(entity);

            var existingRole = await _dao.GetAll()
                .AnyAsync(ar => ar.RoleName == entity.RoleName && ar.AdminRoleID != entity.AdminRoleID);

            if (existingRole)
            {
                throw new InvalidOperationException("Role name must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(AdminRole entity)
        {
            if (string.IsNullOrWhiteSpace(entity.RoleName))
            {
                throw new ArgumentException("Role name cannot be empty or null.");
            }

            if (entity.RoleName.Length > 255)
            {
                throw new ArgumentException("Role name cannot exceed 255 characters.");
            }

            if (string.IsNullOrWhiteSpace(entity.RoleDescription))
            {
                throw new ArgumentException("Role description cannot be empty or null.");
            }

            if (entity.RoleDescription.Length > 1000)
            {
                throw new ArgumentException("Role description cannot exceed 1000 characters.");
            }
        }
    }
}
