using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keys.Pages
{
    public class Register
    {
        internal Register()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        //Click on Register Link
        [FindsBy(How = How.XPath, Using = "html/body/div/div/div/div[2]/div/div[1]/section/form/div[4]/div/a[2]")]
        private IWebElement RegisterLink { get; set; }
        //click on Email
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div/div[2]/form/div[2]/div/input")]
        private IWebElement Email { get; set; }
        //click on Password
        [FindsBy(How = How.XPath, Using = "html/body/div/div/div/div[2]/form/div[3]/div/input")]
        private IWebElement Password { get; set; }
        //click on ConfirmPassword
        [FindsBy(How = How.XPath, Using = "html/body/div/div/div/div[2]/form/div[4]/div/input")]
        private IWebElement ConfirmPassword { get; set; }
        //Click on Regitser Button
        [FindsBy(How = How.XPath, Using = "html/body/div/div/div/div[2]/form/div[5]/div/a")]
        private IWebElement Registerbutton { get; set; }

        public void Navigateregister()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Register");
            // Navigating to Login page using value from Excel
            Driver.driver.Navigate().GoToUrl(ExcelLib.ReadData(2, "url"));
        }
        public void Commonsteps()
        {
            // RegisterLink.Click();
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
        }

        internal void register()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Register");
            //Commonsteps();

            Driver.wait(2);

            // Email.SendKeys(ExcelLib.ReadData(2, "Email"));
            //Password.SendKeys(ExcelLib.ReadData(2, "Password"));
            //ConfirmPassword.SendKeys(ExcelLib.ReadData(2, "ConfirmPassword"));

            //First Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"), ExcelLib.ReadData(2, "FirstName"));
            Driver.wait(2);
            //Last Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "LastName"));
            Driver.wait(2);
            //Email
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(2, "Email"));
            Driver.wait(2);
            //Password
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(2, "Password"));
            Driver.wait(2);

            //role
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));

            IWebElement role = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value")));
            new SelectElement(role).SelectByText(ExcelLib.ReadData(2, "Role"));

            //terms of usage
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));

            //Resgiter button
            // Registerbutton.Click();
            //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
        }

    }
}
