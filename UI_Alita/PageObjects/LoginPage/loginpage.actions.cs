using OpenQA.Selenium;

public class LoginPageActions
{
    private IWebDriver driver;
    private SeleniumHelpers seleniumHelpers;

    public LoginPageActions(IWebDriver driver)
    {
        this.driver = driver;
        seleniumHelpers = new SeleniumHelpers(driver);
    }

    public void EnterUsername(string username)
    {
        seleniumHelpers.SendKeys(LoginPageLocators.UsernameField, username);
    }

    public void EnterPassword(string password)
    {
        seleniumHelpers.SendKeys(LoginPageLocators.PasswordField, password);
    }

    public void ClickLoginButton()
    {
        seleniumHelpers.Click(LoginPageLocators.LoginButton);
    }

    public bool IsLoginSuccessful()
    {
        // This method would typically check for elements that are only visible upon successful login
        return seleniumHelpers.IsElementPresent(By.Id("product-page-element"));
    }
}