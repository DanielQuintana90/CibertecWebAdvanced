using Cibertec.Models;
using Cibertec.Repositories.Interfaces;

namespace Cibertec.UnitOfWork.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Customer> Customers { get; }
        IRepository<Order> Orders { get; }
        IRepository<OrderItem> OrderItems { get; }
        IRepository<Product> Products { get; }
        IRepository<Supplier> Suppliers { get; }
    }
}
