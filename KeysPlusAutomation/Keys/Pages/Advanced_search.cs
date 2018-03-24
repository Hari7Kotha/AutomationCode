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
    class Advanced_search
    {
        internal Advanced_search()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
        // Advanced search
        public void Advancedsearch()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Advanced search");

                // Properties for rent link
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(500);

                //Advanced search
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(500);

                //Select Region from the list
                IList<IWebElement> Regions = Driver.driver.FindElements(By.XPath("//*[@id='Address_Region']/option[13]"));

                int RegionCount = Regions.Count();

                for (int i = 0; i < RegionCount; i++)
                {
                    if (Regions[i].Text == "Canterbury")
                    {
                        Thread.Sleep(500);
                        Regions[i].Click();
                    }
                }
                //Select District from the list
                IList<IWebElement> Districts = Driver.driver.FindElements(By.XPath("//*[@id='Address_City']/option[3]"));

                int Districtscount = Districts.Count();

                for (int i = 0; i < Districtscount; i++)
                {
                    if (Districts[i].Text == "Christchurch City")
                    {
                        Thread.Sleep(500);
                        Districts[i].Click();
                    }
                }
                //Select Suburbs from the list
                IList<IWebElement> Suburbs = Driver.driver.FindElements(By.XPath("//*[@id='Address_SuburbList']/option[46]"));

                int Suburbscount = Suburbs.Count();

                for (int i = 0; i < Suburbscount; i++)
                {
                    if (Suburbs[i].Text == "Linwood")
                    {
                        Thread.Sleep(500);
                        Suburbs[i].Click();
                    }
                }

                //Select Bedrooms from the list
                IList<IWebElement> Bedrooms = Driver.driver.FindElements(By.XPath("//*[@id='BedroomMin']/option[3]"));

                int Bedroomscount = Bedrooms.Count();

                for (int i = 0; i < Bedroomscount; i++)
                {
                    if (Bedrooms[i].Text == "2")
                    {
                        Thread.Sleep(500);
                        Bedrooms[i].Click();
                    }
                }

                //Select Bedrooms from the list
                IList<IWebElement> Bedrooms1 = Driver.driver.FindElements(By.XPath("//*[@id='BedroomMax']/option[4]"));

                int Bedroomscount1 = Bedrooms1.Count();

                for (int i = 0; i < Bedroomscount1; i++)
                {
                    if (Bedrooms1[i].Text == "3")
                    {
                        Thread.Sleep(500);
                        Bedrooms1[i].Click();
                    }
                }
                //Select Bathrooms from the list
                IList<IWebElement> Bathrooms = Driver.driver.FindElements(By.XPath("//*[@id='BathroomMin']/option[2]"));

                int Bathroomscount = Bathrooms.Count();

                for (int i = 0; i < Bathroomscount; i++)
                {
                    if (Bathrooms[i].Text == "1")
                    {
                        Thread.Sleep(500);
                        Bathrooms[i].Click();
                    }
                }

                //Select Bathrooms from the list
                IList<IWebElement> Bathrooms1 = Driver.driver.FindElements(By.XPath("//*[@id='BathroomMax']/option[3]"));

                int Bathroomscount1 = Bathrooms1.Count();

                for (int i = 0; i < Bathroomscount1; i++)
                {
                    if (Bathrooms1[i].Text == "2")
                    {
                        Thread.Sleep(500);
                        Bathrooms1[i].Click();
                    }
                }
                //Rent per week
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(RowCountBase, "Rentmin"));
                Thread.Sleep(2000);

                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "Rentmax"));
                Thread.Sleep(2000);

                //proprty ID
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "PropID"));
                Thread.Sleep(2000);

                //Select Proptype from the list
                IList<IWebElement> Proptype = Driver.driver.FindElements(By.XPath("//*[@id='advanced-search']/fieldset[4]/div/span/div/button/span/option[2]"));
                int Proptypecount = Proptype.Count();

                for (int i = 0; i < Proptypecount; i++)
                {
                    if (Proptype[i].Text == "Affordable Housing")
                    {
                        Thread.Sleep(500);
                        Proptype[i].Click();
                    }
                }


                //Select Landarea from the list
                IList<IWebElement> Landarea = Driver.driver.FindElements(By.XPath("//*[@id='LandSqmMin']/option[2]"));

                int Landareacount = Landarea.Count();

                for (int i = 0; i < Landareacount; i++)
                {
                    if (Landarea[i].Text == "400")
                    {
                        Thread.Sleep(500);
                        Landarea[i].Click();
                    }
                }

                //Select Landarea from the list
                IList<IWebElement> Landarea1 = Driver.driver.FindElements(By.XPath("//*[@id='LandSqmMax']/option[4]"));

                int Landareacount1 = Landarea1.Count();

                for (int i = 0; i < Landareacount1; i++)
                {
                    if (Landarea1[i].Text == "1200")
                    {
                        Thread.Sleep(500);
                        Landarea1[i].Click();
                    }
                }

                //Click on Search
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
                Thread.Sleep(2000);


                try
                {
                    IList proplistt = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(63, "Value")));
                    int listcountS = proplistt.Count;
                    for (int i = 1; i <= listcountS; i++)
                    {
                        if (ExcelLib.ReadData(2, "Name") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(61, "Locator"), ExcelLib.ReadData(61, "Value") + i + ExcelLib.ReadData(61, "Value2")))
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
