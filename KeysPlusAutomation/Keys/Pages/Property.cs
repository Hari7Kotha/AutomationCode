using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoIt;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static NUnit.Core.NUnitFramework;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;

namespace Keys.Pages
{
    class Property
    {
        internal Property()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        #region POM
        ////POM DEf
        ////Click on Property Link
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/ul[1]/li[2]/a")]
        //private IWebElement PropertyLink { get; set; }

        ////Property Name in  row
        //[FindsBy(How = How.XPath, Using = "//*[@id='pagedList']/div/ul/li[13]/a")]


        //private IWebElement Page { get; set; }

        ////Finding the add new property
        //[FindsBy(How = How.XPath, Using = "//*[@id='add-new-property']")]
        //private IWebElement AddNewProperty { get; set; }

        ////Finding the Property Info
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[1]/div/div/input")]
        //private IWebElement PropertyName { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[1]/div/div/span")]
        //private IWebElement PropertyNameErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[2]/div/div/textarea")]
        //private IWebElement Description { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[2]/div/div/span")]
        //private IWebElement DescErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[1]/div[2]/div/div[1]/div/div[3]/div/div/select")]
        //private IWebElement PropertyType { get; set; }

        //[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[1]/div[2]/div/div[1]/div/div[4]/div[1]/div/select")]
        //private IWebElement ResidentalType { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[5]/div/div/input")]
        //private IWebElement TargetRent { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[1]/div/div[5]/div/div/span")]
        //private IWebElement TargetRentErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[1]/div[2]/div/div[1]/div/div[6]/div/div/select")]
        //private IWebElement RentType { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='autocomplete0']")]
        //private IWebElement SearchAddress { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
        //private IWebElement Number { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[2]/div/span")]
        //private IWebElement NumberErr { get; set; }


        //[FindsBy(How = How.XPath, Using = "//*[@id='route']")]
        //private IWebElement Street { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[3]/div/span")]
        //private IWebElement StreetErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='postal_code']")]
        //private IWebElement PostCode { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[4]/div/span")]
        //private IWebElement PostCodeErr { get; set; }


        //[FindsBy(How = How.XPath, Using = "//*[@id='locality']")]
        //private IWebElement City { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[5]/div/span")]
        //private IWebElement CityErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='sublocality_level_1']")]
        //private IWebElement Suburb { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[2]/div/div/div[6]/div/span")]
        //private IWebElement SuburbErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[2]/div/input")]
        //private IWebElement BedRoom { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[2]/div/span")]
        //private IWebElement BedRoomErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[3]/div/input")]
        //private IWebElement BathRoom { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[3]/div/span")]
        //private IWebElement BathRoomErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[4]/div/input")]
        //private IWebElement FloorArea { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[4]/div/span")]
        //private IWebElement FloorAreaErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[5]/div/input")]
        //private IWebElement LandArea { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[5]/div/span")]
        //private IWebElement LandAreaErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[6]/div/input")]
        //private IWebElement ParkingSpace { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[6]/div/span")]
        //private IWebElement ParkingSpaceErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[1]/div/input")]
        //private IWebElement YearBuilt { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[3]/div/div[1]/div/span")]
        //private IWebElement YearBuiltErr { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[4]/button[1]")]
        //private IWebElement Save { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='propertyDetails']/div/div[4]/div/button[2]")]
        //private IWebElement Cancel { get; set; }

        ////[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[1]/h4/a")]
        ////private IWebElement PhotosTab { get; set; }

        ////[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[2]/input")]
        ////private IWebElement Browse { get; set; }

        //[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[3]/button[1]")]
        //private IWebElement SavePhotos { get; set; }

        ////[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/div/div[1]/form/div/div[2]/div[2]/div/div[3]/button[2]")]
        ////private IWebElement CancelPhotos { get; set; }

        //[FindsBy(How = How.XPath, Using = "html/body/div/div/div[1]/ul[1]/li[2]/a/h4")]
        //private IWebElement PropertyPage { get; set; }

        ////Finding Photo data


        ////[FindsBy(How = How.Id, Using = "//*[@id='photoUpload']/div/div[2]/input")]
        ////private IWebElement UploadFile { get; set; }
        ////[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/ul/li[2]/a")]
        ////private IWebElement BackPropertyPage { get; set; }
        ////Saranga

        ////Finding Photo data
        //[FindsBy(How = How.XPath, Using = ".//*[@id='headingTwo']/h4/a")]
        //private IWebElement PhotosTab { get; set; }
        //[FindsBy(How = How.XPath, Using = ".//*[@id='photoUpload']/div/div[2]/input")]
        //private IWebElement Browse { get; set; }
        //[FindsBy(How = How.XPath, Using = ".//*[@id='photoUpload']/div/div[3]/button[1]")]
        //private IWebElement SaveRecord { get; set; }
        //[FindsBy(How = How.XPath, Using = ".//*[@id='photoUpload']/div/div[3]/button[2]")]
        //private IWebElement CancelPhotos { get; set; }

        //[FindsBy(How = How.Id, Using = ".//*[@id='photoUpload']/div/div[2]/input")]
        //private IWebElement UploadFile { get; set; }

        //[FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[1]/ul/li[2]/a/h4")]
        //private IWebElement BackPropertyPage { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='SearchString']")]
        //private IWebElement SearchRecord { get; set; }
        //[FindsBy(How = How.XPath, Using = ".//*[@id='property-grid']/div[1]/form/div/span/button")]
        //private IWebElement SearchButton { get; set; }
        #endregion

        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);

        //Saranga
        #region old add property code
        //internal void AddProperty()
        //{
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

        //    //  PropertyLink.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
        //    Thread.Sleep(2000);

        //    //AddNewProperty.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
        //    Thread.Sleep(2000);


        //    //Read data from excel sheet to fill Property info

        //    // PropertyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
        //    Thread.Sleep(2000);

        //    //Description.SendKeys(ExcelLib.ReadData(RowCountBase, "Desc"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Desc"));
        //    Thread.Sleep(3000);

        //    // PropertyType.SendKeys(ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    Thread.Sleep(2000);

        //    //Select Prop Name from dropdown
        //    //PropertyType.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    //var proptypeSelect = PropertyType;
        //    //var ptype = new SelectElement(proptypeSelect);
        //    // ptype.SelectByText(ExcelLib.ReadData(RowCountBase, "PropertyType"));

        //    //ResidentalType.SendKeys(ExcelLib.ReadData(RowCountBase, "ResType"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "ResType"));
        //    Thread.Sleep(2000);

        //    //TargetRent.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
        //    //TargetRent.SendKeys(ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    Thread.Sleep(2000);

        //    //Rent Type
        //    //RentType.SendKeys(ExcelLib.ReadData(RowCountBase, "RentType"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(RowCountBase, "RentType"));
        //    Thread.Sleep(2000);
        //    //Read data from excel sheet to fill Address
        //    // SearchAddress.SendKeys(ExcelLib.ReadData(2, "Location"));
        //    // Thread.Sleep(2000);

        //    //Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Thread.Sleep(2000);

        //    //Street.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Thread.Sleep(2000);

        //    //PostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    Thread.Sleep(2000);

        //    // City.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Thread.Sleep(2000);

        //    //Suburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    Thread.Sleep(2000);

        //    //Read data from excel sheet to fill Property Details

        //    //YearBuilt.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));
        //    //YearBuilt.SendKeys(ExcelLib.ReadData(RowCountBase, "Year"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(RowCountBase, "Year"));

        //    //BedRoom.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));
        //    //BedRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    Thread.Sleep(2000);

        //    //BathRoom.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"));
        //    //BathRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    Thread.Sleep(2000);

        //    // FloorArea.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"));
        //    //FloorArea.SendKeys(ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"), ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    Thread.Sleep(2000);

        //    //LandArea.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"));
        //    //LandArea.SendKeys(ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    Thread.Sleep(2000);

        //    //ParkingSpace.Clear();
        //    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
        //    //ParkingSpace.SendKeys(ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"), ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    Thread.Sleep(2000);

        //    //Save.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(36, "Locator"), ExcelLib.ReadData(36, "Value"));
        //    Thread.Sleep(1000);

        //    //Photo data
        //    // PhotosTab.Click();
        //    //Thread.Sleep(4000);


        //    try
        //    {
        //        //click on browse button
        //        //Browse.Click();
        //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(38, "Locator"), ExcelLib.ReadData(38, "Value"));
        //        Thread.Sleep(2000);
        //        // File upload begins here

        //        AutoItX3 autoIt = new AutoItX3();
        //        autoIt.WinActivate("Open");
        //        //  autoIt.Send(@"E:\KEYS\property1.jpg");
        //        autoIt.Send(ExcelLib.ReadData(RowCountBase, "PhotoPath"));
        //        autoIt.Send("{ENTER}");
        //        Thread.Sleep(3000);

        //        //Driver.Textbox(Driver.driver, ExcelLib.ReadData(40, "Locator"), ExcelLib.ReadData(40, "Value"), ExcelLib.ReadData(RowCountBase, "PhotoPath"));
        //        //Thread.Sleep(5000);

        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

        //        Console.WriteLine("Error" + e.ToString());
        //    }

        //    //SaveRecord.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value"));
        //    Thread.Sleep(3000);
        //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Record added sucessfully");
        //    Thread.Sleep(3000);

        //    //BackPropertyPage.Click();
        //    //Thread.Sleep(2000);


        //    //verify added record and navigate through pages to find the record
        //    //SearchRecord.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(40, "Locator"), ExcelLib.ReadData(40, "Value"), ExcelLib.ReadData(RowCountBase, "Search"));
        //    Thread.Sleep(2000);
        //    //SearchButton.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(41, "Locator"), ExcelLib.ReadData(41, "Value"));
        //    Thread.Sleep(2000);

        //    try
        //    {
        //        //get row count using Ilist 

        //        IList proplistt = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
        //        int listcount = proplistt.Count;
        //        for (int i = 1; i <= listcount; i++)
        //        {
        //            if (ExcelLib.ReadData(RowCountBase, "Name") == Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text)

