using Cibertec.UnitOfWork;
using System.Linq;
using Xunit;

namespace Cibertec.Repositories.Tests
{
    public class CustomerRepositoryTests
    {
        private readonly IUnitOfWork _unit;

        public CustomerRepositoryTests()
        {
            _unit = new CibertecUnitOfWork(ConfigSettings.ConnectionString);
        }

        [Fact(DisplayName = "[CustomerRepositoryTests] Get_All_Customers")]
        public void Get_All_Customers()
        {
            var result = _unit.Customers.GetAll();
            Assert.NotNull(result);
            Assert.True(result.Count() > 0);
        }
    }
}
