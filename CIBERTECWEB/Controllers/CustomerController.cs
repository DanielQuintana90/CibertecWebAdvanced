using CIBERTECWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIBERTECWEB.Controllers
{
    public class CustomerController : Controller
    {
        private readonly NorthwindDbContext _dbContext;

        public CustomerController(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {  
            return View(_dbContext.Customers);
        }
    }
}