using Keys.Global;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    class PropertyOwner_Onboarding
    {

        internal void Property_OwnerOnboard_addtenant()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "PropertyOwner-Onboard");
                Thread.Sleep(2000);
                //Read the data from excel sheet for filling in property owner onboarding front page
                
                //Property name
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"), ExcelLib.ReadData(2, "PropertyName"));
                Thread.Sleep(2000);
                
                // Search address
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"), ExcelLib.ReadData(2, "SearchAddress"));
                //var addresssel = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(3, "Value")));
                //var add = new SelectElement(addresssel);
                //add.SelectByText(ExcelLib.ReadData(2, "SearchAddress"));
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Return).Perform();
                Thread.Sleep(2000);
                
                //Description
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "Description"));
                Thread.Sleep(2000);

                //Select Property type from dropdownn
                IList<IWebElement> proptypelists = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[1]/div[2]/select/option"));

                int ListsCount = proptypelists.Count();

                for (int i = 0; i < ListsCount; i++)
                {
                    if (proptypelists[i].Text == ExcelLib.ReadData(2, "Property Type"))
                    {
                        proptypelists[i].Click();
                    }
                }

                Thread.Sleep(1000);

                // Scrolling Down
                 IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                IWebElement element = Driver.driver.FindElement(By.XPath("//*[@id='property-details']/div[3]/div[2]/select/option"));
                (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);

                Thread.Sleep(2000);

                //Select rent type
                IList<IWebElement> renttypelists = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[3]/div[2]/select/option"));

                int rentCount = renttypelists.Count();

                for (int j = 0; j < rentCount; j++)
                {
                    if (renttypelists[j].Text == ExcelLib.ReadData(2, "Rent Type"))
                    {
                        renttypelists[j].Click();
                    }
                }

                //Target rent
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(2, "Target Rent"));

                //Year built
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"), ExcelLib.ReadData(2, "Year Built"));
                
                //Bedrooms
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(2, "Bedrooms"));
               
                //Bathrooms
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "Bathrooms"));
                
                //Carparks
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(2, "Carparks"));
                
                //Click on next button to navigate to financial details page
                Thread.Sleep(2000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));
                
                //Purchase price 
                Thread.Sleep(6000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"), ExcelLib.ReadData(2, "Purchase price"));
                
                //Mortgage
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(2, "Mortgage"));
                
                //Home value
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(2, "Home Value"));
                
                //Home Value type
                Thread.Sleep(2000);
                IList<IWebElement> homevaluelists = Driver.driver.FindElements(By.XPath("//*[@id='propertyFinancialSection']/table/tbody/tr[2]/td[2]/select/option"));

                int hometypeCount = homevaluelists.Count();

                for (int j = 0; j < rentCount; j++)
                {
                    if (homevaluelists[j].Text == ExcelLib.ReadData(2, "Home Value Type"))
                    {
                        homevaluelists[j].Click();
                    }
                }
                
                
                //Repayment Amount
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"), ExcelLib.ReadData(2, "RepayAmt"));
                
                //Frequency
                Thread.Sleep(1000);
                IList<IWebElement> freqlists = Driver.driver.FindElements(By.XPath("//*[@id='repaymentSection']/div/table/tbody/tr/td[2]/select/option"));

                int freqCount = freqlists.Count();

                for (int i = 0; i < freqCount; i++)
                {
                    if (freqlists[i].Text == ExcelLib.ReadData(2, "Frequency"))
                    {
                        freqlists[i].Click();
                    }
                }

                //Repayment Start Date
                Thread.Sleep(2000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(2, "Repay Start Date "));
                
                //Repayment end date
                Thread.Sleep(2000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(2, "Repay End Date"));
                
                ////Expenses Amount
                //Thread.Sleep(2000);
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(2, "Exp Amt"));
                
                ////Description
                //Thread.Sleep(2000);
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(2, "Exp Descp"));
               
                ////Date
                //Thread.Sleep(2000);
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"), ExcelLib.ReadData(2, "Date"));
                
                //Click on the next button to navigate on to the add tenant to property page
                Thread.Sleep(5000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));
                
                //Tenant Email
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(2, "TenantEmail"));

                //Main tenant
                IList<IWebElement> maintenant = Driver.driver.FindElements(By.XPath("//*[@id='tenant-area']/div[1]/div[2]/div/select/option"));

                int mainCount = maintenant.Count();

                for (int i = 0; i < mainCount; i++)
                {
                    if (maintenant[i].Text == "No")
                    {
                        maintenant[i].Click();
                    }
                }

                //First Name
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(51, "Locator"), ExcelLib.ReadData(51, "Value"), ExcelLib.ReadData(2, "FirstName"));

                //Last Name
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value"), ExcelLib.ReadData(2, "LastName"));

                //Start Date
                Thread.Sleep(2000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(2, "Start Date"));
                
                //End Date
                Thread.Sleep(3000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"), ExcelLib.ReadData(2, "End Date"));

                //Payment Frequency
                IList<IWebElement> payfreqlist = Driver.driver.FindElements(By.XPath("//*[@id='tenant-area']/div[4]/div[2]/div/select/option"));

                int payfreqCount = payfreqlist.Count();

                for (int i = 0; i < payfreqCount; i++)
                {
                    if (payfreqlist[i].Text == ExcelLib.ReadData(2, "Payment Freq"))
                    {
                        payfreqlist[i].Click();
                    }
                }

                //Rent Amount
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"), ExcelLib.ReadData(2, "Rent Amt"));

                //payment start date
                Thread.Sleep(3000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"), ExcelLib.ReadData(2, "Payment Start Date"));

                //payment due date
                Thread.Sleep(1000);
                IList<IWebElement> payduelist = Driver.driver.FindElements(By.XPath("//*[@id='tenant-area']/div[4]/div[2]/div/select/option"));

                int paydueCount = payduelist.Count();

                for (int i = 0; i < paydueCount; i++)
                {
                    if (payduelist[i].Text == ExcelLib.ReadData(2, "Payment Due Date"))
                    {
                        payduelist[i].Click();
                    }
                }
                

                //Click on Submit Button
                Thread.Sleep(2000);
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(31, "Locator"), ExcelLib.ReadData(31, "Value"));
                Thread.Sleep(4000);

                
                //Screenshot
                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Tenant and property");
                
                //Report
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property and tenant added sucessfully");

            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property onboarding failed " + e.Message);
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error: " + e.Message);
            }

            try
            {
                //Validation of the property added using search 
                //search for property description
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"), ExcelLib.ReadData(2, "Searchstring"));
                //Enter property description
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value"));                               //Click search button
                Thread.Sleep(6000);

                //Check: if search had no results end test
                //if (Driver.ElementVisible(Driver.driver, ExcelLib.ReadData(37, "Locator"), ExcelLib.ReadData(37, "Value"))) //If no results found popup on screen, screenshot and end test
                //{
                //    Base.test.Log(LogStatus.Fail, "Property not found in Properties list ");
                //    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Property not found");
                //    Base.extent.EndTest(Base.test);
                //}

                //Find property name from result list //*[@id='property-grid']/div/div[2]/div
                IList PropertiesFoundList = Driver.driver.FindElements(By.XPath("//*[@id='property-grid']/div/div[2]/div"));
                Thread.Sleep(3000);
                int PropertiesListCount = PropertiesFoundList.Count;
                for (int i = 1; i <= PropertiesListCount; i++)
                {
                    if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(45, "Locator"), ExcelLib.ReadData(45, "Value") + i + ExcelLib.ReadData(45, "Value1")).ToLower() == ExcelLib.ReadData(2, "Searchstring").ToLower())
                    {
                        Thread.Sleep(5000);
                        //Click on view details
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(47, "Locator"), ExcelLib.ReadData(47, "Value") + i + ExcelLib.ReadData(47, "Value1"));

                        Thread.Sleep(3000);

                        //Screen shot and test pass
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Property Listing");
                        Base.test.Log(LogStatus.Pass, "Test Passed, Property Listed successfully.");
                        Base.extent.EndTest(Base.test);
                    }
                    //else if(PropertiesListCount==i)
                    //{

                    //}
                    else
                    {
                        Base.test.Log(LogStatus.Fail, "Property not found in Properties list ");
                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Property not found");
                        Base.extent.EndTest(Base.test);
                    }

                }

            }
            catch (Exception e1)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error: " + e1.Message);
            }

        }
    }
}
