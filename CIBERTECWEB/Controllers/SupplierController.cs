using CIBERTECWEB.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIBERTECWEB.Controllers
{
    public class SupplierController : Controller
    {
        private readonly NorthwindDbContext _dbContext;

        public SupplierController(NorthwindDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(_dbContext.Suppliers);
        }
    }
}