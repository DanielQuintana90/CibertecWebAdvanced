using Cibertec.Models;
using Cibertec.Repositories;
using Cibertec.Repositories.Interfaces;
using Cibertec.UnitOfWork.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Cibertec.UnitOfWork
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public EFUnitOfWork(DbContext dbContext)
        {
            Customers = new Repository<Customer>(dbContext);
            Orders = new Repository<Order>(dbContext);
            OrderItems = new Repository<OrderItem>(dbContext);
            Products = new Repository<Product>(dbContext);
            Suppliers = new Repository<Supplier>(dbContext);
        }

        public IRepository<Customer> Customers { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<OrderItem> OrderItems { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Supplier> Suppliers { get; private set; }
    }
}
