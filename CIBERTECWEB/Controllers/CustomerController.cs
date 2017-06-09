using Cibertec.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cibertec.Web.Controllers
{
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unit;

        public CustomerController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.Customers.GetAll());
        }
    }
}