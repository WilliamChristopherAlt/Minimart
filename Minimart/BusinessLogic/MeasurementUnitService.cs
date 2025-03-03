using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class MeasurementUnitService : GenericService<MeasurementUnit>
    {
        public override async Task AddAsync(MeasurementUnit entity)
        {
            ValidateEntity(entity);

            var existingUnit = await _dao.GetAll()
                .AnyAsync(m => m.UnitName == entity.UnitName);

            if (existingUnit)
            {
                throw new InvalidOperationException("Unit name must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(MeasurementUnit entity)
        {
            ValidateEntity(entity);

            var existingUnit = await _dao.GetAll()
                .AnyAsync(m => m.UnitName == entity.UnitName && m.MeasurementUnitID != entity.MeasurementUnitID);

            if (existingUnit)
            {
                throw new InvalidOperationException("Unit name must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(MeasurementUnit entity)
        {
            if (string.IsNullOrWhiteSpace(entity.UnitName))
            {
                throw new ArgumentException("Unit name cannot be empty or null.");
            }

            if (entity.UnitName.Length > 50)
            {
                throw new ArgumentException("Unit name cannot exceed 50 characters.");
            }

            if (entity.IsContinuous != true && entity.IsContinuous != false)
            {
                throw new ArgumentException("IsContinuous must be a valid boolean value (true or false).");
            }
        }
    }
}
