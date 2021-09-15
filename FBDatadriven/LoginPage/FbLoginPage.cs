/*
 * Project:Data Driven Framework
 * Author:Sona G
 * Date :12/09/2021
 */
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace FBDatadriven.LoginPage
{
    public class FbLoginPage 
    {
        public FbLoginPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        public IWebElement email;

        [FindsBy(How = How.Name, Using = "pass")]
        [CacheLookup]
        public IWebElement password;

        [FindsBy(How = How.Name, Using = "login")]
        [CacheLookup]
        public IWebElement loginbtn;
    }

}

