using System.Collections.Generic;
using Minimart.DatabaseAccess;
using Minimart.Entities;

namespace Minimart.BusinessLogic
{
    public class GenericService<T> where T : class
    {
        protected GenericDAO<T> _dao;

        public GenericService()
        {
            _dao = new GenericDAO<T>();
        }

        public List<T> GetAll()
        {
            return _dao.GetAll();
        }

        public T GetById(int id)
        {
            return _dao.GetById(id);
        }

        public void Add(T entity)
        {
            _dao.Add(entity);
        }

        public void Update(T entity)
        {
            _dao.Update(entity);
        }

        public void Delete(int id)
        {
            _dao.Delete(id);
        }
    }

    public class SupplierService : GenericService<Supplier>
    {
        // Inherits all CRUD methods from GenericService<Supplier>
    }

    public class ProductTypeService : GenericService<ProductType>
    {
    }

    public class CategoryService : GenericService<Category>
    {
    }

    public class CustomerService : GenericService<Customer>
    {
    }

    public class EmployeeService : GenericService<Employee>
    {
    }

    public class SaleService : GenericService<Sale>
    {
    }

    public class SaleDetailService : GenericService<SaleDetail>
    {
    }

    public class AdminService : GenericService<Admin>
    {
    }

    public class EmployeeRoleService : GenericService<EmployeeRole>
    {
    }

    public class PaymentMethodService : GenericService<PaymentMethod>
    {
    }

    public class AdminRoleService : GenericService<AdminRole>
    {
    }

    public class MeasurementUnitService : GenericService<MeasurementUnit>
    {
    }
}
