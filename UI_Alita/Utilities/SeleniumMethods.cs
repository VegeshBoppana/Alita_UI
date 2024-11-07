// Selenium Methods for Automation Framework

public class SeleniumMethods
{
    public void SendKeys(IWebElement element, string value)
    {
        element.SendKeys(value);
    }

    public void Click(IWebElement element)
    {
        element.Click();
    }

    public string GetText(IWebElement element)
    {
        return element.Text;
    }

    // Add more methods as required for the framework
}