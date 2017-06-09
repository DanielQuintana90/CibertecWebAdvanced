using Cibertec.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cibertec.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unit;

        public ProductController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Products.GetAll());
        }
    }
}