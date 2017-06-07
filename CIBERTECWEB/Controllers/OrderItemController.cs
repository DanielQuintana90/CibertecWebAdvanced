using CIBERTECWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIBERTECWEB.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly NorthwindDbContext _dbContext;

        public OrderItemController(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.OrderItems);
        }
    }
}