using Cibertec.Models;
using Cibertec.Repositories;
using Cibertec.Repositories.Northwind;
using Cibertec.Repositories.Northwind.Dapper;

namespace Cibertec.UnitOfWork
{
    public class CibertecUnitOfWork : IUnitOfWork
    {
        public CibertecUnitOfWork(string connectionString)
        {
            Customers = new CustomerRepository(connectionString);
            Orders = new RepositoryDapper<Order>(connectionString);
            OrderItems = new RepositoryDapper<OrderItem>(connectionString);
            Products = new RepositoryDapper<Product>(connectionString);
            Suppliers = new RepositoryDapper<Supplier>(connectionString);
        }

        public ICustomerRepository Customers { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<OrderItem> OrderItems { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Supplier> Suppliers { get; private set; }
    }
}
