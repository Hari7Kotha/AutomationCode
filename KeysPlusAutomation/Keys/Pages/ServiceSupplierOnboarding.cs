
using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class ServiceSupplierOnboarding
    {
        internal void ServiceProviderEnterAllDetails() //[TONY] Service Provider Entering all the validate data
        {
            try
            {
                
                ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceSupplier-Onboarding");
                //Sign In
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"), ExcelLib.ReadData(2, "Username"));
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"), ExcelLib.ReadData(2, "Pw"));
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));

                //**entering valid data in Service Supplier details**

                //Business Name
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(2, "BusinessName"));

                Thread.Sleep(1000);

                //Phone Number
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(2, "Phonenumber"));

                Thread.Sleep(1000);

                //website
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"), ExcelLib.ReadData(2, "website"));

                Thread.Sleep(1000);
                try
                {
                    //upload images
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));

                    Thread.Sleep(1000);

                    //AutoIt
                    //AutoItX3 autoIt = new AutoItX3();
                    //autoIt.WinActivate("File Upload");
                    //Thread.Sleep(2000);
                    //autoIt.Send(ExcelLib.ReadData(2, "uploadphoto"));
                    //Thread.Sleep(3000);
                    //autoIt.Send("{ENTER}");
                    Thread.Sleep(2000);
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Image uploaded Sucessfully");
                }
                
                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed " + e.Message);

                }

                Thread.Sleep(1000);

                //Scrolling Down
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(9, "Value")));
                (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                Thread.Sleep(1000);

                //Next Button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
                Thread.Sleep(1000);

                //**Entering valid data Physical Address**

                //Search address
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(2, "Physical Address"));
                Thread.Sleep(5000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Return).Perform();
                Thread.Sleep(2000);
                ////Number
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(3, "Phonenumber"));

                ////Street
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(3, "Address"));

                ////suburb
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"), ExcelLib.ReadData(2, "Suburb"));

                ////city
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(2, "city"));

                ////Postcode
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(2, "postcode"));


                //**Billing Address**

                //Search address
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"), ExcelLib.ReadData(2, "Billing Address"));
                Thread.Sleep(5000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Return).Perform();
                Thread.Sleep(2000);
                ////Number
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(3, "Phonenumber"));

                ////Street
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(3, "Address"));

                ////suburb
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(2, "Suburb"));

                ////city
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(2, "city"));

                ////Postcode
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(2, "postcode"));

                //Save Button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"));

                Thread.Sleep(5000);

                
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Service Supplier Onboarding completed successfully");
            }
            catch (Exception e)
            {
               // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Fail");
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Service Supplier Onboarding failed" + e.Message);
            }
        }
    }
}
