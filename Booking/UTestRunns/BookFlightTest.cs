using Booking.Configuartion;
using Booking.PageObject;
using Booking.WebDriver;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Booking.UTestRunns
{
    [TestFixture]
    public class BookFlightTest
    {
        [Test]
        public void Booking()
        {
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                driver.Navigate().GoToUrl("https://www.onetravel.com/");

                var bookF = new BookFlight(driver);
                bookF.ChooseRoundTrip();
                bookF.TypeCityFrom("CHI");
                Thread.Sleep(2000);
                bookF.TypeCityTo("LON");
                Thread.Sleep(2000);
            }
        }
    }
}
