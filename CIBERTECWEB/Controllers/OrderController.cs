using CIBERTECWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIBERTECWEB.Controllers
{
    public class OrderController : Controller
    {
        private readonly NorthwindDbContext _dbContext;

        public OrderController(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Orders);
        }
    }
}