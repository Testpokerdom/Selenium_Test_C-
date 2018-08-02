using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace ConsoleApplication1
{
    public class Helpers
    {
        public void SendTextToWebElement( IWebElement element, string text)
        {
            element.Clear();
            element.SendKeys(text);
        }

        public void WaitWebelement(IWebDriver driver, long seconds, IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void ClickButton(IWebElement element)
        {
            element.Click();
        }

        public String RecievText(IWebElement element)
        {
            String webelementText = element.Text;
            return webelementText;
        }

    }
}