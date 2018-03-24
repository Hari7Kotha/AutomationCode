using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Threading;

namespace Keys.Pages
{
    class TenantOnboarding
    {
        //Tenant Onboarding added by Buniya
        internal void tenantonboard()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "TenantOnboard");
                //Read data from the excel sheet
                //Date of Birth
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"), ExcelLib.ReadData(2, "Date of Birth"));
                Thread.Sleep(1000);
                //Home Phone Number
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"), ExcelLib.ReadData(2, "HomePhoneNumber"));
                Thread.Sleep(3000);
                //Mobile Phone Number
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "MobilePhoneNumber"));
                Thread.Sleep(3000);
                //Current Address
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(2, "Current Address"));
                //Keys need to move up and down to select from the google search address
                Thread.Sleep(3000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Return).Perform();
                Thread.Sleep(1000);

                //Scrolling Down
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                Thread.Sleep(2000);
                IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(8, "Value")));

                (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                Thread.Sleep(2000);
                //Click on choose files
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                Thread.Sleep(2000);
                //Upload Photo
                //AutoItX3 autoIT1 = new AutoItX3();
                //autoIT1.WinActivate("Open");
                //autoIT1.Send(ExcelLib.ReadData(2, "UploadPhoto"));
                //autoIT1.Send("{ENTER}");
                Thread.Sleep(3000);
                //Click on Save Button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
                Thread.Sleep(2000);
                //Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Tenant Onboarding completed successfully");
            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error" + e.Message);
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Tenant Onboarding Failed");
            }





        }
    }
}
