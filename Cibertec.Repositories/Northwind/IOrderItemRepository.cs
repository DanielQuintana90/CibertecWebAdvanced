using Cibertec.Models;

namespace Cibertec.Repositories.Northwind
{
    public interface IOrderItemRepository : IRepository<OrderItem>
    {
        OrderItem GetByUnitPrice(decimal unitPrice);
    }
}
