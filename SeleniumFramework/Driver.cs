using OpenQA.Selenium;

namespace SeleniumFramework
{
    public class Driver
    {
        public IWebDriver driver { get; set; }

        public void WaitForElementUpTo(int seconds = 5)
        {
        }
    }
}