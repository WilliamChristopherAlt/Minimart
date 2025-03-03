using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class EmployeeRoleService : GenericService<EmployeeRole>
    {
        public override async Task AddAsync(EmployeeRole entity)
        {
            ValidateEntity(entity);

            var existingRole = await _dao.GetAll()
                .AnyAsync(r => r.RoleName == entity.RoleName);

            if (existingRole)
            {
                throw new InvalidOperationException("Role name must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(EmployeeRole entity)
        {
            ValidateEntity(entity);

            var existingRole = await _dao.GetAll()
                .AnyAsync(r => r.RoleName == entity.RoleName && r.RoleID != entity.RoleID);

            if (existingRole)
            {
                throw new InvalidOperationException("Role name must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(EmployeeRole entity)
        {
            if (string.IsNullOrWhiteSpace(entity.RoleName))
            {
                throw new ArgumentException("Role name cannot be empty or null.");
            }

            if (entity.RoleName.Length > 255)
            {
                throw new ArgumentException("Role name cannot exceed 255 characters.");
            }
        }
    }
}
