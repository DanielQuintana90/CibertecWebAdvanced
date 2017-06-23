using Cibertec.MockData;
using Cibertec.Models;
using Cibertec.UnitOfWork;
using Cibertec.Web.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Cibertec.Web.Tests
{
    public class CustomerControllerTests : Controller
    {
        private readonly CustomerController _controller;

        public CustomerControllerTests()
        {
            _controller = new CustomerController(MockedUnitOfWork.GetUnitOfWork());
        }

        [Fact(DisplayName = "[CustomerController] Listar_Customer")]
        public void Listar_Test()
        {
            var result = _controller.Index() as ViewResult;
            result.Should().NotBeNull();
            var model = result.Model as List<Customer>;
            model.Count().Should().Be(2);
            model[0].Id.Should().Be(1);
        }    
        
        [Fact(DisplayName = "[CustomerController] Detail_Customer")]
        public void Detail_Test()
        {
            var result = _controller.Detail() as ViewResult;
            result.Should().NotBeNull();
        }
    }
}
