//using AutoItX3Lib;
using Keys.Global;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class MarketPlace
    {
        internal void Apply_Quote_Job()
        {
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Marketplace-Apply for quotes");

            try
            {
                //navigate to market place
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(2000);
                //search for job
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"), ExcelLib.ReadData(2, "searchstring"));
                Thread.Sleep(1000);
                //Search button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
                Thread.Sleep(1000);

                IList joblist = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(16, "Value")));
                int joblistcount = joblist.Count;


                for (int i = 1; i <= joblistcount; i++)
                {
                    if (ExcelLib.ReadData(2, "searchstring") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value") + i + ExcelLib.ReadData(18, "Value2")))
                    {
                        //click on apply
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value") + i + ExcelLib.ReadData(17, "Value2"));
                        Thread.Sleep(1000);

                        ////get max budget
                        //string MaxBudget = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));

                        //entering amount
                        Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(2, "amount"));

                        Thread.Sleep(1000);

                        //entering note
                        Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "Note"));

                        //scroll down to view element
                        IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                        IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(15, "Value")));
                        (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                        //uploading pictures
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
                        Thread.Sleep(2000);
                        try
                        {
                            // File upload begins here

                            //AutoItX3 autoIt = new AutoItX3();
                            //autoIt.WinActivate("Open");
                            //Thread.Sleep(1000);
                            ////  autoIt.Send(@"E:\KEYS\property1.jpg");
                            //autoIt.Send(ExcelLib.ReadData(2, "Upload Doc"));
                            //Thread.Sleep(3000);
                            //autoIt.Send("{Enter 3}");
                            Thread.Sleep(1000);
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected doc to upload");

                        }

                        catch (Exception e)
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

                            Console.WriteLine("Error" + e.ToString());
                        }
                        Thread.Sleep(1000);
                        //click on submit button
                        IWebElement submit = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(10, "Value")));
                        
                            if (submit.Enabled)
                            {
                                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
                                Thread.Sleep(1000);
                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Clicked on submit button to apply for a job");

                            Thread.Sleep(1000);
                            //Navigating to My quotes
                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"));


                            }
                                                
                        else 
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Submit button is disabled. Please check your data");
                        }
                    }
                    
                }
                #region old code
                //        //get max budget
                //        //string MaxBudget = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
                //        Thread.Sleep(5000);
                //        //IJavaScriptExecutor js2 = (IJavaScriptExecutor)Driver.driver;
                //        //Thread.Sleep(3000);
                //        //IWebElement element2 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(7, "Value")));
                //        //Thread.Sleep(3000);
                //        //(js2).ExecuteScript("arguments[0].scrollIntoView(true);", element2);
                //        //Apply for the job
                //        //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
                //        //Thread.Sleep(2000);
                //        Thread.Sleep(5000);
                //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                //        Thread.Sleep(5000);
                //        //quote amount
                //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), MaxBudget);
                //        Thread.Sleep(5000);
                //        //note
                //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(9, "Value2"));
                //        Thread.Sleep(5000);
                //        //Upload Documents
                //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
                //        Thread.Sleep(2000);
                //        try
                //        {
                //            // File upload begins here

                //            AutoItX3 autoIt = new AutoItX3();
                //            autoIt.WinActivate("Open");
                //            Thread.Sleep(1000);
                //            //  autoIt.Send(@"E:\KEYS\property1.jpg");
                //            autoIt.Send(ExcelLib.ReadData(2, "Upload Doc"));
                //            Thread.Sleep(1000);
                //            autoIt.Send("{Enter 3}");
                //            Thread.Sleep(1000);
                //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected doc to upload");

                //        }

                //        catch (Exception e)
                //        {
                //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

                //            Console.WriteLine("Error" + e.ToString());
                //        }

                //        //Submit
                //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
                //        Thread.Sleep(5000);


                //        //Test case to check whether service supplier is able to view the quotes under My quotes
                //        //Scroll down to find Service Supplier-My quotes
                //        IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                //        Thread.Sleep(3000);
                //        IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value")));
                //        Thread.Sleep(3000);
                //        (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                //        //Click on my quotes
                //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));

                //        //search descriptions for quote 
                //        IList compList1 = Driver.driver.FindElements(By.XPath("//*[@id='propTable']/tbody[2]/tr"));
                //        Thread.Sleep(2000);
                //        int compListCount1 = compList1.Count;
                //        for (int i = 1; i <= compListCount1; i++)
                //        {
                //            if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value") + i + ExcelLib.ReadData(12, "Value2")) == ExcelLib.ReadData(2, "searchstring"))
                //            {
                //                Thread.Sleep(5000);
                //                //Open the details and screen shot
                //                // scroll down to locate the element
                //                IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver.driver;
                //                Thread.Sleep(3000);
                //                IWebElement element1 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(13, "Value") + i + ExcelLib.ReadData(13, "Value2")));
                //                Thread.Sleep(3000);
                //                (js1).ExecuteScript("arguments[0].scrollIntoView(true);", element1);
                //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value") + i + ExcelLib.ReadData(13, "Value2"));
                //                //Details
                //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value") + i + ExcelLib.ReadData(14, "Value2"));
                //                //Take screen shot
                //                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Quote Details");
                //                //Test pass
                //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Quote added to Service Supplier My Quotes.");
                //                break;
                //            }
                //            else if (i == compListCount1 && Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value") + i + ExcelLib.ReadData(12, "Value2")) != ExcelLib.ReadData(2, "Value2"))
                //            {
                //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job quote not found in Service Supplier My Quotes list.");
                //            }
                //        }
                //    }
                //    catch (Exception e)
                //    {
                //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Fail");
                //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + ">> Could not complete test");
                //    }


                //}
                #endregion
            }
            catch (Exception e)

            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message);
            }
        }
    }


}
