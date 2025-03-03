using Microsoft.EntityFrameworkCore;
using Minimart.Entities;
using System;
using System.Threading.Tasks;

namespace Minimart.BusinessLogic
{
    public class PaymentMethodService : GenericService<PaymentMethod>
    {
        public override async Task AddAsync(PaymentMethod entity)
        {
            ValidateEntity(entity);

            // Check if a payment method with the same name already exists
            var existingPaymentMethod = await _dao.GetAll()
                .AnyAsync(p => p.MethodName == entity.MethodName);

            if (existingPaymentMethod)
            {
                throw new InvalidOperationException("Payment method name must be unique.");
            }

            await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(PaymentMethod entity)
        {
            ValidateEntity(entity);

            // Check if a payment method with the same name exists (excluding the current one)
            var existingPaymentMethod = await _dao.GetAll()
                .AnyAsync(p => p.MethodName == entity.MethodName && p.PaymentMethodID != entity.PaymentMethodID);

            if (existingPaymentMethod)
            {
                throw new InvalidOperationException("Payment method name must be unique.");
            }

            await base.UpdateAsync(entity);
        }

        public override void ValidateEntity(PaymentMethod entity)
        {
            if (string.IsNullOrWhiteSpace(entity.MethodName))
            {
                throw new ArgumentException("Payment method name cannot be empty or null.");
            }

            if (entity.MethodName.Length > 50)
            {
                throw new ArgumentException("Payment method name cannot exceed 50 characters.");
            }
        }
    }
}
