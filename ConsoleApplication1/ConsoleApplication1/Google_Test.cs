using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace ConsoleApplication1
{
    public class Google_Test
    {
        private static IWebDriver driver = new FirefoxDriver();
        private Helpers help;
        private EAPageObject searchPageGoogle;

        public void Main(string[] args)
        {
        }

        [SetUp]
        public void Initialize()
        {
            help = new Helpers();
            searchPageGoogle = new EAPageObject(driver);
            driver.Navigate().GoToUrl("https://www.google.com");
        }
                
        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }

        [Test]
        public void GoogleSearchTest_1()
        {
            searchPageGoogle.FillSearchField("Selenium IDE export to C#");
            help.WaitWebelement(driver, 1, searchPageGoogle.searchButton);
            searchPageGoogle.CklickButtonSearchInDropDownList();
            
            Assert.That(searchPageGoogle.RecieveText(), Is.StringContaining("Selenium IDE"));
            
            /*
            searchPageGoogle.searchField.Clear();
            searchPageGoogle.searchField.SendKeys("Selenium IDE export to C#");
            help.WaitWebelement(driver, 2, searchPageGoogle.searchButton);
            searchPageGoogle.searchButton.Click();
            Assert.That(searchPageGoogle.searchResult.Text, Is.StringContaining("Selenium IDE"));
             */
            /*
            help.SendTextToWebElement(searchPageGoogle.searchField, "Selenium IDE export to C#");
            help.WaitWebelement(driver, 1, searchPageGoogle.searchButton);
            help.ClickButton(searchPageGoogle.searchButton);
            
            Assert.That(help.RecievText(searchPageGoogle.searchResult), Is.StringContaining("Selenium IDE"));
             */
        }

    }
}