        //            {
        //                //Driver.wait(10);
        //                if (ExcelLib.ReadData(RowCountBase, "Date") == Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        //                {
        //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "found record with Name & date matched");
        //                    Thread.Sleep(2000);
        //                    //Click on Details button 
        //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/div/button")).Click();
        //                    // Driver.ActionButton(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"));
        //                    Thread.Sleep(2000);
        //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/div/ul/li[1]/a/span")).Click();
        //                    //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(48, "Locator"), ExcelLib.ReadData(48, "Value"));
        //                    Thread.Sleep(2000);
        //                    //Verify the details 
        //                    if (Driver.driver.FindElement(By.XPath(".//*[@id='property-grid']/div/div/div[2]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        //                    {
        //                        if (Driver.driver.FindElement(By.ClassName("carousel-inner")).Displayed)
        //                        {
        //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Image found and verified image");
        //                            Thread.Sleep(2000);
        //                        }
        //                        //Click on Back to Index button
        //                        //Driver.driver.FindElement(By.XPath(".//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(49, "Locator"), ExcelLib.ReadData(49, "Value"));
        //                        Thread.Sleep(2000);
        //                        //Screenshot
        //                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Found Added Property");
        //                        Thread.Sleep(2000);
        //                        //Log Info
        //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property found and verified add");
        //                        Thread.Sleep(2000);
        //                        break;

        //                    }
        //                    else
        //                    {
        //                        //Click on Back button
        //                        //Driver.driver.FindElement(By.XPath(".//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(49, "Locator"), ExcelLib.ReadData(49, "Value"));
        //                    }

