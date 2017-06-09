using Cibertec.Models;
using Cibertec.Repositories;
using Cibertec.Repositories.Interfaces;
using Cibertec.UnitOfWork.Interfaces;

namespace Cibertec.UnitOfWork
{
    public class CibertecUnitOfWork : IUnitOfWork
    {
        public CibertecUnitOfWork(string connectionString)
        {
            Customers = new RepositoryDapper<Customer>(connectionString);
            Orders = new RepositoryDapper<Order>(connectionString);
            OrderItems = new RepositoryDapper<OrderItem>(connectionString);
            Products = new RepositoryDapper<Product>(connectionString);
            Suppliers = new RepositoryDapper<Supplier>(connectionString);
        }

        public IRepository<Customer> Customers { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<OrderItem> OrderItems { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Supplier> Suppliers { get; private set; }
    }
}
