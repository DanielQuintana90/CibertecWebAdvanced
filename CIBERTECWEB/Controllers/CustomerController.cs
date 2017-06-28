using Cibertec.Models;
using Cibertec.UnitOfWork;
using Cibertec.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Cibertec.Web.Controllers
{
    [ExceptionLoggerFilter]
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            _unit.Customers.Insert(customer);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_unit.Customers.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            _unit.Customers.Update(customer);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(_unit.Customers.GetById(id));
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteCustomer(int id)
        {
            var customer = _unit.Customers.GetById(id);

            _unit.Customers.Delete(customer);

            return RedirectToAction("Index");
        }

        public IActionResult Detail(string firstName, string lastName)
        {
            var customers = _unit.Customers.SearchByNames(firstName, lastName);

            return View(customers);
        }
    }
}