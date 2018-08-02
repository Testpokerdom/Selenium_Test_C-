using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ConsoleApplication1
{
    public class EAPageObject
    {

        public EAPageObject(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using ="//div[@id='sb_ifc0']//input[@name='q']")]
        public IWebElement searchField { get; set; }
        [FindsBy(How = How.XPath, Using ="//div[@class='sbsb_g']/span[1]//input[@class='lsb']")]
        public IWebElement searchButton { get; set; }
        [FindsBy(How = How.XPath, Using ="//a[contains(.,'How To Export Tests from Selenium IDE - Elemental Selenium')]")]
        public IWebElement searchResult { get; set; }

        public void FillSearchField(string text)
        {
            searchField.Clear();
            searchField.SendKeys(text);
        }

        public void CklickButtonSearchInDropDownList()
        {
            searchButton.Click();
        }

        public string RecieveText()
        {
            string recText = searchResult.Text;
            return recText;
        }
    }
}