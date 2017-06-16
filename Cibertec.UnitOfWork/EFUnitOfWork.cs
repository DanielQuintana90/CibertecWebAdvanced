using Cibertec.Models;
using Cibertec.Repositories;
using Cibertec.Repositories.Northwind;
using Cibertec.Repositories.Northwind.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Cibertec.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public EFUnitOfWork(DbContext dbContext)
        {
            Customers = new CustomerRepository(dbContext);
            //Orders = new Repository<Order>(dbContext);
            //OrderItems = new Repository<OrderItem>(dbContext);
            //Products = new Repository<Product>(dbContext);
            //Suppliers = new Repository<Supplier>(dbContext);
        }

        public ICustomerRepository Customers { get; private set; }
        public IOrderRepository Orders { get; private set; }
        public IOrderItemRepository OrderItems { get; private set; }
        public IProductRepository Products { get; private set; }
        public ISupplierRepository Suppliers { get; private set; }
    }
}
