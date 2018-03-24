using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
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
    class Tenant_Watchlist
    {
        internal Tenant_Watchlist()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
        // Watchlist
        public void TenantWatchlist()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Tenant-Watchlist");

                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(500);
                // My Rental watchlist link
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(500);

                //searching Property
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "Search Property"));

                Thread.Sleep(500);

                //Click search button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
                Thread.Sleep(500);
                //If property search returns no results popup occurs and test failed
                if (Driver.ElementVisible(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value")) == true)
                {
                    Base.test.Log(LogStatus.Fail, "Search for Property found no results");
                }

                try
                {
                    IList proplistt = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(7, "Value")));
                    int listcountS = proplistt.Count;
                    for (int i = 1; i <= listcountS; i++)
                    {
                        if (ExcelLib.ReadData(2, "Search Property") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value")))
                        {
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Searched Property is found");
                            Thread.Sleep(2000);
                            //Log Info
                            Base.test.Log(LogStatus.Pass, "Searched Property found and verified");
                            Thread.Sleep(2000);
                            break;

                        }
                        else
                        {
                            Base.test.Log(LogStatus.Fail, "Property not found, search property test failed");
                        }
                    }

                }
                catch (Exception e)
                {
                    Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
                }
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Error, e.Message + "Error : ");
            }

       }
        
        }
    }



