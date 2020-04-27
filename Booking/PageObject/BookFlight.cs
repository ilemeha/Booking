using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Booking.PageObject
{
    public class BookFlight
    {
        private IWebDriver _driver;
        public BookFlight(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement RoundTriprdb => _driver.FindElement(By.XPath("(//div[@class='custom-control']//input[@id='roundTrip'])"));
        private IWebElement CityFrom => _driver.FindElement(By.XPath("//input[@id='from0']"));
        private IWebElement CityTo => _driver.FindElement(By.XPath("//input[@id='to0']"));

        public void ChooseRoundTrip()
        {
            RoundTriprdb.Click();
        }

        public void TypeCityFrom(string cityFrom)
        {
            CityFrom.SendKeys(cityFrom);

            CityFrom.SendKeys(Keys.Enter);
        }
        public void TypeCityTo(string cityTo)
        {
            CityTo.SendKeys(cityTo);

            CityFrom.SendKeys(Keys.Enter);
        }
    }
}
