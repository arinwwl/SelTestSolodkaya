using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SelTsetSolodkaya
{
    public class Tests
    {
        [TestCase]
        public void booking_page_title()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.booking.com/";
            string expectedTitle = "Booking.com: Отели, апартаменты и другие варианты размещения";
            Assert.AreEqual(expectedTitle, webDriver.Title);
        }

        [TestCase]
        public void booking_objects_visibility()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.booking.com/";
            bool isVisible = webDriver.FindElement(By.Id("nav-menu-container")).Displayed;
            Assert.IsTrue(isVisible);
        }

        [TestCase]
        public void booking_link_navigation()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.booking.com/";
            webDriver.FindElement(By.Id("b_c_nav")).Click();
            string currentUrl = webDriver.Url;
            Assert.AreEqual("https://account.booking.com/signin", currentUrl);
        }

        [TestCase]
        public void booking_text_field_fill()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.booking.com/";
            webDriver.FindElement(By.Id("ss")).SendKeys("Париж");
            string enteredText = webDriver.FindElement(By.Id("ss")).GetAttribute("value");
            Assert.AreEqual("Париж", enteredText);
        }

        [TestCase]
        public void booking_button_click()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Url = "https://www.booking.com/";
            webDriver.FindElement(By.Id("frm")).Submit();
            bool isLoaded = webDriver.FindElement(By.Id("searchboxcontainer")).Displayed;
            Assert.IsTrue(isLoaded);
        }


    }
}