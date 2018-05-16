using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Threading;

namespace Keys.Test
{
    internal class PO
    {
        public PO()
        {
            PageFactory.InitElements(Global.Driver.driver, this);
        }

        #region WebElements Definition
        //Define Owners tab
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]")]
        private IWebElement Ownertab { set; get; }

        //Define Properties page
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/div[1]/div/a[1]")]
        private IWebElement PropertiesPage { set; get; }

        //Define search bar        
        [FindsBy(How = How.XPath, Using = "//*[@id='search-wrap']/form/div/input")]
        private IWebElement SearchBar { set; get; }

        //Define search button        
        [FindsBy(How = How.XPath, Using = "//*[@id='icon-submitt']")]
        private IWebElement SearchButton { set; get; }

        //Skip button
        [FindsBy(How = How.XPath, Using = "/html/body/div[5]/div/div[5]/a[1]")]
        private IWebElement Skip { set; get; }

        #endregion

        public void Common_methods()
        {
            Global.Driver.wait(5);
            //Click on the Owners tab
            Ownertab.Click();

            //Select properties page
            PropertiesPage.Click();
        }



        internal void SearchProp()
        {
            try
            {
            Thread.Sleep(1500);
            //Click on Skip button
            Skip.Click();
            Thread.Sleep(1500);

            //Calling the common methods
            Common_methods();
            Thread.Sleep(1000);
            Driver.wait(5);

            //Enter the value in the search bar
            SearchBar.SendKeys("TestingProperty");
            Global.Driver.wait(5);

            //Click on the search button
            SearchButton.Click();
            Driver.wait(5);

            string ExpectedValue = "TestingProperty";
            string ActualValue = Global.Driver.driver.FindElement(By.XPath("//*[@id='main-content']/section/div[1]/div/div[3]/div/div[1]/div[2]/div[1]/div[1]/a/h3")).Text;

            //Assert.AreEqual(ExpectedValue, ActualValue);
              if (ExpectedValue == ActualValue)

                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Test Passed, Search successfull");

                else
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull");

            }

            catch (Exception e)
            {

                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test Failed, Search Unsuccessfull", e.Message);
            }

        }
    }
}