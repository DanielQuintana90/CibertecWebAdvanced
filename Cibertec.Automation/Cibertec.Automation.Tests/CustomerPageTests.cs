using FluentAssertions;
using Xunit;

namespace Cibertec.Automation.Tests
{
    public class CustomerPageTests
    {
        private readonly CustomerPage _customerPage;

        public CustomerPageTests()
        {
            Driver.GetInstance();
            _customerPage = new CustomerPage();
        }

        [Fact]
        public void Customer_List_Automation()
        {
            _customerPage.GoToUrl();
            _customerPage.GoToIndex();
            _customerPage.GetListCount().Should().BeGreaterThan(90);

            Driver.CloseInstance();
        }

        [Fact]
        public void Customer_Create_Automation()
        {
            _customerPage.GoToUrl();
            _customerPage.GoToIndex();
            _customerPage.GoToCreate();
            _customerPage.LoadDataToCustomer();
            _customerPage.CreateCustomer();
            _customerPage.GetListCount().Should().BeGreaterThan(92);

            Driver.CloseInstance();
        }

    }
}
