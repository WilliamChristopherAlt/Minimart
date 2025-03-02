using System.Collections.Generic;
using System.Threading.Tasks;
using Minimart.DatabaseAccess;
using Minimart.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

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

        // Add a new record asynchronously
        public async Task AddAsync(T entity)
        {
            await _dao.AddAsync(entity);
        }

        // Update an existing record asynchronously
        public async Task UpdateAsync(T entity)
        {
            await _dao.UpdateAsync(entity);
        }

        // Delete a record by ID asynchronously
        public async Task DeleteAsync(int id)
        {
            await _dao.DeleteAsync(id);
        }
    }

    public class SupplierService : GenericService<Supplier> { }

    public class ProductTypeService : GenericService<ProductType>
    {
        public async Task<List<ProductType>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(pt => pt.Category)
                .Include(pt => pt.Supplier)
                .Include(pt => pt.MeasurementUnit)
                .ToListAsync();
        }
    }

    public class CategoryService : GenericService<Category> { }

    public class CustomerService : GenericService<Customer> { }

    public class EmployeeService : GenericService<Employee>
    {
        public async Task<List<Employee>> GetAllWithRoleNamesAsync()
        {
            return await _dao.GetAll()
                .Include(e => e.Role)  // Include the related EmployeeRole
                .ToListAsync();
        }
    }

    public class SaleService : GenericService<Sale>
    {
        public async Task<List<Sale>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(s => s.Customer)
                .Include(s => s.Employee)
                .Include(s => s.PaymentMethod)
                .ToListAsync();
        }
    }

    public class SaleDetailService : GenericService<SaleDetail>
    {
        public async Task<List<SaleDetail>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(sd => sd.Sale)
                .Include(sd => sd.ProductType)
                .ToListAsync();
        }
    }

    public class AdminService : GenericService<Admin>
    {
        public async Task<List<Admin>> GetAllWithForeignNamesAsync()
        {
            return await _dao.GetAll()
                .Include(a => a.Employee)
                .Include(a => a.AdminRole)
                .ToListAsync();
        }
    }

    public class EmployeeRoleService : GenericService<EmployeeRole> { }

    public class PaymentMethodService : GenericService<PaymentMethod> { }

    public class AdminRoleService : GenericService<AdminRole> { }

    public class MeasurementUnitService : GenericService<MeasurementUnit> { }
}
