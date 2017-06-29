using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace Cibertec.Automation
{
    public class CustomerPage
    {
        //const string url = "http://localhost/CibertecWebMVC";

        const string url = "http://localhost:12813/";        

        private readonly IWebDriver _driver;

        #region Customer Page Elements
        [FindsBy(How = How.CssSelector, Using = "a[href*='/Customer']")]
        private IWebElement customerLink = null;

        [FindsBy(How = How.CssSelector, Using = "table.table>tbody>tr")]
        private IList<IWebElement> customerList= null;

        [FindsBy(How = How.CssSelector, Using = "a[href*='/Create']")]
        private IWebElement customerCreateLink = null;

        [FindsBy(How = How.CssSelector, Using = "#Id")]
        private IWebElement customerIdText = null;

        [FindsBy(How = How.CssSelector, Using = "#FirstName")]
        private IWebElement customerFirstNameText = null;

        [FindsBy(How = How.CssSelector, Using = "#LastName")]
        private IWebElement customerLastNameText = null;

        [FindsBy(How = How.CssSelector, Using = "#City")]
        private IWebElement customerCityText = null;

        [FindsBy(How = How.CssSelector, Using = "#Country")]
        private IWebElement customerCountryText = null;

        [FindsBy(How = How.CssSelector, Using = "#Phone")]
        private IWebElement customerPhoneText = null;

        [FindsBy(How = How.CssSelector, Using = ".btn.btn-default")]
        private IWebElement customerCreateButton = null;

        #endregion

        public CustomerPage()
        {
            _driver = Driver.Instance;
            PageFactory.InitElements(_driver, this);
        }

        public void GoToUrl()
        {
            Driver.Instance.Navigate().GoToUrl(url);
        }

        public void GoToIndex()
        {
            customerLink.Click();
        }

        public int GetListCount()
        {
            return customerList.Count;
        }

        public void GoToCreate()
        {
            customerCreateLink.Click();
        }

        public void LoadDataToCustomer()
        {
            customerIdText.SendKeys("1");
            customerFirstNameText.SendKeys("Darinka");
            customerLastNameText.SendKeys("Alcocer");
            customerCityText.SendKeys("Lima");
            customerCountryText.SendKeys("Perú");
            customerPhoneText.SendKeys("321654-32");            
        }

        public void CreateCustomer()
        {
            customerCreateButton.Click();
        }

    }
}
