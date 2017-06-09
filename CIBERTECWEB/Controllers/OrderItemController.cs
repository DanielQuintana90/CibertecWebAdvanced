using Cibertec.UnitOfWork.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cibertec.Web.Controllers
{
    public class OrderItemController : Controller
    {
        private readonly IUnitOfWork _unit;

        public OrderItemController(IUnitOfWork unit)
        {
            _unit = unit;
        }

        public IActionResult Index()
        {
            return View(_unit.OrderItems.GetAll());
        }
    }
}