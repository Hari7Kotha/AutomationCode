//using AutoItX3Lib;
using Keys.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class Owners_Job_quotes
    {
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
        //Add new job in marketplace (Preethi)
        internal void Addnewjob()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Add New Job");

                //navigating to Owners
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(1000);

                //navigating to job quotes
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(1000);

                //Click on add new job
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
                Thread.Sleep(1000);

                //checking if the user is navigated to Add new job page
                try
                {
                    string expectedpageheading = "Add Job Form";
                    Assert.AreEqual(expectedpageheading, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value")));
                    Base.test.Log(LogStatus.Info, "Expected page heading: '" + expectedpageheading + " ' is displayed");
                    Base.test.Log(LogStatus.Pass, "User is navigated to Add new job page");
                    
                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "User is not navigated to Add new job page");
                    Base.test.Log(LogStatus.Info, e.Message + "No page heading found for add new job page");
                }

                //selecting property
                IList<IWebElement> propertyadd = Driver.driver.FindElements(By.XPath("//*[@id='NewJobForm']/div[3]/form/fieldset/div[1]/div/div/select/option"));
                int addcount = propertyadd.Count();
                for (int i = 0; i < addcount; i++)
                {
                    if (propertyadd[i].Text == ExcelLib.ReadData(RowCountBase, "Property Address"))
                    {
                        propertyadd[i].Click();
                        Base.test.Log(LogStatus.Pass, "Property selected");

                    }
                }

                //Enter title
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"), ExcelLib.ReadData(RowCountBase, "Title"));
                Thread.Sleep(1000);

                //Enter job description
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(RowCountBase, "Job Desc"));
                Thread.Sleep(1000);

                //Max budget
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "Max Budget"));
                Thread.Sleep(1000);

                //scroll down to view element
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(10, "Value")));
                (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                //upload files

                try
                {
                    //click on choosefiles
                    
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
                    Thread.Sleep(5000);

                    // File upload begins here

                    //AutoItX3 autoIt = new AutoItX3();
                    //autoIt.WinActivate("Open");
                    
                    //autoIt.Send(ExcelLib.ReadData(RowCountBase, "Documents path"));
                    //Thread.Sleep(3000);
                    //autoIt.Send("{ENTER}");
                    Thread.Sleep(3000);

                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

                }

                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed " + e.Message);
                    
                }

                //scroll down to view element
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver.driver;
                IWebElement element1 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value")));
                (js1).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                //click on submit button
                IWebElement submit = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value")));
                if (submit.Enabled)
                {
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));
                    Thread.Sleep(1000);
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "All mandatory fields entered, Clicked on submit button to add a job in marketplace");
                                      
                }

                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Submit button is disabled. Invalid data entered");
                }

                //validating if job is added to marketplace

                //navigating to marketplace
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

                //checking if the user is navigated to marketplace
                try
                {
                    string marketplaceheading = "Available Jobs";
                    Assert.AreEqual(marketplaceheading, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value")));
                    Base.test.Log(LogStatus.Info, "Expected page heading: '" + marketplaceheading + " ' is displayed");
                    Base.test.Log(LogStatus.Pass, "User is navigated to marketplace");

                    //searching for added job
                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "Title"));
                    Thread.Sleep(1000);

                    //search button
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
                    Thread.Sleep(1000);

                    //getting the search results in a list
                    IList joblist = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(16, "Value")));
                    int joblistcount = joblist.Count;

                    for(int i=1; i<=joblistcount; i++)
                    {
                        string expectedname = ExcelLib.ReadData(RowCountBase, "Title");
                        string expecteddesc = ExcelLib.ReadData(RowCountBase, "Job Desc");
                        if(expectedname == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value") + i+ ExcelLib.ReadData(17, "Value2")) && expecteddesc == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value") + i + ExcelLib.ReadData(18, "Value2")))
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job is successfully added to marketplace");
                        }
                        else
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job is not added to marketplace");
                        }
                        

                    }

                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Fail, "User is not navigated to marketplace");
                    Base.test.Log(LogStatus.Info, e.Message + "No page heading found for marketplace");
                }

                

            }
            catch (Exception e1)
            {
                Base.test.Log(LogStatus.Fail, "issue occured" + e1.Message);
            }

        }
    }
}