using CIBERTECWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIBERTECWEB.Controllers
{
    public class ProductController : Controller
    {
        private readonly NorthwindDbContext _dbContext;

        public ProductController(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Products);
        }
    }
}