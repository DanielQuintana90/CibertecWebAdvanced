using Cibertec.Models;
using Cibertec.UnitOfWork;
using System.Linq;
using Xunit;
using FluentAssertions;

namespace Cibertec.Repositories.Tests
{
    public class CustomerRepositoryTests
    {
        private readonly IUnitOfWork _unit;

        public CustomerRepositoryTests()
        {
            _unit = MockedUnitOfWork.GetUnitOfWork();
        }

        [Fact(DisplayName = "[CustomerRepositoryTests] Get_All_Customers")]
        public void Get_All_Customers()
        {
            var result = _unit.Customers.GetAll();
            result.Should().NotBeNull();
            result.Count().Should().BeGreaterThan(0);
        }

        [Fact(DisplayName = "[CustomerRepositoryTests] Get_By_Id_Customer")]
        public void Get_By_Id()
        {
            var result = _unit.Customers.GetById(1);
            Assert.NotNull(result);            
        }

        [Fact(DisplayName = "[CustomerRepositoryTests] Insert_Customer")]
        public void Insert_Customer()
        {
            var result = _unit.Customers.Insert(null);
            result.Should().BeGreaterThan(0);
        }


        [Fact(DisplayName = "[CustomerRepositoryTests] Insert_Customer_Fail")]
        public void Insert_Customer_Wrong()
        {
            var result = _unit.Customers.Insert(new Customer());
            result.Should().Be(0);
        }

        [Fact(DisplayName = "[CustomerRepositoryTests] Update_Customer")]
        public void Update_Customer()
        {
            var result = _unit.Customers.Update(null);

            Assert.NotNull(result);
            Assert.True(result);
        }

        [Fact(DisplayName = "[CustomerRepositoryTests] Delete_Customer")]
        public void Delete_Customer()
        {
            var result = _unit.Customers.Delete(null);

            Assert.NotNull(result);
            Assert.True(result);
        }
    }
}