        //                }
        //            }
        //        }
        //    }
        //    //        Thread.Sleep(500);
        //    //        if (Page.Enabled && Details == true)
        //    //        {
        //    //            Page.Click();
        //    //            Thread.Sleep(500);
        //    //        }
        //    //        Count++;
        //    //        //Check Next Pg button
        //    //    } while (Page.Enabled && Delete == true && Count <= Totnum);
        //    //}
        //    catch (Exception e)
        //    {
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "There is an issue,Please check");



        //    }

        //    ////CancelPhotos.Click();
        //    //// end test. (Reports)
        //    //extent.EndTest(Test);
        //    //// calling Flush writes everything to the log file (Reports)
        //    //extent.Flush();
        //}
        #endregion
        //Changes required in XPath
        #region old check max character code
        //internal void CheckMaxCharaterLength()
        //{
        //    //Using excel to populate data
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
        //    Thread.Sleep(2000);
        //    Base.test.Log(LogStatus.Info, "Select Property Page & Clicked");

        //    //Add_Property_Btn.Click();
        //    //PropertyLink.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
        //    Base.test.Log(LogStatus.Info, "Clicked on Property Link");
        //    //Click on Add New Property
        //    //AddNewProperty.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Clicked on Add New Property button");
        //    //validation of max length of Prop Name(4-30)
        //    //PropertyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Entered the property name with max/invalid characters");

        //    //Description characters
        //    //Description.SendKeys(ExcelLib.ReadData(RowCountBase, "Desc"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Desc"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Entered characters in the description");

        //    //Selecting Property type
        //    //PropertyType.SendKeys(ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Selected Property type");

        //    //Selecting an item in Residential type drop down
        //    //ResidentalType.SendKeys(ExcelLib.ReadData(RowCountBase, "ResType"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "ResType"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Selected an item from the residential type drop down list");

        //    //Selecting from Target rent
        //    //TargetRent.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
        //    //TargetRent.SendKeys(ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "entered target rent to more than maximum numbers");

        //    //Selecting Rent type drop down
        //    //RentType.SendKeys(ExcelLib.ReadData(RowCountBase, "RentType"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(RowCountBase, "RentType"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Selected an item in the property type");

        //    //Selecting Address details
        //    //Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid in number input field");

        //    // Input chars for "Search Address"

        //    ////Driver.driver.FindElement(By.XPath("//input[@autocomplete='off']")).SendKeys(ExcelLib.ReadData(6, "Search Address"));
        //    //Addr_Search.SendKeys(ExcelLib.ReadData(6, "Search Address"));
        //    //Driver.wait(10);
        //    //Base.test.Log(LogStatus.Info, "Input max/invalid values for search address field");

        //    //Street.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for street name field");

        //    //Clicking on the street name

        //    //PostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for post code field");

        //    //Inputing values for post code input field

        //    //City.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for city field");

        //    //Selecting ity and inputting values

        //    //Suburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for suburb field");

        //    //Enter Property Details 
        //    //Inputs for year built
        //    //clear 0 from the text boxes
        //    //YearBuilt.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));
        //    //YearBuilt.SendKeys(ExcelLib.ReadData(RowCountBase, "Year"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(RowCountBase, "Year"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for year built field");
        //    //Bedroom details
        //    BedRoom.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));
        //    //BedRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Bedroom field");

        //    //Bathroom details
        //    //BathRoom.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"));
        //    //BathRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Bathroom field");

        //    //Floor area details
        //    //FloorArea.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"));
        //    //FloorArea.SendKeys(ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"), ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Floor area field");

        //    //Land Area details
        //    LandArea.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"));
        //    //LandArea.SendKeys(ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Land area field");

        //    //Inputs for parking space
        //    ParkingSpace.Clear();
        //    Driver.GetClear(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
        //    //ParkingSpace.SendKeys(ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"), ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    //ParkingSpace.SendKeys(OpenQA.Selenium.Keys.Tab);
        //    Driver.Textbox(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"), (OpenQA.Selenium.Keys.Tab));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for parking space field");


        //    //Clicking on save and continue button

        //    //Save.Click();
        //    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(36, "Locator"), ExcelLib.ReadData(36, "Value"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Clicked on save and continue button");

        //    //validating all the input fields

        //    // Validating the property name maximum characters
        //    string PropNameErrMsg = "The Name field must be alphanumeric and must be between 4-30 characters.";
        //    //validating the Target Rent 
        //    string TargetRentErrMsg = "The Target Rent field must be a number and musn't exceed six digits.";
        //    //Validating the Number max characters
        //    string NumberErrMsg = "The Number field must be alphanumeric";
        //    //Validating the Number max characters
        //    string StreetErrMsg = "The Street field Must be between 1-50 characters.";
        //    //Validating the post code digit limit
        //    string PostCodeErrMsg = "The Post Code field must be numeric characters and must be between 1-4 characters.";
        //    //Validating city for max characters
        //    string CityErrMsg = "The City field must be alphabetic and betweeen 1-50 characters.";
        //    //validation for suburb
        //    string SuburbErrMsg = "The suburb field can only accept only 1-50 characters.";

        //    //validating year built
        //    string YearBuiltErrMsg = "The Year Built field must be a number and is from 1900 to present.";
        //    //Validating bedroom for max chars
        //    string BedRoomErrMsg = "The Bedroom field must be a number and musn't exceed two digits.";
        //    //Validating Bathroom max numbers
        //    string BathRoomErrMsg = "The Bathroom field must be a number and musn't exceed two digits.";
        //    //validating the floor area for max charcs
        //    string FloorAreaErrMsg = "The Floor Area field must be a number and musn't exceed six digits.";
        //    //Validating land area  
        //    string LandAreaErrMsg = "The Land Area field must be a number and musn't exceed six digits.";
        //    //Validating for parking space for max chars
        //    string ParkingSpaceErrMsg = "The Parking Space field must be a number and musn't exceed three digits.";



        //    try
        //    {
        //        Assert.AreEqual(PropNameErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Property Name : Expected & Actual results are equal");

        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">>No message for Invalid property name");
        //    }

        //    try
        //    {
        //        Assert.AreEqual(TargetRentErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value")));
        //        Base.test.Log(LogStatus.Pass, "TargetRent: Expected & Actual results are equal");
        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">>No message for Invalid Target Rent");
        //    }

        //    try
        //    {
        //        Assert.AreEqual(NumberErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Number : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + "No message Invalid Number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(StreetErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Street : Expected & Actual results are equal");
        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Invalid Street name, errorText message not displayed");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(PostCodeErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Post Code: Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test Failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Post code error meesage not displayed for invalid input");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(CityErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value")));
        //        Base.test.Log(LogStatus.Pass, "City :Expected & Actual results are equal");
        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + "Invalid city name error not found");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(SuburbErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Suburb :Expected & Actual results are equal");

        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for wrong suburb name");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(YearBuiltErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Year Built : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering Invalid year number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(BedRoomErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Bed Room : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong bedroom number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(BathRoomErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Bath Room : Expected & Actual results are equal");

        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong bathrooms number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(FloorAreaErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(31, "Locator"), ExcelLib.ReadData(31, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Floor Area : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong floor area number");

        //    }
        //    try
        //    {
        //        Assert.AreEqual(LandAreaErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value")));
        //        Base.test.Log(LogStatus.Pass, "Land Area: Expected & Actual results are equal");

        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong Land area number");
        //    }

        //    try
        //    {
        //        Assert.AreEqual(ParkingSpaceErrMsg, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value")));
        //        Thread.Sleep(1000);
        //        Base.test.Log(LogStatus.Pass, "Parking Space : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Fail, e.Message + "Error meesage not displayed for entering wrong parking space number");
        //    }

        //    try
        //    {
        //        if (Save.Enabled == false)
        //        {
        //            Base.test.Log(LogStatus.Pass, "Button Disable and Not allowed to save");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, e.Message + "Save Button Enable and allowed to save");
        //    }



        //}

        //Saranga ends here
        #endregion

        // Add new property
        public void AddProperty()
        {
            try
            {
                ExcelLib.PopulateInCollection(Base.ExcelPath, "Add Property");

                // Owner link
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                Thread.Sleep(2000);

                //properties option
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(40, "Locator"), ExcelLib.ReadData(40, "Value"));
                Thread.Sleep(2000);

                //AddNewProperty.Click();
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
                Thread.Sleep(2000);

                


                //Read data from excel sheet to fill Property info

                //Property Name
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
                Thread.Sleep(2000);

                //Description
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "Desc"));
                Thread.Sleep(3000);

                // PropertyType
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(2, "PropertyType"));
                Thread.Sleep(2000);

                //Choose the property type form the drop down
                IList<IWebElement> proptypelists = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[1]/div[2]/div/div/div/ul/li"));

                int ListsCount = proptypelists.Count();

                for (int i = 0; i < ListsCount; i++)
                {
                    if (proptypelists[i].Text == "Senior Housing")
                    {
                        proptypelists[i].Click();
                    }
                }
                ////Select Prop Name from dropdown
                ////PropertyType.Click();
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"), ExcelLib.ReadData(RowCountBase, "PropertyType"));


                //ResidentalType.SendKeys(ExcelLib.ReadData(RowCountBase, "ResType"));
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "ResType"));
                //Thread.Sleep(2000);

                ////TargetRent
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "TargetRent"));
                //Thread.Sleep(2000);

                ////Rent Type
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
                //Thread.Sleep(2000);

                //Search Address
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "Address"));
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.ArrowDown).Perform();
                Thread.Sleep(2000);
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Return).Perform();
                Thread.Sleep(2000);

                //scroll down
                IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.driver;
                IWebElement element1 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value")));
                (jse).ExecuteScript("arguments[0].scrollIntoView(true);", element1);

                Thread.Sleep(1000);

                //Select rent type from the drop down
                IList<IWebElement> Renttypes = Driver.driver.FindElements(By.XPath("//*[@id='property-details']/div[3]/div[3]/div/select/option"));

                int RentTypeCount = Renttypes.Count();

                for (int i = 0; i < RentTypeCount; i++)
                {
                    if (Renttypes[i].Text == "Fortnightly")
                    {
                        Thread.Sleep(2000);
                        Renttypes[i].Click();
                    }
                }
                //Read data from excel sheet to fill Address
                // SearchAddress.SendKeys(ExcelLib.ReadData(2, "Location"));
                                
                ////Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));
                //Thread.Sleep(2000);

                ////Street
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));
                //Thread.Sleep(2000);

                ////PostCode
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));
                //Thread.Sleep(2000);

                ////City
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
                //Thread.Sleep(2000);

                ////SubUrb
                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ASuburb"));
                //Thread.Sleep(2000);

                //Read data from excel sheet to fill Property Details

                //Year Built
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "Year"));
                Thread.Sleep(1000);

                //target rent
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(41, "Locator"), ExcelLib.ReadData(41, "Value"), ExcelLib.ReadData(RowCountBase, "TargetRent"));
                Thread.Sleep(1000);

                //Bedrooms
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(RowCountBase, "Bedroom"));
                Thread.Sleep(2000);

                //Bathrooms
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(RowCountBase, "Bathroom"));
                Thread.Sleep(2000);

                //FloorArea
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(RowCountBase, "FloorArea"));
                Thread.Sleep(2000);

                //Land Area
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"), ExcelLib.ReadData(RowCountBase, "LandArea"));
                Thread.Sleep(2000);

                //Car parks
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(RowCountBase, "PSpace"));
                Thread.Sleep(2000);

                //scroll down
                IJavaScriptExecutor js1 = (IJavaScriptExecutor)Driver.driver;
                IWebElement element2 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(35, "Value")));
                (js1).ExecuteScript("arguments[0].scrollIntoView(true);", element2);


                try
                {
                    //click on choosefiles
                    //Browse.Click();
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value"));
                    Thread.Sleep(5000);

                    // File upload begins here
                    
                    //AutoItX3 autoIt = new AutoItX3();
                    //autoIt.WinActivate("Open");
                    //autoIt.Send(@"E:\KEYS\property1.jpg");
                    
                    //autoIt.Send(ExcelLib.ReadData(2, "PhotoPath"));
                    //Thread.Sleep(3000);
                    //autoIt.Send("{ENTER 3}");
                    Thread.Sleep(3000);

                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

                }

                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed " +e.Message);

                    
                }
                Thread.Sleep(1000);
                //Next button not enabled dynaimcally - include action tab key
                new Actions(Driver.driver).SendKeys(OpenQA.Selenium.Keys.Tab).Perform();
                Thread.Sleep(2000);

                //click on next 
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
                Thread.Sleep(3000);

                ////SaveRecord.Click();
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value"));
                //Thread.Sleep(3000);

                //Add financial data
                //purchase price
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(82, "Locator"), ExcelLib.ReadData(82, "Value"), ExcelLib.ReadData(82, "Value2"));
                Thread.Sleep(2000);

                //Mortgage
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(83, "Locator"), ExcelLib.ReadData(83, "Value"), ExcelLib.ReadData(83, "Value2"));
                Thread.Sleep(2000);

                //Home Value
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(84, "Locator"), ExcelLib.ReadData(84, "Value"), ExcelLib.ReadData(84, "Value2"));
                Thread.Sleep(2000);

                //Home Value Type
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(85, "Locator"), ExcelLib.ReadData(85, "Value"));
                //Thread.Sleep(3000);
                //Select home value type from the dropdown
                IList<IWebElement> homevaluetypes = Driver.driver.FindElements(By.XPath("//*[@id='financeSection']/div[2]/div[2]/div/select/option"));

                int HomevalueTypeCount = homevaluetypes.Count();

                for (int i = 0; i < HomevalueTypeCount; i++)
                {
                    if (homevaluetypes[i].Text == "Estimated")
                    {
                        Thread.Sleep(2000);
                        homevaluetypes[i].Click();
                    }
                }
                Thread.Sleep(2000);
                IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
                Thread.Sleep(2000);
                IWebElement element = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(87, "Value")));

                (js).ExecuteScript("arguments[0].scrollIntoView(true);", element);
                Thread.Sleep(2000);

                //Repayment Amount
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(87, "Locator"), ExcelLib.ReadData(87, "Value"), ExcelLib.ReadData(87, "Value2"));
                Thread.Sleep(2000);

                //Repayement frequency dropdown
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(100, "Locator"), ExcelLib.ReadData(100, "Value"));
                //Select the repayment frequency
                IList<IWebElement> repayfreq = Driver.driver.FindElements(By.XPath("//*[@id='financeSection']/div[4]/div/div/div[1]/div/div[2]/select/option"));

                int repayfreqCount = repayfreq.Count();

                for (int i = 0; i < repayfreqCount; i++)
                {
                    if (repayfreq[i].Text == "Weekly")
                    {
                        Thread.Sleep(2000);
                        repayfreq[i].Click();
                    }
                }

                Thread.Sleep(2000);

                //Repayment Start Date
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(88, "Locator"), ExcelLib.ReadData(88, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(88, "Locator"), ExcelLib.ReadData(88, "Value"), ExcelLib.ReadData(88, "Value2"));
                Thread.Sleep(2000);

                //Repayment End Date
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(89, "Locator"), ExcelLib.ReadData(89, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(89, "Locator"), ExcelLib.ReadData(89, "Value"), ExcelLib.ReadData(89, "Value2"));
                Thread.Sleep(2000);

                //add expense
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(102, "Locator"), ExcelLib.ReadData(102, "Value"));
                Thread.Sleep(2000);

                //Expense amt
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(90, "Locator"), ExcelLib.ReadData(90, "Value"), ExcelLib.ReadData(90, "Value2"));
                Thread.Sleep(2000);

                //Expense desc
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(91, "Locator"), ExcelLib.ReadData(91, "Value"), ExcelLib.ReadData(91, "Value2"));
                Thread.Sleep(2000);

                //Expense date
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(92, "Locator"), ExcelLib.ReadData(92, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(92, "Locator"), ExcelLib.ReadData(92, "Value"), ExcelLib.ReadData(92, "Value2"));
                Thread.Sleep(2000);

                //for clicking out of the date picker
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(103, "Locator"), ExcelLib.ReadData(103, "Value"));
                Thread.Sleep(1000);

                //Driver.Textbox(Driver.driver, ExcelLib.ReadData(94, "Locator"), ExcelLib.ReadData(94, "Value"), ExcelLib.ReadData(94, "Value2"));
                //Thread.Sleep(2000);

                //scroll down
                IJavaScriptExecutor js2 = (IJavaScriptExecutor)Driver.driver;
                IWebElement element3 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(93, "Value")));
                (js2).ExecuteScript("arguments[0].scrollIntoView(true);", element3);
                Thread.Sleep(1000);

                //Click on Next button
                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(93, "Locator"), ExcelLib.ReadData(93, "Value"));
                Thread.Sleep(3000);

                //Add tenant details
                //Enter tenant email
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(95, "Locator"), ExcelLib.ReadData(95, "Value"), ExcelLib.ReadData(95, "Value2"));
                Thread.Sleep(2000);

               
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
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(108, "Locator"), ExcelLib.ReadData(108, "Value"), ExcelLib.ReadData(108, "Value2"));

                //Last Name
                Thread.Sleep(2000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(109, "Locator"), ExcelLib.ReadData(109, "Value"), ExcelLib.ReadData(109, "Value2"));

                //Start Date
                Thread.Sleep(2000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(96, "Locator"), ExcelLib.ReadData(96, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(96, "Locator"), ExcelLib.ReadData(96, "Value"), ExcelLib.ReadData(96, "Value2"));

                //End Date
                Thread.Sleep(3000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(97, "Locator"), ExcelLib.ReadData(97, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(97, "Locator"), ExcelLib.ReadData(97, "Value"), ExcelLib.ReadData(97, "Value2"));

                //Payment Frequency
                IList<IWebElement> payfreqlist = Driver.driver.FindElements(By.XPath("//*[@id='tenantSection']/div[4]/div[2]/div/select/option"));

                int payfreqCount = payfreqlist.Count();

                for (int i = 0; i < payfreqCount; i++)
                {
                    if (payfreqlist[i].Text == "Weekly")
                    {
                        payfreqlist[i].Click();
                    }
                }

                //Enter rent amount
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(101, "Locator"), ExcelLib.ReadData(101, "Value"), ExcelLib.ReadData(101, "Value2"));
                Thread.Sleep(2000);

                //payment start date
                Thread.Sleep(3000);
                Driver.GetClear(Driver.driver, ExcelLib.ReadData(110, "Locator"), ExcelLib.ReadData(110, "Value"));
                Thread.Sleep(1000);
                Driver.Textbox(Driver.driver, ExcelLib.ReadData(110, "Locator"), ExcelLib.ReadData(110, "Value"), ExcelLib.ReadData(110, "Value2"));

                //payment due date
                Thread.Sleep(1000);
                IList<IWebElement> payduelist = Driver.driver.FindElements(By.XPath("//*[@id='tenantSection']/div[5]/div[2]/div/select/option"));

                int paydueCount = payduelist.Count();

                for (int i = 0; i < paydueCount; i++)
                {
                    if (payduelist[i].Text == "1")
                    {
                        payduelist[i].Click();
                    }
                }

                Thread.Sleep(2000);
                
                ////Click Save
                //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(99, "Locator"), ExcelLib.ReadData(99, "Value"));
                Thread.Sleep(2000);

                //click on save button
                IWebElement save = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(99, "Value")));

                if (save.Enabled)
                {
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(99, "Locator"), ExcelLib.ReadData(99, "Value"));
                    Thread.Sleep(1000);
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Mandatory fields entered, Clicked on submit button to apply for a job");
                    Thread.Sleep(1000);

                    //Check if unregistered tenant alert on screen, if so accept
                    if (Driver.isDialogPresent(Driver.driver))
                    {
                        Driver.driver.SwitchTo().Alert().Accept();
                    }

                    Thread.Sleep(1000);

                    Base.test.Log(LogStatus.Info, "Record added sucessfully");
                    Thread.Sleep(3000);

                    //verify added record and navigate through pages to find the record
                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(38, "Locator"), ExcelLib.ReadData(38, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
                    Thread.Sleep(2000);
                    //SearchButton.Click();
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value"));
                    Thread.Sleep(2000);

                    //If property search returns no results popup occurs and test failed
                    if (Driver.ElementVisible(Driver.driver, ExcelLib.ReadData(107, "Locator"), ExcelLib.ReadData(107, "Value")) == true)
                    {
                        Base.test.Log(LogStatus.Fail, "Search for Property found no results, add property test failed");
                    }

                    try
                    {
                        //get row count using Ilist 

                        IList proplistt = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(106, "Value")));
                        int listcount = proplistt.Count;
                        for (int i = 1; i <= listcount; i++)
                        {
                            if (ExcelLib.ReadData(2, "Name") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(104, "Locator"), ExcelLib.ReadData(104, "Value") + i + ExcelLib.ReadData(104, "Value2")))
                            {
                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Found Added Property");
                                Thread.Sleep(2000);
                                //Log Info
                                Base.test.Log(LogStatus.Pass, "Added Property found and verified");
                                Thread.Sleep(2000);
                                break;

                            }
                            else
                            {
                                Base.test.Log(LogStatus.Fail, "Property not found, add property test failed");
                            }
                        }


                    }
                    catch (Exception e)
                    {
                        Base.test.Log(LogStatus.Info, e.Message + "There is an issue,Please check");
                    }
                }

                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Submit button is disabled. Please check your data");
                }
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Error, e.Message + "Error : ");
            }



        }





        #region
        internal void PropertyDetailValidation()
        {
            //Click Property tab
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
            //PropertyLink.Click();
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
            //Explicit Wait
            Thread.Sleep(1000);


            //AddNewProperty.Click();
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
            //Validating Alphanumeric in property Details
            Thread.Sleep(500);
            string expectederr;
            //Property Brief Info

            //PropertyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
            //Description.SendKeys(ExcelLib.ReadData(RowCountBase, "Desc"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Desc"));
            //TargetRent.SendKeys(ExcelLib.ReadData(RowCountBase, "TargetRent"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "TargetRent"));
            //SearchAddress.SendKeys(ExcelLib.ReadData(RowCountBase, "Location"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"), ExcelLib.ReadData(RowCountBase, "Location"));
            //Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));
            //Street.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));

            //Screenshot
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Property Details 1");
            Thread.Sleep(1000);
            //PostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));

            //City.Clear();
            // Driver.GetClear(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
            //City.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
            //Suburb.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"));
            //Suburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ASuburb"));

            //YearBuilt.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));
            //YearBuilt.SendKeys(ExcelLib.ReadData(RowCountBase, "Year"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(RowCountBase, "Year"));
            //BedRoom.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));
            //BedRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bedroom"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(RowCountBase, "Bedroom"));
            //BathRoom.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"));
            //BathRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bathroom"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(RowCountBase, "Bathroom"));
            //FloorArea.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"));
            //FloorArea.SendKeys(ExcelLib.ReadData(RowCountBase, "FloorArea"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"), ExcelLib.ReadData(RowCountBase, "FloorArea"));
            //LandArea.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(32,"Locator"), ExcelLib.ReadData(32,"Value"));
            //LandArea.SendKeys(ExcelLib.ReadData(RowCountBase, "LandArea"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(RowCountBase, "LandArea"));

            //ParkingSpace.Clear();
            //Driver.GetClear(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
            //ParkingSpace.SendKeys(ExcelLib.ReadData(RowCountBase, "PSpace"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"), ExcelLib.ReadData(RowCountBase, "PSpace"));
            Thread.Sleep(1000);
            //ParkingSpace.Click();
            //Driver.ActionButton(Driver.driver,ExcelLib.ReadData(34,"Locator"),ExcelLib.ReadData(34,"Value"));
            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"), ExcelLib.ReadData(RowCountBase, "PSpace"))

            Thread.Sleep(1000);
            try
            {
                expectederr = "The Name field must be alphanumeric and must be between 4-30 characters.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value")));
                Base.test.Log(LogStatus.Pass, "Property Name Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Property Name");
            }

            Thread.Sleep(500);
            //added by Saranga
            try
            {
                expectederr = "This field is required.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value")));
                Base.test.Log(LogStatus.Pass, "Description field Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Description");
            }
            Thread.Sleep(500);
            //end 

            try
            {
                expectederr = "The Target Rent field must be a number.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value")));
                Base.test.Log(LogStatus.Pass, "Target Rent Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid TargetRent");
            }
            Driver.wait(1);
            //Address

            Driver.wait(1);

            try
            {
                expectederr = "The Number field must be alphanumeric";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value")));
                Base.test.Log(LogStatus.Pass, "Address Number Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Number in address detail");
            }
            Thread.Sleep(500);

            try
            {
                expectederr = "The Street field Must be between 1-50 characters.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value")));
                Base.test.Log(LogStatus.Pass, "Address Street Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Street");

            }
            Thread.Sleep(500);

            try
            {
                expectederr = "The Post Code field must be numeric characters and must be between 1-4 characters.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value")));
                Base.test.Log(LogStatus.Pass, "Pass");
                Base.test.Log(LogStatus.Info, "Expected err: " + expectederr + "is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid PostCode");
            }
            Thread.Sleep(500);

            try
            {
                expectederr = "The City field must be alphabetic and betweeen 1 - 50 characters.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value")));
                Base.test.Log(LogStatus.Pass, "Address City Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid City Details");
            }

            try
            {
                expectederr = "The suburb field can only accept only 1-50 characters.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value")));
                Base.test.Log(LogStatus.Pass, "Address Suburb Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Suburb Details");
            }
            Driver.wait(1);
            //Property Detail

            try
            {
                expectederr = "The Bedroom field must be a number.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value")));
                Base.test.Log(LogStatus.Pass, "Bedroom Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Bedroom Details");
            }
            Driver.wait(1);

            try
            {
                expectederr = "The Bathroom field must be a number.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value")));
                Base.test.Log(LogStatus.Pass, "Bathroom Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Bathroom Details");
            }
            Driver.wait(1);

            try
            {
                expectederr = "The Floor Area field must be a number.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(31, "Locator"), ExcelLib.ReadData(31, "Value")));
                Base.test.Log(LogStatus.Pass, "Floor Area Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid FloorArea Details");
            }


            Driver.wait(1);
            try
            {
                expectederr = "The Land Area field must be a number.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value")));
                Base.test.Log(LogStatus.Pass, "LandArea Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid LandArea Details");
            }

            Driver.wait(1);
            try
            {
                expectederr = "The Parking Space field must be a number.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value")));
                Base.test.Log(LogStatus.Pass, "Parking Space Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Parking Space Details");
            }

            Driver.wait(1);
            try
            {
                expectederr = "The Year Built field must be a number and is from 1900 to present.";
                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value")));
                Base.test.Log(LogStatus.Pass, "Year Built Error validation, Pass");
                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
            }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Fail");
                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Year Details");
            }
            //Screenshot
            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Property Details 2");
        }
        #endregion


        internal void DeleteCancel()
        {
                        
            // Populating the data from Excel
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

            //click owner menu
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "LocatorD"), ExcelLib.ReadData(12, "ValueD"));

            //click properties option
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "LocatorD"), ExcelLib.ReadData(2, "ValueD"));

            Thread.Sleep(1000);

            //searching record to delete
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "LocatorD"), ExcelLib.ReadData(3, "ValueD"), ExcelLib.ReadData(RowCountBase, "Name"));

            Thread.Sleep(500);

            //clicking search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "LocatorD"), ExcelLib.ReadData(4, "ValueD"));
            Thread.Sleep(1000);

            string location = ExcelLib.ReadData(RowCountBase, "ANumber") + " " + ExcelLib.ReadData(RowCountBase, "AStreet") + ",";

            //Select the required record to delete
            try
            {
                IList getrow = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(13, "ValueD")));
                int listcount = getrow.Count;
                bool foundrec = true;
                
                for (int i = 1; i <= listcount && foundrec == true; i++)
                {
                    if (ExcelLib.ReadData(RowCountBase, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div["+i+"]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text)
                    {
                        if (location == Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div["+i+"]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[1]")).Text)
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Searched record found");
                            Thread.Sleep(1000);
                            //Click on Delete button from list
                            //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"));
                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div/div/div/div[1]/i")).Click();
                            Thread.Sleep(2000);
                            //clicking no on confirmation 
                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(14, "LocatorD"), ExcelLib.ReadData(14, "ValueD"));
                            //Thread.Sleep(2000);
                            //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(47, "Locator"), ExcelLib.ReadData(47, "Value"));
                            Thread.Sleep(2000);
                            //foundrec = true;
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Cancelled Delete functionality");
                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancel Delete Record");
                            Thread.Sleep(2000);
                            break;
                        }
                        else
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Date Not matched");
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Delete on Cancel mode:Issue pls check");
                        Thread.Sleep(2000);
                    }
                }
            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, e.Message + "There is an issue on delete,Please check");
                Thread.Sleep(2000);
            }

            Thread.Sleep(5000);
            //Verify the record not deleted from the grid
            //Log Info
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "After cancelled the delete ,Check whether the record is delete or not");
            //clearing search text box
            Driver.GetClear(Driver.driver, ExcelLib.ReadData(3, "LocatorD"), ExcelLib.ReadData(3, "ValueD"));

            //searching record
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "LocatorD"), ExcelLib.ReadData(3, "ValueD"), ExcelLib.ReadData(RowCountBase, "Name"));

            Thread.Sleep(500);

            //clicking search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "LocatorD"), ExcelLib.ReadData(4, "ValueD"));
            Thread.Sleep(1000);

            //check whether the reocrd is available or not
            try
            {
                IList getrow = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(13, "ValueD")));
                int listcount = getrow.Count;
                bool found = false;
                for (int i = 1; i <= listcount && found == false; i++)
                {
                    if (ExcelLib.ReadData(RowCountBase, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[" + i + "]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text)
                    {

                        if (location == Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[" + i + "]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[1]")).Text)
                        {
                            found = true;
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Cancelled record is NOT Deleted;test pass ");

                            //SaveScreenShotClass.SaveScreenshot(Driver.driver, "Property Delete Cancel : Working properly");
                            // Thread.Sleep(2000);
                            break;

                        }
                        else
                        {
                            found = false;
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record  Delete on Cancel mode:Test Fail");
                            Thread.Sleep(2000);
                        }
                        Thread.Sleep(2000);
                        // break;
                    }
                    else
                    {
                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "NO Record  found to verify");
                        Thread.Sleep(2000);
                    }


                }
            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e.Message + "There is an issue on delete,Please check");
                Thread.Sleep(2000);
            }


        }
        #region old code
        //Existing Code Begin here
        //////Bool delete check
        ////bool Delete = true;
        //////Remove once Defect672 fix
        //////Retrieve tot PGnumber
        //////String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[2]/div/div/ul/li[2]/a")).Text;
        //////int POSof = PageNumber.IndexOf("of") + 3;
        //////int endpos = PageNumber.IndexOf(".");
        //////int Totnum = Convert.ToInt32(PageNumber.Substring(POSof, endpos - POSof));
        ////Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Click();
        ////Driver.wait(2);
        ////int Totnum = Convert.ToInt32(Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Text);
        ////Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[1]/a")).Click();

        ////int Count = 1;
        //////remove //Remove once Defect672 fix

        //////Search the excel data in the grid


        ////IList proplist = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
        ////int proplistcount = proplist.Count;
        ////int PageCount = 1;
        //////int j = 1;
        //////int cnt=1;
        ////try
        ////{
        ////    do
        ////    {
        ////        // Can count the row with no of rows

        ////        //  for (int i = 1; i <= 10; i++)
        ////        for (int i = 1; i <= proplistcount; i++)
        ////        {
        ////            if (Driver.GetTextValue(Driver.driver,ExcelLib.ReadData(4, "Locator"),ExcelLib.ReadData(4,"Value")) == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
        ////            {
        ////                if (Driver.GetTextValue(Driver.driver,ExcelLib.ReadData(6,"Locator"),ExcelLib.ReadData(6, "Value")) == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        ////                {
        ////                    //Click on Details Page
        ////                    Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        ////                    //Verify the Address 
        ////                    if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        ////                    {
        ////                        //Click on Back button
        ////                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        ////                        //Screenshot
        ////                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancel Delete Property");

        ////                        //popup handle
        ////                        string existingWindowHandle = Driver.driver.CurrentWindowHandle;
        ////                        //Click Delete button
        ////                        Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
        ////                        //Implicit Wait
        ////                        //  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
        ////                        Thread.Sleep(500);

        ////                        //get the current window handles 
        ////                        string popupHandle = string.Empty;
        ////                        ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

        ////                        foreach (string handle in windowHandles)
        ////                        {
        ////                            if (handle != existingWindowHandle)
        ////                            {
        ////                                popupHandle = handle; break;
        ////                            }
        ////                        }
        ////                        //switch to new window 
        ////                        Driver.driver.SwitchTo().Window(popupHandle);
        ////                        Driver.wait(5);
        ////                        //check for element on new page 

        ////                        //Click Cancel on confirmation page                              

        ////                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[3]/div/div/div[3]/button[1]")).Click();
        ////                        Delete = false;
        ////                        //Log Info
        ////                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property Cancelled");
        ////                        break;

        ////                    }
        ////                    else
        ////                    {
        ////                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
        ////                        {
        ////                            //Click on Back button
        ////                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        ////                        }
        ////                    }

        ////                }


        ////            }
        ////        }
        ////        Thread.Sleep(500);
        ////        //Pagination through URL
        ////        if (PageCount <= Totnum && Totnum>1)
        ////        {
        ////            Driver.driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/PropertyOwners?page="+PageCount);
        ////            PageCount++;
        ////        }

        ////        //Pagination Have some issue
        ////        //if (Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[" + cnt + "]/a")).Enabled && Delete == true)
        ////        //{
        ////        //    if (j < 3)
        ////        //    {
        ////        //        j++;
        ////        //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[" + j + "]/a")).Click();
        ////        //        //*[@id="pagedList"]/div/ul/li[9]/a
        ////        //        //*[@id="pagedList"]/div/ul/li[12]/a
        ////        //        //*[@id="pagedList"]/div/ul/li[13]/a
        ////        //        //*[@id="pagedList"]/div/ul/li[13]/a
        ////        //        Thread.Sleep(500);
        ////        //        cnt = j;
        ////        //    }
        ////        //    else if(j>=3 && j<9)
        ////        //        {
        ////        //        j++;
        ////        //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Click();
        ////        //        Thread.Sleep(500);
        ////        //        cnt = j;
        ////        //    }

        ////        //    else if (j >= 9 && j <= Totnum - 7)
        ////        //    {
        ////        //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[15]/a")).Click();
        ////        //       Thread.Sleep(500);
        ////        //        j++;
        ////        //        cnt = 15;
        ////        //    }
        ////        //    else
        ////        //    {
        ////        //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[14]/a")).Click();
        ////        //        //*[@id="pagedList"]/div/ul/li[14]/a
        ////        //        //  j++;
        ////        //        cnt = 14;

        ////        //    }
        ////        //}
        ////        Count++;

        ////        //Check Next Pg button
        ////    } while ( PageCount <=Totnum && Delete == true); //&& Count <= Totnum); Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[" + cnt + "]/a")).Enabled
        ////}
        ////catch (Exception e)
        ////{
        ////    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
        ////}
        //////Verify the record is not deleted
        //////Refresh Property Page
        //////PropertyLink.Click();
        ////Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
        ////Thread.Sleep(500);
        ////bool found = false;
        ////Count = 1;
        ////PageCount = 1;
        //////Check the Boolean
        ////if (Delete==false)
        ////{
        ////    //Verify the record not deleted from the grid
        ////    //Log Info
        ////    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "After Cancellation, Verifying whether Property is available in the grid");
        ////    try
        ////    {
        ////        do
        ////        {
        ////            //  for (int i = 1; i <= 10; i++)
        ////            for (int i = 1; i <= proplistcount; i++)
        ////            {
        ////                if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
        ////                {
        ////                    if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        ////                    {
        ////                        //Click on Details Page
        ////                        Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        ////                        //Verify the Address 
        ////                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        ////                        {
        ////                            //Click on Back button
        ////                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        ////                            //Record Available
        //                            found = true;
        ////                            //Logg the status report
        ////                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record not Deleted, Test Pass");

        ////                        }
        ////                        else
        ////                        {
        ////                            if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
        ////                                //Click on Back button
        ////                                Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        ////                            //Record Not Found
        ////                            found = false;
        ////                        }

        ////                    }


        ////                }
        ////            }
        ////            //Pagination through URL
        ////            if (PageCount <= Totnum && Totnum > 1)
        ////            {
        ////                Driver.driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/PropertyOwners?page=" + PageCount);
        ////                PageCount++;
        ////            }
        ////            Count++;
        ////            //Check Next Pg button
        ////        } while (PageCount <= Totnum);// && Count <= Totnum);


        ////    }
        ////    catch (Exception e)
        ////    {
        ////        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
        ////    }
        ////}
        ////else
        ////{
        ////    //Logging Status in Test Report
        ////    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not present for deletion, Test Failed");
        ////    Delete = false;
        ////}
        ////if (found == false && Delete == true)
        ////    //Logging Status in Test Report
        ////    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Deleted, Test Failed");
        //////Esisting code end here
        //  }
        #endregion

        #region PropertyOld code

        ////Saranga
        //internal void AddProperty()
        //{
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

        //    PropertyLink.Click();
        //    Thread.Sleep(2000);

        //    AddNewProperty.Click();
        //    Thread.Sleep(2000);


        //    //Read data from excel sheet to fill Property info
        //    PropertyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Thread.Sleep(2000);
        //    Description.SendKeys(ExcelLib.ReadData(RowCountBase, "Desc"));
        //    Thread.Sleep(2000);
        //    PropertyType.SendKeys(ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    Thread.Sleep(2000);

        //    //Select Prop Name from dropdown
        //    PropertyType.Click();
        //    var proptypeSelect = PropertyType;
        //    var ptype = new SelectElement(proptypeSelect);
        //    ptype.SelectByText(ExcelLib.ReadData(RowCountBase, "PropertyType"));

        //    ResidentalType.SendKeys(ExcelLib.ReadData(RowCountBase, "ResType"));
        //    Thread.Sleep(2000);
        //    TargetRent.Clear();
        //    TargetRent.SendKeys(ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    Thread.Sleep(2000);

        //    //Read data from excel sheet to fill Address
        //   // SearchAddress.SendKeys(ExcelLib.ReadData(2, "Location"));
        //   // Thread.Sleep(2000);
        //    Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Thread.Sleep(2000);
        //    Street.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Thread.Sleep(2000);
        //    PostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    Thread.Sleep(2000);
        //    City.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Thread.Sleep(2000);
        //    Suburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    Thread.Sleep(2000);

        //    //Read data from excel sheet to fill Property Details
        //    BedRoom.Clear();
        //    BedRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    Thread.Sleep(2000);

        //    BathRoom.Clear();
        //    BathRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    Thread.Sleep(2000);

        //    FloorArea.Clear();
        //    FloorArea.SendKeys(ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    Thread.Sleep(2000);
        //    LandArea.Clear();
        //    LandArea.SendKeys(ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    Thread.Sleep(2000);

        //    ParkingSpace.Clear();
        //    ParkingSpace.SendKeys(ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    Thread.Sleep(2000);
        //    YearBuilt.Clear();
        //    YearBuilt.SendKeys(ExcelLib.ReadData(RowCountBase, "Year"));
        //    ParkingSpace.Click();
        //    Save.Click();
        //    Thread.Sleep(1000);

        //    //Photo data
        //    // PhotosTab.Click();
        //    //Thread.Sleep(4000);

        //    //click on browse button
        //    Browse.Click();
        //    Thread.Sleep(5000);
        //    try
        //    {
        //        // File upload begins here

        //        AutoItX3 autoIt = new AutoItX3();
        //        autoIt.WinActivate("Open");
        //        Thread.Sleep(5000);
        //        //  autoIt.Send(@"E:\KEYS\property1.jpg");
        //        autoIt.Send(ExcelLib.ReadData(RowCountBase, "PhotoPath"));
        //        Thread.Sleep(5000);
        //        autoIt.Send("{Enter}");
        //        Thread.Sleep(2000);
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

        //        Console.WriteLine("Error" + e.ToString());
        //    }

        //    SaveRecord.Click();
        //    Thread.Sleep(5000);
        //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo added sucessfully");
        //    Thread.Sleep(5000);

        //    //BackPropertyPage.Click();
        //    //Thread.Sleep(2000);


        //    //verify added record and navigate through pages to find the record
        //    SearchRecord.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Thread.Sleep(2000);
        //    SearchButton.Click();
        //    Thread.Sleep(2000);

        //    try
        //    {
        //        //get row count using Ilist 

        //        IList proplistt = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
        //        int listcount = proplistt.Count;
        //        for (int i = 1; i <= listcount; i++)
        //        {
        //            if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text)

        //            {
        //                //Driver.wait(10);
        //                if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        //                {
        //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "found record with Name & date matched");
        //                    Thread.Sleep(2000);
        //                    //Click on Details button 
        //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        //                    Thread.Sleep(2000);
        //                    //Verify the details 
        //                    if (Driver.driver.FindElement(By.XPath(".//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        //                    {
        //                        if (Driver.driver.FindElement(By.Id("carousel-example-generic")).Displayed)
        //                        {
        //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Image found and verified image");
        //                            Thread.Sleep(2000);
        //                        }
        //                        //Click on Back to Index button
        //                        Driver.driver.FindElement(By.XPath(".//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                        Thread.Sleep(2000);
        //                        //Screenshot
        //                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Found Added Property");
        //                        Thread.Sleep(2000);
        //                        //Log Info
        //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property found and verified add");
        //                        Thread.Sleep(2000);
        //                        break;

        //                    }
        //                    else
        //                    {
        //                        //Click on Back button
        //                        Driver.driver.FindElement(By.XPath(".//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();


        //                    }

        //                }
        //            }
        //        }
        //    }
        //    //        Thread.Sleep(500);
        //    //        if (Page.Enabled && Details == true)
        //    //        {
        //    //            Page.Click();
        //    //            Thread.Sleep(500);
        //    //        }
        //    //        Count++;
        //    //        //Check Next Pg button
        //    //    } while (Page.Enabled && Delete == true && Count <= Totnum);
        //    //}
        //    catch (Exception e)
        //    {
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "There is anissue,Please check");



        //    }

        //    ////CancelPhotos.Click();
        //    //// end test. (Reports)
        //    //extent.EndTest(Test);
        //    //// calling Flush writes everything to the log file (Reports)
        //    //extent.Flush();
        //}
        //internal void CheckMaxCharaterLength()
        //{
        //    //Using excel to populate data
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
        //    Thread.Sleep(2000);
        //    Base.test.Log(LogStatus.Info, "Select Property Page & Clicked");

        //    //Add_Property_Btn.Click();
        //    PropertyLink.Click();
        //    Base.test.Log(LogStatus.Info, "Clicked on Property Link");
        //    //Click on Add New Property
        //    AddNewProperty.Click();
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Clicked on Add New Property button");
        //    //validation of max length of Prop Name(4-30)
        //    PropertyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Entered the property name with max/invalid characters");

        //    //Description characters
        //    Description.SendKeys(ExcelLib.ReadData(RowCountBase, "Desc"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Entered characters in the description");

        //    //Selecting Property type
        //    PropertyType.SendKeys(ExcelLib.ReadData(RowCountBase, "PropertyType"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Selected Property type");

        //    //Selecting an item in Residential type drop down
        //    ResidentalType.SendKeys(ExcelLib.ReadData(RowCountBase, "ResType"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Selected an item from the residential type drop down list");

        //    //Selecting from Target rent
        //    TargetRent.Clear();
        //    TargetRent.SendKeys(ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "entered target rent to more than maximum numbers");
        //    //Selecting Rent type drop down
        //    RentType.SendKeys(ExcelLib.ReadData(RowCountBase, "RentType"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Selected an item in the property type");

        //    //Selecting Address details
        //    Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid in number input field");

        //    // Input chars for "Search Address"

        //    ////Driver.driver.FindElement(By.XPath("//input[@autocomplete='off']")).SendKeys(ExcelLib.ReadData(6, "Search Address"));
        //    //Addr_Search.SendKeys(ExcelLib.ReadData(6, "Search Address"));
        //    //Driver.wait(10);
        //    //Base.test.Log(LogStatus.Info, "Input max/invalid values for search address field");

        //    Street.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for street name field");

        //    //Clicking on the street name

        //    PostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for post code field");

        //    //Inputing values for post code input field

        //    City.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for city field");

        //    //Selecting ity and inputting values

        //    Suburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for suburb field");

        //    //Enter Property Details 
        //    //Inputs for year built
        //    //clear 0 from the text boxes
        //    YearBuilt.Clear();
        //    YearBuilt.SendKeys(ExcelLib.ReadData(RowCountBase, "Year"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for year built field");
        //    //Bedroom details
        //    BedRoom.Clear();
        //    BedRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Bedroom field");
        //    //Bathroom details
        //    BathRoom.Clear();
        //    BathRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Bathroom field");
        //    //Floor area details
        //    FloorArea.Clear();
        //    FloorArea.SendKeys(ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Floor area field");
        //    //Land Area details
        //    LandArea.Clear();
        //    LandArea.SendKeys(ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for Land area field");
        //    //Inputs for parking space
        //    ParkingSpace.Clear();
        //    ParkingSpace.SendKeys(ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    ParkingSpace.SendKeys(OpenQA.Selenium.Keys.Tab);
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Input max/invalid values for parking space field");


        //    //Clicking on save and continue button

        //    Save.Click();
        //    Thread.Sleep(1000);
        //    Base.test.Log(LogStatus.Info, "Clicked on save and continue button");

        //    //validating all the input fields

        //    // Validating the property name maximum characters
        //    string PropNameErrMsg = "The Name field must be alphanumeric and must be between 4-30 characters.";
        //    //validating the Target Rent 
        //    string TargetRentErrMsg = "The Target Rent field must be a number.";
        //    //Validating the Number max characters
        //    string NumberErrMsg = "The Number field must be alphanumeric characters.";
        //    //Validating the Number max characters
        //    string StreetErrMsg = "The Street field must be alphanumeric characters.";
        //    //Validating the post code digit limit
        //    string PostCodeErrMsg = "The Post Code field must be numeric characters and must be between 1-10 characters.";
        //    //Validating city for max characters
        //    string CityErrMsg = "The City field must be alphabetic characters.";
        //    //validation for suburb
        //    string SuburbErrMsg = "The Suburb field must be alphabetic characters.";

        //    //validating year built
        //    string YearBuiltErrMsg = "The Year Built field must be a number and is from 1900 to present.";
        //    //Validating bedroom for max chars
        //    string BedRoomErrMsg = "The Bedroom field must be a number.";
        //    //Validating Bathroom max numbers
        //    string BathRoomErrMsg = "The Bathroom field must be a number.";
        //    //validating the floor area for max charcs
        //    string FloorAreaErrMsg = "The Floor Area field must be a number.";
        //    //Validating land area  
        //    string LandAreaErrMsg = "The Land Area field must be a number.";
        //    //Validating for parking space for max chars
        //    string ParkingSpaceErrMsg = "The Parking Space field must be a number.";



        //    try
        //    {
        //        Assert.AreEqual(PropNameErrMsg, PropertyNameErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Property Name : Expected & Actual results are equal");

        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">>No message for Invalid property name");
        //    }

        //    try
        //    {
        //        Assert.AreEqual(TargetRentErrMsg, TargetRentErr.Text);
        //        Base.test.Log(LogStatus.Pass, "TargetRent: Expected & Actual results are equal");
        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">>No message for Invalid Target Rent");
        //    }

        //    try
        //    {
        //        Assert.AreEqual(NumberErrMsg, NumberErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Number : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + "No message Invalid Number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(StreetErrMsg, StreetErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Street : Expected & Actual results are equal");
        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Invalid Street name, errorText message not displayed");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(PostCodeErrMsg, PostCodeErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Post Code: Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test Failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Post code error meesage not displayed for invalid input");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(CityErrMsg, CityErr.Text);
        //        Base.test.Log(LogStatus.Pass, "City :Expected & Actual results are equal");
        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test fail");
        //        Base.test.Log(LogStatus.Info, e.Message + "Invalid city name error not found");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(SuburbErrMsg, SuburbErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Suburb :Expected & Actual results are equal");

        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for wrong suburb name");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(YearBuiltErrMsg, YearBuiltErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Year Built : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering Invalid year number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(BedRoomErrMsg, BedRoomErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Bed Room : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong bedroom number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(BathRoomErrMsg, BathRoomErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Bath Room : Expected & Actual results are equal");

        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong bathrooms number");
        //    }
        //    try
        //    {
        //        Assert.AreEqual(FloorAreaErrMsg, FloorAreaErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Floor Area : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong floor area number");

        //    }
        //    try
        //    {
        //        Assert.AreEqual(LandAreaErrMsg, LandAreaErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Land Area: Expected & Actual results are equal");

        //    }

        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Info, e.Message + "Error meesage not displayed for entering wrong Land area number");
        //    }

        //    try
        //    {
        //        Assert.AreEqual(ParkingSpaceErrMsg, ParkingSpaceErr.Text);
        //        Thread.Sleep(1000);
        //        Base.test.Log(LogStatus.Pass, "Parking Space : Expected & Actual results are equal");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Test failed");
        //        Base.test.Log(LogStatus.Fail, e.Message + "Error meesage not displayed for entering wrong parking space number");
        //    }

        //    try
        //    {
        //        if (Save.Enabled == false)
        //        {
        //            Base.test.Log(LogStatus.Pass, "ButtonDisable and Not allowed to save");
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, e.Message + "Save Button Enable and allowed to save");
        //    }


        //}
        ////Saranga ends here

        //internal void PropertyDetailValidation()
        //{
        //    //Click Property tab
        //    PropertyLink.Click();
        //    //Explicit Wait
        //    Thread.Sleep(500);
        //    // Populating the data from Excel
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
        //    AddNewProperty.Click();
        //    //Validating Alphanumeric in property Details
        //    Driver.wait(3);
        //    string expectederr;
        //    //Property Brief Info
        //    PropertyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
        //    Description.SendKeys(ExcelLib.ReadData(RowCountBase, "Desc"));
        //    TargetRent.SendKeys(ExcelLib.ReadData(RowCountBase, "TargetRent"));
        //    SearchAddress.SendKeys(ExcelLib.ReadData(RowCountBase, "Location"));
        //    Number.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
        //    Street.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
        //    Driver.wait(1);
        //    //Screenshot
        //    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Property Details 1");
        //    Driver.wait(1);
        //    PostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
        //    BedRoom.Clear();
        //    BedRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bedroom"));
        //    City.Clear();
        //    City.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
        //    Suburb.Clear();
        //    Suburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
        //    BathRoom.Clear();
        //    BathRoom.SendKeys(ExcelLib.ReadData(RowCountBase, "Bathroom"));
        //    FloorArea.Clear();
        //    FloorArea.SendKeys(ExcelLib.ReadData(RowCountBase, "FloorArea"));
        //    LandArea.Clear();
        //    LandArea.SendKeys(ExcelLib.ReadData(RowCountBase, "LandArea"));
        //    ParkingSpace.Clear();
        //    ParkingSpace.SendKeys(ExcelLib.ReadData(RowCountBase, "PSpace"));
        //    YearBuilt.Clear();
        //    YearBuilt.SendKeys(ExcelLib.ReadData(RowCountBase, "Year"));
        //    ParkingSpace.Click();
        //    try
        //    {
        //        expectederr = "The Name field must be alphanumeric and must be between 4-30 characters.";
        //        Assert.AreEqual(expectederr, PropertyNameErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Property Name Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '"+ expectederr+ " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Property Name");
        //    }

        //    Driver.wait(1);


        //    try {
        //        expectederr = "The Target Rent field must be a number.";
        //        Assert.AreEqual(expectederr, TargetRentErr.Text);
        //       Base.test.Log(LogStatus.Pass, "Target Rent Error validation, Pass");
        //       Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid TargetRent");
        //    }
        //    Driver.wait(1);
        //    //Address

        //    Driver.wait(1);

        //    try
        //    {
        //        expectederr = "The Number field must be alphanumeric characters.";
        //        Assert.AreEqual(expectederr, NumberErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Address Number Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Number in address detail");
        //    }
        //    Driver.wait(1);

        //    try
        //    {
        //        expectederr = "The Street field must be alphanumeric characters.";
        //        Assert.AreEqual(expectederr, StreetErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Address Street Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Street");

        //    }
        //    Driver.wait(1);

        //    try
        //    {
        //        expectederr = "The Post Code field must be numeric characters and must be between 1-10 characters.";
        //        Assert.AreEqual(expectederr, PostCodeErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: " + expectederr + "is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid PostCode");
        //    }
        //    Driver.wait(1);

        //    try
        //    {
        //        expectederr = "The City field must be alphanumeric characters.";
        //        Assert.AreEqual(expectederr, CityErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Address City Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid City Details");
        //    }

        //    try
        //    {
        //        expectederr = "The Suburb field must be alphanumeric characters.";
        //        Assert.AreEqual(expectederr, SuburbErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Address Suburb Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Suburb Details");
        //    }
        //    Driver.wait(1);
        //    //Property Detail

        //    try
        //    {
        //        expectederr = "The Bedroom field must be a number.";
        //        Assert.AreEqual(expectederr, BedRoomErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Bedroom Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Bedroom Details");
        //    }
        //    Driver.wait(1);

        //    try
        //    {
        //        expectederr = "The Bathroom field must be a number.";
        //        Assert.AreEqual(expectederr, BathRoomErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Bathroom Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Bathroom Details");
        //    }
        //    Driver.wait(1);

        //    try
        //    {
        //        expectederr = "The Floor Area field must be a number.";
        //        Assert.AreEqual(expectederr, FloorAreaErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Floor Area Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid FloorArea Details");
        //    }


        //    Driver.wait(1);
        //    try
        //    {
        //        expectederr = "The Land Area field must be a number.";
        //        Assert.AreEqual(expectederr, LandAreaErr.Text);
        //        Base.test.Log(LogStatus.Pass, "LandArea Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid LandArea Details");
        //    }

        //    Driver.wait(1);
        //    try
        //    {
        //        expectederr = "The Parking Space field must be a number.";
        //        Assert.AreEqual(expectederr, ParkingSpaceErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Parking Space Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Parking Space Details");
        //    }

        //    Driver.wait(1);
        //    try
        //    {
        //        expectederr = "The Year Built field must be a number and is from 1900 to present.";
        //        Assert.AreEqual(expectederr, YearBuiltErr.Text);
        //        Base.test.Log(LogStatus.Pass, "Year Built Error validation, Pass");
        //        Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(LogStatus.Fail, "Fail");
        //        Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Year Details");
        //    }
        //    //Screenshot
        //    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Invalid Property Details 2");
        //}

        //internal void DeleteCancel()
        //{
        //    //Click Property tab
        //    PropertyLink.Click();
        //    //Explicit Wait
        //    Thread.Sleep(500);
        //    Thread.Sleep(500);
        //    // Populating the data from Excel
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
        //    //Bool delete check
        //    bool Delete = true;
        //    //Remove once Defect672 fix
        //    //Retrieve tot PGnumber
        //    //String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[2]/div/div/ul/li[2]/a")).Text;
        //    //int POSof = PageNumber.IndexOf("of") + 3;
        //    //int endpos = PageNumber.IndexOf(".");
        //    //int Totnum = Convert.ToInt32(PageNumber.Substring(POSof, endpos - POSof));
        //    Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Click();
        //    Driver.wait(2);
        //    int Totnum = Convert.ToInt32(Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Text);
        //    Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[1]/a")).Click();

        //    int Count = 1;
        //    //remove //Remove once Defect672 fix

        //    //Search the excel data in the grid


        //    IList proplist = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
        //    int proplistcount = proplist.Count;
        //    int PageCount = 1;
        //    //int j = 1;
        //    //int cnt=1;
        //    try
        //    {
        //        do
        //        {
        //            // Can count the row with no of rows

        //            //  for (int i = 1; i <= 10; i++)
        //            for (int i = 1; i <= proplistcount; i++)
        //            {
        //                if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
        //                {
        //                    if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        //                    {
        //                        //Click on Details Page
        //                        Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        //                        //Verify the Address 
        //                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        //                        {
        //                            //Click on Back button
        //                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                            //Screenshot
        //                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancel Delete Property");

        //                            //popup handle
        //                            string existingWindowHandle = Driver.driver.CurrentWindowHandle;
        //                            //Click Delete button
        //                            Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
        //                            //Implicit Wait
        //                            //  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
        //                            Thread.Sleep(500);

        //                            //get the current window handles 
        //                            string popupHandle = string.Empty;
        //                            ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

        //                            foreach (string handle in windowHandles)
        //                            {
        //                                if (handle != existingWindowHandle)
        //                                {
        //                                    popupHandle = handle; break;
        //                                }
        //                            }
        //                            //switch to new window 
        //                            Driver.driver.SwitchTo().Window(popupHandle);
        //                            Driver.wait(5);
        //                            //check for element on new page 

        //                            //Click Cancel on confirmation page                              

        //                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[3]/div/div/div[3]/button[1]")).Click();
        //                            Delete = false;
        //                            //Log Info
        //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property Cancelled");
        //                            break;

        //                        }
        //                        else
        //                        {
        //                            if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
        //                            {
        //                                //Click on Back button
        //                                Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                            }
        //                        }

        //                    }


        //                }
        //            }
        //            Thread.Sleep(500);
        //            //Pagination through URL
        //            if (PageCount <= Totnum && Totnum>1)
        //            {
        //                Driver.driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/PropertyOwners?page="+PageCount);
        //                PageCount++;
        //            }

        //            //Pagination Have some issue
        //            //if (Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[" + cnt + "]/a")).Enabled && Delete == true)
        //            //{
        //            //    if (j < 3)
        //            //    {
        //            //        j++;
        //            //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[" + j + "]/a")).Click();
        //            //        //*[@id="pagedList"]/div/ul/li[9]/a
        //            //        //*[@id="pagedList"]/div/ul/li[12]/a
        //            //        //*[@id="pagedList"]/div/ul/li[13]/a
        //            //        //*[@id="pagedList"]/div/ul/li[13]/a
        //            //        Thread.Sleep(500);
        //            //        cnt = j;
        //            //    }
        //            //    else if(j>=3 && j<9)
        //            //        {
        //            //        j++;
        //            //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Click();
        //            //        Thread.Sleep(500);
        //            //        cnt = j;
        //            //    }

        //            //    else if (j >= 9 && j <= Totnum - 7)
        //            //    {
        //            //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[15]/a")).Click();
        //            //       Thread.Sleep(500);
        //            //        j++;
        //            //        cnt = 15;
        //            //    }
        //            //    else
        //            //    {
        //            //        Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[14]/a")).Click();
        //            //        //*[@id="pagedList"]/div/ul/li[14]/a
        //            //        //  j++;
        //            //        cnt = 14;

        //            //    }
        //            //}
        //            Count++;

        //            //Check Next Pg button
        //        } while ( PageCount <=Totnum && Delete == true); //&& Count <= Totnum); Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[" + cnt + "]/a")).Enabled
        //    }
        //    catch (Exception e)
        //    {
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
        //    }
        //    //Verify the record is not deleted
        //    //Refresh Property Page
        //    PropertyLink.Click();
        //    Thread.Sleep(500);
        //    bool found = false;
        //    Count = 1;
        //    PageCount = 1;
        //    //Check the Boolean
        //    if (Delete==false)
        //    {
        //        //Verify the record not deleted from the grid
        //        //Log Info
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "After Cancellation, Verifying whether Property is available in the grid");
        //        try
        //        {
        //            do
        //            {
        //                //  for (int i = 1; i <= 10; i++)
        //                for (int i = 1; i <= proplistcount; i++)
        //                {
        //                    if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
        //                    {
        //                        if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        //                        {
        //                            //Click on Details Page
        //                            Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        //                            //Verify the Address 
        //                            if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        //                            {
        //                                //Click on Back button
        //                                Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                                //Record Available
        //                                found = true;
        //                                //Logg the status report
        //                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record not Deleted, Test Pass");

        //                            }
        //                            else
        //                            {
        //                                if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
        //                                    //Click on Back button
        //                                    Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                                //Record Not Found
        //                                found = false;
        //                            }

        //                        }


        //                    }
        //                }
        //                //Pagination through URL
        //                if (PageCount <= Totnum && Totnum > 1)
        //                {
        //                    Driver.driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/PropertyOwners?page=" + PageCount);
        //                    PageCount++;
        //                }
        //                Count++;
        //                //Check Next Pg button
        //            } while (PageCount <= Totnum);// && Count <= Totnum);


        //        }
        //        catch (Exception e)
        //        {
        //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
        //        }
        //    }
        //    else
        //    {
        //        //Logging Status in Test Report
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not present for deletion, Test Failed");
        //        Delete = false;
        //    }
        //    if (found == false && Delete == true)
        //        //Logging Status in Test Report
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Deleted, Test Failed");
        //}

        //internal void DeleteProperty()
        //{
        //    //Click Property tab
        //    PropertyLink.Click();
        //    //Explicit Wait
        //    Thread.Sleep(500);
        //    // Populating the data from Excel
        //    ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");
        //    //Bool delete check
        //    bool Delete = false;
        //    //Remove once Defect672 fix
        //    //Retrieve tot PGnumber
        //    String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[2]/div/div/ul/li[2]/a")).Text;
        //   //int POSof= PageNumber.IndexOf("of") + 3;
        //   // int endpos = PageNumber.IndexOf(".");
        //   //int Totnum= Convert.ToInt32(PageNumber.Substring(POSof,endpos-POSof));
        //    //Totnum ofPages
        //    Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Click();
        //    Driver.wait(2);
        //    int Totnum = Convert.ToInt32(Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[13]/a")).Text);
        //    Driver.driver.FindElement(By.XPath("//*[@id='pagedList']/div/ul/li[1]/a")).Click();

        //    int Count = 1;
        //    int PageCount = 1;
        //    //remove //Remove once Defect672 fix
        //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Totnum.ToString());

        //    do
        //    {
        //        for (int i = 1; i <= 10; i++)
        //        {
        //            if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
        //            {
        //                if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        //                {
        //                    //Click on Details Page
        //                    Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        //                    //Verify the Address 
        //                    if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        //                    {
        //                        //Click on Back button
        //                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                        //Screenshot
        //                        SaveScreenShotClass.SaveScreenshot(Driver.driver, "DeleteProperty");
        //                        ////Click Delete button
        //                        //Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
        //                        ////Implicit Wait
        //                        ////  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
        //                        //Thread.Sleep(500);
        //                        //popup handle
        //                        string existingWindowHandle = Driver.driver.CurrentWindowHandle;
        //                        //Click Delete button
        //                        Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
        //                        //Implicit Wait
        //                        //  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
        //                        Thread.Sleep(1000);

        //                        //get the current window handles 
        //                        string popupHandle = string.Empty;
        //                        ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

        //                        foreach (string handle in windowHandles)
        //                        {
        //                            if (handle != existingWindowHandle)
        //                            {
        //                                popupHandle = handle; break;
        //                            }
        //                        }
        //                        //switch to new window 
        //                        Driver.driver.SwitchTo().Window(popupHandle);
        //                        Driver.wait(5);
        //                        //check for element on new page 

        //                        //Click Delete on confirmation page                              
        //                        //Driver.driver.SwitchTo().Frame("removeModal");
        //                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[3]/div/div/div[3]/button[2]")).Click();
        //                        Delete = true;
        //                        //Log Info
        //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property Deleted");
        //                        break;
        //                        /************************/
        //                        //  Driver.driver.SwitchTo().Alert().Accept();
        //                    }
        //                    else
        //                    {
        //                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
        //                        {
        //                            //Click on Back button
        //                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                        }
        //                    }

        //                }


        //            }
        //        }
        //        Thread.Sleep(500);
        //        //if (Page.Enabled && Delete==false)
        //        //{
        //        //    Page.Click();
        //        //    Thread.Sleep(500);
        //        //}
        //        //Pagination through URL
        //        if (PageCount <= Totnum && Totnum > 1)
        //        {
        //            Driver.driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/PropertyOwners?page=" + PageCount);
        //            PageCount++;
        //        }

        //        Count++;
        //        //Check Next Pg button
        //    } while (PageCount <= Totnum && Delete == false);// && Count<=Totnum);
        //    //Refresh Property Page
        //    PropertyLink.Click();
        //    Thread.Sleep(500);
        //    bool found = false;
        //    Count = 1;
        //    PageCount = 1;
        //    //Check the Boolean
        //    if (Delete)
        //    {
        //        //Verify the record deleted from the grid
        //        //Log Info
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "After Deletion, Verifying whether Deleted Property available in the grid");
        //        IList proplist1 = Driver.driver.FindElements(By.XPath("//*[@id='propList']/tr"));
        //        int proplistcount = proplist1.Count;
        //        try
        //        {
        //            do
        //            {
        //                // for (int i = 1; i <= 10; i++)
        //                for (int i = 1; i <= proplistcount; i++)
        //                {
        //                    if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[1]")).Text)
        //                    {
        //                        if (ExcelLib.ReadData(2, "Date") == Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[2]")).Text)
        //                        {
        //                            //Click on Details Page
        //                            Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[1]")).Click();
        //                            //Verify the Address 
        //                            if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/td")).Text == ExcelLib.ReadData(2, "Location"))
        //                            {
        //                                //Click on Back button
        //                                Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                                //Record Available
        //                                found = true;
        //                                //Logg the status report
        //                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not Deleted, Test Failed");

        //                            }
        //                            else
        //                            {
        //                                if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
        //                                    //Click on Back button
        //                                    Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
        //                                //Record Not Found
        //                                found = false;
        //                            }

        //                        }


        //                    }
        //                }
        //                //if (Page.Enabled)
        //                //{
        //                //    Page.Click();
        //                //    Thread.Sleep(500);
        //                //}
        //                //Pagination through URL
        //                if (PageCount <= Totnum && Totnum > 1)
        //                {
        //                    Driver.driver.Navigate().GoToUrl("http://new-keys.azurewebsites.net/PropertyOwners?page=" + PageCount);
        //                    PageCount++;
        //                }
        //                Count++;
        //                //Check Next Pg button
        //            } while ( PageCount <= Totnum );


        //        }
        //        catch (Exception e)
        //        {
        //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "End of Page or Pagination issue, \n Please check");
        //        }
        //    }
        //    else
        //    {
        //        //Logging Status in Test Report
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not present for deletion, Test Failed");
        //    }
        //    if(found==false && Delete==true)
        //        //Logging Status in Test Report
        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record Deleted Successfully, Test Pass");
        //}
        #endregion
        public void DeleteProperty()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Property");

            //click owner menu
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "LocatorD"), ExcelLib.ReadData(12, "ValueD"));

            //click properties option
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "LocatorD"), ExcelLib.ReadData(2, "ValueD"));

            Thread.Sleep(1000);

            //searching record
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "LocatorD"), ExcelLib.ReadData(3, "ValueD"), ExcelLib.ReadData(RowCountBase, "Name"));

            Thread.Sleep(500);

            //clicking search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "LocatorD"), ExcelLib.ReadData(4, "ValueD"));
            Thread.Sleep(1000);

            IList propertylist = Driver.driver.FindElements(By.XPath("//*[@id='property-grid']/div/div[2]/div/div/div/div[2]/div[2]/div[1]/div[1]/div[1]"));
            int proplistcount = propertylist.Count;

            string propertyname;
            //string location;
            string location1;
            Thread.Sleep(500);
            string fulladdress = ExcelLib.ReadData(RowCountBase, "ANumber") + " " + ExcelLib.ReadData(RowCountBase, "AStreet") + ",";
            //ExcelLib.ReadData(RowCountBase, "ACity");

            for (int i = 1; i <= proplistcount; i++)
            {
                //property name text
                propertyname = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div["+i+"]/div/div/div[2]/div[2]/div[1]/div[1]/div[1]")).Text;
                location1 = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div["+i+"]/div/div/div[2]/div[2]/div[1]/div[1]/div[2]/span[1]")).Text;
                try
                {
                    if (propertyname == ExcelLib.ReadData(RowCountBase, "Name") && location1 == fulladdress)
                    {

                        //clicking on delete button
                        Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[" + i + "]/div/div/div[1]/i")).Click();
                        Thread.Sleep(1000);

                        //clicking on yes confirmation button
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "LocatorD"), ExcelLib.ReadData(7, "ValueD"));
                        Thread.Sleep(1000);

                        //clicking on delete completion ok button
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "LocatorD"), ExcelLib.ReadData(8, "ValueD"));
                        Thread.Sleep(1000);

                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property found to delete and deleted");


                    }
                }
                catch
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property not found");
                }
            }

            //validating deleted property
            Thread.Sleep(1000);
            //click owner menu
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "LocatorD"), ExcelLib.ReadData(12, "ValueD"));

            //click properties option
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "LocatorD"), ExcelLib.ReadData(2, "ValueD"));

            Thread.Sleep(1000);

            //searching record
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(3, "LocatorD"), ExcelLib.ReadData(3, "ValueD"), ExcelLib.ReadData(RowCountBase, "Name"));

            Thread.Sleep(500);

            //clicking search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "LocatorD"), ExcelLib.ReadData(4, "ValueD"));
            Thread.Sleep(1000);

            //pop-up messages for no record found
            string deletetext1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(9, "LocatorD"), ExcelLib.ReadData(9, "ValueD"));
            string deletetext2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(10, "LocatorD"), ExcelLib.ReadData(10, "ValueD"));
            try
            {
                if (deletetext1 == "No records found for:" && deletetext2 == ExcelLib.ReadData(RowCountBase, "Name"))
                {
                    //clicking on ok button
                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "LocatorD"), ExcelLib.ReadData(11, "ValueD"));
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property is deleted successfully");
                }

            }


            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property not deleted" + e.Message);
            }

        }
    }
}

