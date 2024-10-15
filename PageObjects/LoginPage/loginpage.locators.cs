using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjects.LoginPage
{
    public partial class loginpage
    {
        protected By UsernameFiled = By.CssSelector("#user-name");
        protected By PasswordField = By.CssSelector("#password");
        protected By LoginButton = By.CssSelector(".btn_action");

    }
}