////clicking action button
//Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/div/button")).Click();
//Thread.Sleep(500);
////clicking on detail
//Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/div/ul/li[1]/a")).Click();
//Thread.Sleep(2000);

////location text
//location = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "LocatorD"), ExcelLib.ReadData(5, "ValueD"));

//if (location == fulladdress)
//{
//    //clicking back to index
//    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "LocatorD"), ExcelLib.ReadData(6, "ValueD"));
//    Thread.Sleep(500);

//    //click on action button
//    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/div/button")).Click();
//    Thread.Sleep(500);

//    //clicking on delete button
//    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]/div/ul/li[5]/a")).Click();
//    Thread.Sleep(1000);

//    //clicking on yes
//    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "LocatorD"), ExcelLib.ReadData(7, "ValueD"));
//    Thread.Sleep(1000);

//    //clicking on ok
//    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "LocatorD"), ExcelLib.ReadData(8, "ValueD"));
//    Thread.Sleep(1000);
//      break ;

//}
//        else
//        {
//            //clicking back to index
//            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "LocatorD"), ExcelLib.ReadData(6, "ValueD"));
//        }
//        }
//    }
//    catch (Exception e)
//    {
//        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e.Message);
//    }
//}



//else
//{
//    IList proplist2 = Driver.driver.FindElements(By.XPath("//*[@id='property-grid']/div/div[2]/div/div/div/div[2]/div[2]/div[1]"));
//    int proplistcount2 = proplist2.Count;

//    string propertyname2;
//    string location2;
//    //bool delete = false;
//    for (int j = 1; j <= proplistcount2; j++)
//    {
//        propertyname2 = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[" + j + "]/div/div/div[2]/div[2]/div[1]")).Text;
//        location2 = Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div/div[2]/div[" + j + "]/div/div/div[2]/div[2]/div[2]/span[1]")).Text;

//        if (propertyname2 == ExcelLib.ReadData(RowCountBase, "Name") && location2 != fulladdress)
//        {
//            
//            //clicking action button
//            Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + j + "]/td[3]/div/button")).Click();
//            Thread.Sleep(500);
//            //clicking on detail
//            Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + j + "]/td[3]/div/ul/li[1]/a")).Click();

//            //location text
//            location = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(5, "LocatorD"), ExcelLib.ReadData(5, "ValueD"));

//            if (location != fulladdress)
//            {

//delete = false;
//                //back to index
//                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "LocatorD"), ExcelLib.ReadData(6, "ValueD"));
//Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property is deleted successfully");
//                //  break;
//            }

//            else
//            {

//                delete = true;
//                //back to index
//                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(6, "LocatorD"), ExcelLib.ReadData(6, "ValueD"));
//            }

//        }
//        //else
//        //{
//        //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property is deleted successfully");
//        //}
//    }
//    if (delete == false)
//    {
//        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Property is deleted successfully");
//    }
//    else
//        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Property is not deleted");





