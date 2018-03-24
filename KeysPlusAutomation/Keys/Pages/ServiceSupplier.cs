using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static NUnit.Core.NUnitFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Interactions;


namespace Keys.Pages

{
    #region old code
    //class Company
    //{
    //    internal Company()
    //    {
    //        PageFactory.InitElements(Driver.driver, this);

    //    }
    //    bool submit = false;
    //    //Page Factory Def
    //    //Click on Company Link
    //    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[1]/ul/li[3]/a")]
    //    private IWebElement CompanyLink { get; set; }
    //    //Click on Add New Company Button
    //    [FindsBy(How = How.XPath, Using = "//*[@id='add-new-company']")]
    //    private IWebElement AddCompanyButton { get; set; }
    //    // Add New Company Header
    //    [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/div[2]/h3")]
    //    private IWebElement AddCompanyHeader { get; set; }
    //    //Enter Company Name
    //    [FindsBy(How = How.XPath, Using = "//*[@id='companyDetails']/div/div[1]/div[1]/div/input")]
    //    private IWebElement CompanyName { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='companyDetails']/div/div[1]/div[1]/div/span")]
    //    private IWebElement CompanyNameErr { get; set; }
    //    //Enter Company Website
    //    [FindsBy(How = How.XPath, Using = "//*[@id='companyDetails']/div/div[1]/div[2]/div/input")]
    //    private IWebElement CompanyWeb { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='companyDetails']/div/div[1]/div[2]/div/span")]
    //    private IWebElement CompanyWebErr { get; set; }
    //    //Enter Company Website
    //    [FindsBy(How = How.XPath, Using = "//*[@id='companyDetails']/div/div[1]/div[3]/div/input")]
    //    private IWebElement CompanyPhn { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='companyDetails']/div/div[1]/div[3]/div/span")]
    //    private IWebElement CompanyPhnErr { get; set; }
    //    //Enter Search Addr
    //    [FindsBy(How = How.XPath, Using = "//*[@id='autocomplete0']")]
    //    private IWebElement SearchAddr { get; set; }
    //    //Enter Number
    //    [FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
    //    private IWebElement ANumber { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[2]/div/span")]
    //    private IWebElement ANumberErr { get; set; }
    //    // Company Search textbox
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='SearchString']")]
    //    private IWebElement CompanySearch { get; set; }
    //    //Search button for company
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='company-grid']/div[1]/form/div/span/button")]
    //    private IWebElement CompanySearchB { get; set; }

    //    //Enter Street
    //    [FindsBy(How = How.XPath, Using = "//*[@id='route']")]
    //    private IWebElement AStreet { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[3]/div/span")]
    //    private IWebElement AStreetErr { get; set; }
    //    //Enter PostCode
    //    [FindsBy(How = How.XPath, Using = "//*[@id='postal_code']")]
    //    private IWebElement APostCode { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[4]/div/span")]
    //    private IWebElement APostCodeErr { get; set; }
    //    //Enter City
        
    //    [FindsBy(How = How.XPath, Using = "//*[@id='locality']")]
    //    private IWebElement ACity { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[5]/div/span")]
    //    private IWebElement ACityErr { get; set; }
    //    //Enter Suburb
    //    [FindsBy(How = How.XPath, Using = "//*[@id='sublocality_level_1']")]
    //    private IWebElement ASuburb { get; set; }
    //    [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[2]/form/div[3]/div/div[6]/div/span")]
    //    private IWebElement ASuburbErr { get; set; }
    //    //Checkbox Is ShpSame
    //    [FindsBy(How = How.XPath, Using = "//*[@id='isShipSame']")]
    //    private IWebElement CheckShipSame { get; set; }
    //    //Submitbutton
    //    [FindsBy(How = How.XPath, Using = "//*[@id='addCompany']/div/div/div[3]/button[2]")]
    //    private IWebElement Submit { get; set; }
    //    //Save Button
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='companyDetails']/div/div[3]/div/button[1]")]
    //    private IWebElement Save { get; set; }
    //    //Company Edit Button
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='compList']/tr/td[2]/a[2]")]
    //    private IWebElement CompanyEdit { get; set; }
    //    //Company Website  textbox
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='companyDetails']/div/div[1]/div[2]/div/input")]
    //    private IWebElement CompanyWebsite { get; set; }
    //    //Enter Phone Number
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='companyDetails']/div/div[1]/div[3]/div/input")]
    //    private IWebElement PhoneNumber { get; set; }
    //    //Company Detail button
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='compList']/tr/td[2]/a[1]")]
    //    private IWebElement CompanyDetail { get; set; }

    //    public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
    //    //Billing Address
    //    ////Enter Search Addr
    //    //[FindsBy(How = How.XPath, Using = "//*[@id='autocomplete0']")]
    //    //private IWebElement BSearchAddr { get; set; }
    //    ////Enter Number
    //    //[FindsBy(How = How.XPath, Using = "//*[@id='street_number']")]
    //    //private IWebElement BNumber { get; set; }
    //    ////Enter Street
    //    //[FindsBy(How = How.XPath, Using = "//*[@id='route']")]
    //    //private IWebElement BStreet { get; set; }
    //    ////Enter PostCode
    //    //[FindsBy(How = How.XPath, Using = "//*[@id='postal_code']")]
    //    //private IWebElement BPostCode { get; set; }
    //    ////Enter City
    //    //[FindsBy(How = How.XPath, Using = "//*[@id='locality']")]
    //    //private IWebElement BCity { get; set; }
    //    ////Enter Suburb
    //    //[FindsBy(How = How.XPath, Using = "//*[@id='sublocality_level_1']")]
    //    //private IWebElement BSuburb { get; set; }

    //    //public static bool IsAlphaNumeric(this string stringToTest)
    //    //{
    //    //    //English
    //    //    const string charSet = "a-zA-Z";
    //    //    const string numSet = @"0-9";

    //    // return Regex.Match(stringToTest, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success;
    //    //}

    //    //public static bool IsNumeric(this string stringToTest)
    //    //{
    //    //    //English
    //    //    const string numSet = @"0-9";

    //    //    return Regex.Match(stringToTest, @"^[" + numSet + @"]+$").Success;
    //    //}

    //    //public static bool IsAlpha(this string stringToTest)
    //    //{
    //    //    //English
    //    //    const string charSet = "a-zA-Z";

    //    //    return Regex.Match(stringToTest, @"^[" + charSet + @"]+$").Success;
    //    //}

    //    //Anu Updated Company
    //    internal void Add_New_ServiceSupplier()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        /****Clicking on Service Supplier tab****/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

    //        // Verifying Service Supplier page heading/
    //        Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //        Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Service Supplier Details");


    //        //Click on Add New Service Supplier/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        //Thread.Sleep(3000);

    //        try
    //        {

    //            //Verifying the Add Service Supplier Details heading/
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
    //            Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Add Service Supplier Details");

    //            /*****Enter ServiceSupplier Details*****/

    //            //Enter Name
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(3, "Name"));
    //            //Enter Website
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(3, "Website"));
    //            //Enter Phone Number
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(3, "Phone Number"));
    //            //Enter Physical Address-Number
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(3, "ANumber"));
    //            //Enter Physical Address-Street
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(3, "AStreet"));
    //            //Enter Physical Address-Post Code
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(3, "APostCode"));
    //            //Enter Physical Address-City
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(3, "ACity"));
    //            //Enter Physical Address-Suburb
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(3, "ASuburb"));

    //            /************Remove this once defect is fixed**********/
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"));
    //            /****************************************************************************************************/

    //            ////Enter Billing Address-Number
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(3, "ANumber"));
    //            ////Enter Billing Address-Street
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(3, "AStreet"));
    //            ////Enter Billing Address-Post Code
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"), ExcelLib.ReadData(3, "APostCode"));
    //            ////Enter Billing Address-City
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(3, "ACity"));
    //            ////Enter Billing Address-Suburb
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"), ExcelLib.ReadData(3, "ASuburb"));


    //            // Click on Save and Continue
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"));
    //            Thread.Sleep(2000);
    //            if (Driver.driver.FindElement(By.XPath("//*[@id='UploadLogoForCompany']/div/div")).Displayed == true)
    //           { //Click on the YES button on the popup
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"));
    //                Thread.Sleep(1000);
    //            }
    //            else
    //            {
    //                Base.test.Log(LogStatus.Fail, "Unable to locate popup");                     

    //            }
    //            //Verify the navigation to Upload Service Supplier Logo
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));
    //            Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Upload Service Supplier Logo");
    //            Thread.Sleep(3000);

    //            //Click on the Choose Files
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
    //            Thread.Sleep(3000);

    //            //Upload Photos
    //            AutoItX3 autoIT1 = new AutoItX3();
    //            autoIT1.WinActivate("Open");
    //            autoIT1.Send(ExcelLib.ReadData(RowCountBase, "Image path"));
    //            autoIT1.Send("{ENTER}");
    //            Thread.Sleep(3000);

    //            //Click on the Save button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value"));
    //            Thread.Sleep(2000);

    //            //Click on the Yes button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(36, "Locator"), ExcelLib.ReadData(36, "Value"));
    //            Thread.Sleep(2000);

    //            //Click on the OK button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(38, "Locator"), ExcelLib.ReadData(38, "Value"));
    //            Thread.Sleep(2000);
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Add new Service Supplier is successfull");
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + " Error");
    //        }

    //        /******************Validating Newly created record**************/
    //        /***Searching for a newly created record***/
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(3, "Name"));

    //        /***Click on the "Search" button***/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));


    //        bool found1 = false;
    //        IList compList1 = Driver.driver.FindElements(By.XPath("//*[@id='compList']/tr"));
    //        int compListCount1 = compList1.Count;
    //        try
    //        {
    //            for (int i = 1; i <= compListCount1 && found1 == false; i += 2)
    //            {
    //                if (ExcelLib.ReadData(3, "Name").Equals(Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text))
    //                {
    //                    found1 = true;
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Newly created record located successfully.");

    //                    /******Click on the Action button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //                    Thread.Sleep(3000);

    //                    /******Click on the Details button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
    //                    Thread.Sleep(3000);
    //                    String Expected_Website = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));
    //                    try
    //                    {
    //                        Assert.AreEqual(Expected_Website, ExcelLib.ReadData(3, "Website"));
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Verified Website Details");
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Website not equal for record: "+i);
    //                    }
    //                    String Expected_Contactnumber = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));
    //                    try
    //                    {
    //                        Assert.AreEqual(Expected_Contactnumber, ExcelLib.ReadData(3, "Phone Number"));
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Verified contact Details");
    //                    }
    //                    catch (Exception e)
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Phone Number not equal for record: "+ i);
    //                    }
    //                }
    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Issue");
    //        }
    //        if (found1 == false)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Can not locate newly created record.");
    //        }

    //    }

    //    internal void Cancel_Add_New_ServiceSupplier()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        /****Clicking on Service Supplier tab****/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

    //        // Verifying Service Supplier page heading/
    //        Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //        Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Service Supplier Details");


    //        //Click on Add New Service Supplier/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        //Thread.Sleep(3000);

    //        try
    //        {

    //            //Verifying the Add Service Supplier Details heading/
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
    //            Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Add Service Supplier Details");

    //            /*****Enter Company Details*****/

    //            //Enter Name
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
    //            //Enter Website
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(RowCountBase, "Website"));
    //            //Enter Phone Number
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "Phone Number"));
    //            //Enter Physical Address-Number
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));
    //            //Enter Physical Address-Street
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));
    //            //Enter Physical Address-Post Code
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));
    //            //Enter Physical Address-City
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
    //            //Enter Physical Address-Suburb
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ASuburb"));

    //            /************Remove this once defect is fixed**********/
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"));
    //            /****************************************************************************************************/

    //            ////Enter Billing Address-Number
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(3, "ANumber"));
    //            ////Enter Billing Address-Street
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(3, "AStreet"));
    //            ////Enter Billing Address-Post Code
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"), ExcelLib.ReadData(3, "APostCode"));
    //            ////Enter Billing Address-City
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(3, "ACity"));
    //            ////Enter Billing Address-Suburb
    //            //Driver.Textbox(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"), ExcelLib.ReadData(3, "ASuburb"));
    //            //Thread.Sleep(3000);

    //            // Click on cancel button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value"));
    //            Thread.Sleep(3000);
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(40, "Locator"), ExcelLib.ReadData(40, "Value"));
    //            // Verifying navigating to Service supplier index page/
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //            Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Service Supplier Details");
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + " Error");
    //        }

    //        /******************Validating Newly created record**************/
    //        /***Searching for a newly created record***/
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(5, "Name"));

    //        /***Click on the "Search" button***/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));


    //        bool found1 = false;
    //        IList compList1 = Driver.driver.FindElements(By.XPath("//*[@id='compList']/tr"));
    //        int compListCount1 = compList1.Count;
    //        try
    //        {
    //            for (int i = 1; i <= compListCount1 && found1 == false; i += 2)
    //            {
    //                if (ExcelLib.ReadData(3, "Name").Equals(Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text))
    //                {
    //                    found1 = true;
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Newly created record located successfully.");

    //                    /******Click on the Action button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //                    Thread.Sleep(3000);

    //                    /******Click on the Details button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
    //                    Thread.Sleep(3000);
    //                    String Expected_Website = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));
    //                    Assert.AreEqual(Expected_Website, ExcelLib.ReadData(5, "Website"));
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Verified Website Details");

    //                    String Expected_Contactnumber = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));
    //                    Assert.AreEqual(Expected_Contactnumber, ExcelLib.ReadData(5, "Phone Number"));
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Verified contac Details");
    //                }
    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Issue");
    //        }
    //        if (found1 == false)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Can not locate newly created record.");
    //        }


    //    }

    //    internal void Delete_ServiceSupplier()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        /****Clicking on  Service supplier****/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
    //        Thread.Sleep(3000);

    //        //Bool delete check
    //        //  bool Delete = false;
    //        //Retrieve tot PGnumber
    //        //Can work once Company Pagination is available Bug #748
    //        //  String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id=' ']/div[2]/div/div/ul/li[2]/a")).Text;
    //        //  int POSof = PageNumber.IndexOf("of") + 3;
    //        //  int endpos = PageNumber.IndexOf(".");
    //        //  int Totnum = Convert.ToInt32(PageNumber.Substring(POSof, endpos - POSof));
    //        ////  int Count = 1;
    //        //  //remove //Remove once Defect672 fix
    //        //  Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Totnum.ToString());
    //        /******************************************************/

    //        try
    //        {

    //            /***Searching for a company to Delete***/
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));

    //            /***Click on the "Search" button***/
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));

    //            IList compList = Driver.driver.FindElements(By.XPath("//*[@id='compList']/tr"));
    //            int compListCount = compList.Count;
    //            bool found = false;

    //            // count the row with no of rows

    //            for (int i = 1; i <= compListCount && found == false; i++)
    //            {
    //                if (ExcelLib.ReadData(RowCountBase, "Name").Equals(Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text))
    //                {
    //                    found = true;

    //                    //Handle Popup

    //                    string existingWindowHandle = Driver.driver.CurrentWindowHandle;
    //                    // Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr["+i+"]/td[2]/a[3]")).Click();

    //                    /******Click on the Action button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //                    Thread.Sleep(3000);

    //                    /*****Click on Delete button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));
    //                    Driver.wait(5);



    //                    //wait for new window to open 
    //                    Thread.Sleep(2000);

    //                    //get the current window handles 
    //                    string popupHandle = string.Empty;
    //                    ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

    //                    foreach (string handle in windowHandles)
    //                    {
    //                        if (handle != existingWindowHandle)
    //                        {
    //                            popupHandle = handle; break;
    //                        }
    //                    }

    //                    //switch to new window 
    //                    Driver.driver.SwitchTo().Window(popupHandle);
    //                    Thread.Sleep(3000);
    //                    // Driver.wait(5);

    //                    /********Click on the Delete button on the popup window ********/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(66, "Locator"), ExcelLib.ReadData(66, "Value"));
    //                    Thread.Sleep(2000);

    //                    //Click OK button on the confirmation window
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(68, "Locator"), ExcelLib.ReadData(68, "Value"));
    //                    //close the new window to navigate to the previous one
    //                    //driver.close();

    //                    //switch back to original window 
    //                    Driver.driver.SwitchTo().Window(existingWindowHandle);
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Able to Delete record");

    //                }
    //                //else
    //                //{
    //                //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "record not located");
    //                //}

    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + " Error");
    //        }
    //        Thread.Sleep(2000);

    //        /************Delete record Validation*************/
    //        bool found1 = false;
    //        IList compList1 = Driver.driver.FindElements(By.XPath("//*[@id='compList']/tr"));
    //        int compListCount1 = compList1.Count;
    //        try
    //        {
    //            for (int i = 1; i <= compListCount1 && found1 == false; i += 2)
    //            {
    //                if (ExcelLib.ReadData(3, "Name").Equals(Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text))
    //                {
    //                    found1 = true;
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Item not deleted");
    //                }

    //            }


    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Issue");
    //        }
    //        if (found1 == false)
    //        {

    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Item deleted");

    //        }
    //        else
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Item not deleted");
    //        }

    //    }


    //    internal void Edit_ServiceSupplier()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        // Defining a variable to assign the Company Name
    //        String Compname;

    //        /****Clicking on  Service supplier option****/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
    //        Thread.Sleep(3000);

    //        try
    //        {

    //            /***Searching for a service supplier to Edit***/
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(3, "Name"));
    //            Thread.Sleep(2000);
    //            /***Click on the "Search" button***/
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));

    //            /****Creating a list  for the search critearia******/
    //            IList complist = Driver.driver.FindElements(By.XPath(".//*[@id='compList']/tr"));
    //            int complistcount = complist.Count;
    //            Thread.Sleep(3000);

    //            for (int i = 1; i <= complistcount; i++)
    //            {

    //                //Assigning  Company name in the grid to a variable
    //                Compname = Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text;


    //                if (Compname == ExcelLib.ReadData(RowCountBase, "Name"))
    //                {

    //                    /******Click on the Action button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //                    Thread.Sleep(3000);

    //                    /**********Click on the EDIT option*************/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
    //                    Thread.Sleep(3000);

    //                    //Verifying the Add Service Supplier Details heading/
    //                    Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(58, "Locator"), ExcelLib.ReadData(58, "Value"));
    //                    Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Edit Service Supplier Details");


    //                    //Edit Company Website/
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(RowCountBase, "Website"));

    //                    //Edit Phone Number/
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"));
    //                    Thread.Sleep(2000);
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "Phone Number"));

    //                    //Edit physical Number/
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"));
    //                    Thread.Sleep(2000);
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));

    //                    //Edit Physical Street/
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"));
    //                    Thread.Sleep(2000);
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));

    //                    //Edit Physical Address-Post Code
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));
    //                    //Edit Physical Address-City
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"));
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
    //                    //Enter Physical Address-Suburb
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"));
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
    //                    Thread.Sleep(3000);
    //                    ///****Select billing address is same as the physical address******/
    //                    //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"));

    //                    ////Edit Billing Address-Number
    //                    //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"));
    //                    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"));
    //                    //Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(4, "ANumber"));
    //                    ////Enter Billing Address-Street
    //                    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));
    //                    //Driver.Textbox(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"), ExcelLib.ReadData(4, "AStreet"));
    //                    ////Enter Billing Address-Post Code
    //                    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"));
    //                    //Driver.Textbox(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"), ExcelLib.ReadData(4, "APostCode"));
    //                    ////Enter Billing Address-City
    //                    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"));
    //                    //Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(4, "ACity"));
    //                    ////Enter Billing Address-Suburb
    //                    //Driver.GetClear(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"));
    //                    //Driver.Textbox(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"), ExcelLib.ReadData(4, "ACity"));


    //                    ////Page down to locate "Save" button
    //                    //IWebElement element = Save;
    //                    //Actions actions = new Actions(Driver.driver);
    //                    //actions.MoveToElement(element);
    //                    //element.Click();
    //                    //Thread.Sleep(2000);
    //                    //actions.Perform();
    //                    //Thread.Sleep(2000);

    //                    //Click on the Choose Files
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(59, "Locator"), ExcelLib.ReadData(59, "Value"));

    //                    //Upload Photos
    //                    AutoItX3 autoIT = new AutoItX3();
    //                    autoIT.WinActivate("Open");
    //                    autoIT.Send(ExcelLib.ReadData(RowCountBase, "Image path"));
    //                    autoIT.Send("{ENTER}");
    //                    Thread.Sleep(3000);

    //                    //Click on the Upload image button
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(60, "Locator"), ExcelLib.ReadData(60, "Value"));
    //                    Thread.Sleep(2000);

    //                    //Click on the "Yes" button on the "Do You want to save the Logo"                     
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(63, "Locator"), ExcelLib.ReadData(63, "Value"));
    //                    Thread.Sleep(2000);

    //                    //Click on the "Save" button
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(61, "Locator"), ExcelLib.ReadData(61, "Value"));

    //                    ////Click on the "Yes" button on the " Do You want to save the changes?"
    //                    //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(46, "Locator"), ExcelLib.ReadData(46, "Value"));

    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record  updated, Test passed");

    //                }

    //                else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Record in else" + i);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e.Message + "Record not updated, Test Failed");
    //        }


    //    }
    //    internal void Edit_ServiceSupplier_DetailValidation()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        // Defining a variable to assign the Company Name
    //        String Compname;

    //        /*****Clicking on  Service supplier tab*****/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
    //        Thread.Sleep(3000);

    //        try
    //        {

    //            /***Searching for a service supplier to Edit***/
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
    //            Thread.Sleep(2000);
    //            /***Click on the "Search" button***/
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
    //            // Creating a list  for the search critearia 
    //            IList complist = Driver.driver.FindElements(By.XPath(".//*[@id='compList']/tr"));
    //            int complistcount = complist.Count;
    //            Thread.Sleep(3000);

    //            for (int i = 1; i <= complistcount; i++)
    //            {

    //                //Assigning the values of the Company name
    //                Compname = Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text;


    //                if (Compname == ExcelLib.ReadData(RowCountBase, "Name"))
    //                {

    //                    /******Click on the Action button****/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //                    Thread.Sleep(3000);

    //                    /**********Click on the details option*************/
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
    //                    Thread.Sleep(3000);

    //                    //String WebsiteName = Driver.driver.FindElement(By.XPath(".//*[@id='company-grid']/div[1]/div/div[2]/div/div[1]/div[3]/table/tbody/tr[1]/td")).Text;
    //                    String WebsiteName = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));
    //                    if (ExcelLib.ReadData(3, "Website") == WebsiteName)
    //                    {
    //                        //Verifying the updated record
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "test , Record has updated successfully");
    //                        //Thread.Sleep(2000);

    //                    }
    //                    else
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Test, Record has not updated sucessfully");
    //                    }

    //                }
    //                else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Name doesnot match with the Excel data" + i);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e.Message + "Record not updated, Test Failed");
    //        }
    //    }

            
    //    //Changes made by reshma

    //    internal void Add_ServiceSupplier_FieldValidation()
    //    {
    //        //TC_010_04
    //        //Check the fields are displayed
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        /****Clicking on Service Supplier tab****/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

    //        // Verifying Service Supplier page heading/
    //        Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //        Base.test.Log(LogStatus.Pass, "Navigate sucessfully to- Service Supplier Details");


    //        //Click on Add New Service Supplier/
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        //Thread.Sleep(3000);

    //        try
    //        {

    //            //Assert.IsTrue(CompanyName.Enabled);
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(14, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Company Name field is displayed, Pass");
    //            // Assert.IsTrue(CompanyWeb.Enabled);
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(15, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Company Website field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(16, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Phone Number field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(17, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Physical Search Address field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(18, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Physical Number field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(19, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Physical Street field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(20, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Physical Post Code field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(21, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Physical City field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(22, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Physical Suburb field is displayed, Pass");
    //            //Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(23, "Value"))).Enabled);
    //            //Base.test.Log(LogStatus.Pass, "Same billing Address, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(24, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Billing Search Address field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(25, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Billing Address Number field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Billing Address Street field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(27, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Billing Address Post Code field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(28, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Billing Address City field is displayed, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(29, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Billing Address Suburb field is displayed, Pass");
    //            Assert.IsFalse(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(30, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Save and Continue button is disabled on load, Pass");
    //            Assert.IsTrue(Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(39, "Value"))).Enabled);
    //            Base.test.Log(LogStatus.Pass, "Cancel button is displayed, Pass");

    //            //Base.test.Log(LogStatus.Info, "Physical Address Frame Validation");
    //            //Assert.IsTrue(SearchAddr.Enabled);
    //            //Base.test.Log(LogStatus.Pass, "Search Address field is displayed, Pass");
    //            //Assert.IsTrue(ANumber.Enabled);
    //            //Base.test.Log(LogStatus.Pass, " Address Number field is displayed, Pass");
    //            //Assert.IsTrue(AStreet.Enabled);
    //            //Base.test.Log(LogStatus.Pass, " Address Street field is displayed, Pass");
    //            //Assert.IsTrue(APostCode.Enabled);
    //            //Base.test.Log(LogStatus.Pass, " Address PostCode field is displayed, Pass");
    //            //Assert.IsTrue(ACity.Enabled);
    //            //Base.test.Log(LogStatus.Pass, " Address City field is displayed, Pass");
    //            //Assert.IsTrue(ASuburb.Enabled);
    //            //Base.test.Log(LogStatus.Pass, " Address Suburb field is displayed, Pass");
    //            //Assert.IsTrue(CheckShipSame.Enabled);
    //            //Base.test.Log(LogStatus.Pass, "Checkbox field is displayed, Pass");
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(LogStatus.Fail, "Fail");
    //            Base.test.Log(LogStatus.Info, e.Message + "Some Fields are not displayed. Please Check");
    //        }


    //    }


    //    //Need changes***************************************************
    //    internal void ServiceSupplier_InvalidDataValidation()
    //    {

    //        //TC_010_05
    //        //TC_010_15
    //        //TC_010_16
    //        //TC_010_17
    //        //TC_010_06

    //        /********Click Company tab************/
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        /****Clicking on  service supplier tab****/

    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
    //        Thread.Sleep(3000);

    //        //Click on the Add New Supplier button
    //        Thread.Sleep(1000);
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        //Driver.wait(1);
    //        Thread.Sleep(1000);

    //        //Validating Alphanumeric in Service supplier Details
    //        Driver.wait(3);
    //        string expectederr;
    //        //Service Supplier details
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value"), ExcelLib.ReadData(RowCountBase, "Name"));
    //        Driver.wait(2);
    //        //website
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(RowCountBase, "Website"));
    //        Driver.wait(2);
    //        //Physical Address
    //        ////SearchAddr.SendKeys(ExcelLib.ReadData(RowCountBase, "SearchAddr"));
    //        //Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(RowCountBase, "SearchAddr"));
    //        //Driver.wait(2);
    //        //ANumber.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "ANumber"));
    //        Driver.wait(2);

    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "AStreet"));
    //        Driver.wait(2);

    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"), ExcelLib.ReadData(RowCountBase, "APostCode"));
    //        Driver.wait(2);
    //        // ACity.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(RowCountBase, "ACity"));
    //        Driver.wait(2);
    //        //ASuburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(RowCountBase, "ASuburb"));
    //        Driver.wait(1);
    //        if (ExcelLib.ReadData(RowCountBase, "Checkbox") == "Yes")
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"));
    //        //Screenshot
    //        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Company Details 1");
    //        Driver.wait(1);
    //        String data = ExcelLib.ReadData(RowCountBase, "Name");
    //        //Company Name Validation
    //        if (String.IsNullOrWhiteSpace(data))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please enter a company name.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company Name Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");

    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Name");
    //            }
    //        }
    //        else if (data.Length < 4 || data.Length > 200)
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Name field must be alphanumeric and must be between 4-200 characters.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(14, "Locator"), ExcelLib.ReadData(14, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company Name Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");

    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Name");
    //            }
    //        }

    //        //Website Validation
    //        data = ExcelLib.ReadData(RowCountBase, "Website");

    //        //Need to Add Validation for http and domain
    //        if (String.IsNullOrWhiteSpace(data))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please enter a website address.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company Website Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Website Name");
    //            }
    //        }
    //        else
    //        {
    //            var searchFor = new List<string>();
    //            searchFor.Add("https://");
    //            searchFor.Add("www.");
    //            searchFor.Add(".com");

    //            if (searchFor.Any(x => data.ToLower().Contains(x)) == false)
    //            {
    //                submit = true;
    //                try
    //                {
    //                    expectederr = "Please enter a valid website address.";
    //                    Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value")));
    //                    Base.test.Log(LogStatus.Pass, "Company Website Error validation, Pass");
    //                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //                }
    //                catch (Exception e)
    //                {
    //                    Base.test.Log(LogStatus.Fail, "Fail");
    //                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Website Name");
    //                }
    //            }
    //        }
    //        //Physical Address

    //        //Search Address
    //        // SearchAddr.SendKeys(ExcelLib.ReadData(2, "SearchAddr"));

    //        // var regexItem = new Regex("^[a-zA-Z0-9]*$");
    //        const string charSet = "a-zA-Z";
    //        //   const string numSet = @"0-9";
    //        //Address Number
    //        //if (Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success || Regex.Match(txtnum, @"^[" + charSet + @"]+$").Success)
    //        //Regex rg = new Regex(@"^[-!$%^&*()_+|~=`{}\[\]:"; '<>?,.\/]*$");
    //        var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };

    //        //rg.IsMatch(txtnum) || Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
    //        string txtnum = ExcelLib.ReadData(RowCountBase, "ANumber");
    //        //doesnot validate if only chars
    //        if (String.IsNullOrWhiteSpace(txtnum))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your Number.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Number Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Number");
    //            }
    //        }
    //        else if (list.Any(txtnum.Contains))//|| !Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Number field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company Number Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Number");
    //            }

    //        }
    //        else
    //        {

    //            Base.test.Log(LogStatus.Pass, "Company Number Address validation, Pass");
    //        }
    //        //Address Street
    //        string txtstreet = ExcelLib.ReadData(2, "AStreet");
    //        if (String.IsNullOrWhiteSpace(txtstreet))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your Street.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Street Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Street");
    //            }
    //        }
    //        else if (list.Any(txtstreet.Contains))// || !Regex.Match(txtstreet, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
    //                                              //Regex.Match(txtstreet, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Street field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company Street Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Street");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company Street Address validation, Pass");
    //        }
    //        //Address City
    //        string txtcity = ExcelLib.ReadData(RowCountBase, "ACity");
    //        if (String.IsNullOrWhiteSpace(txtcity))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your City.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value")));
    //                Base.test.Log(LogStatus.Pass, "City Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address City");
    //            }
    //        }
    //        else if (list.Any(txtcity.Contains))//|| !Regex.Match(txtcity, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The City field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company City Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address City");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company City Address validation, Pass");
    //        }
    //        //Address Suburb
    //        string txtsub = ExcelLib.ReadData(RowCountBase, "ASuburb");
    //        if (list.Any(txtsub.Contains))// || !Regex.Match(txtsub, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Suburb field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company Suburb Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Suburb");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company Suburb Address validation, Pass");
    //        }
    //        //Address PostCode
    //        string txtpcode = ExcelLib.ReadData(RowCountBase, "APostCode");
    //        if (String.IsNullOrWhiteSpace(txtpcode))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your Post Code.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value")));
    //                Base.test.Log(LogStatus.Pass, "PostCode Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Post Code");
    //            }
    //        }
    //        else if (list.Any(txtpcode.Contains) || Regex.Match(txtpcode, @"^[" + charSet + @"]+$").Success)// || !Regex.Match(txtpcode, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Post Code field must be alphanumeric characters and must be between 1-10 characters.";
    //                Assert.AreEqual(expectederr, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(0, "Locator"), ExcelLib.ReadData(20, "Value")));
    //                Base.test.Log(LogStatus.Pass, "Company PostCode Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address PostCode");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company Address PostCode validation, Pass");
    //        }

    //        Base.test.Log(LogStatus.Pass, "Test Pass");

    //    }
    //    //Need changes***************************************************

    //    //Anu Code ends here

    //    #region Old Company Code
    //    internal void CompanyDelete()
    //    {
    //        //            //Click Company tab
    //        CompanyLink.Click();
    //        //Explicit Wait
    //        Thread.Sleep(500);
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");
    //        //Bool delete check
    //        //  bool Delete = false;
    //        //Retrieve tot PGnumber
    //        //Can work once Company Pagination is available Bug #748
    //        //  String PageNumber = Driver.driver.FindElement(By.XPath("//*[@id=' ']/div[2]/div/div/ul/li[2]/a")).Text;
    //        //  int POSof = PageNumber.IndexOf("of") + 3;
    //        //  int endpos = PageNumber.IndexOf(".");
    //        //  int Totnum = Convert.ToInt32(PageNumber.Substring(POSof, endpos - POSof));
    //        ////  int Count = 1;
    //        //  //remove //Remove once Defect672 fix
    //        //  Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Totnum.ToString());
    //        /******************************************************/

    //        IList compList = Driver.driver.FindElements(By.XPath("//*[@id='compList']/tr"));
    //        int compListCount = compList.Count;
    //        bool found = false;
    //        try
    //        {
    //            // Can count the row with no of rows

    //            //  for (int i = 1; i <= 10; i++)
    //            for (int i = 1; i <= compListCount && found==false; i += 2)
    //            {
    //                if (ExcelLib.ReadData(2, "Name").Equals(Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text))
    //                {
    //                    found = true;
    //                    //Click on DEtails to check the detail from excel...

    //                    //Click on Delete button
    //                  //  Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[1]/td[" + i+"]/button[3]")).Click();
    //                    Driver.wait(5);

    //                    //Handle Popup

    //                    string existingWindowHandle = Driver.driver.CurrentWindowHandle;
    //                   Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr["+i+"]/td[3]/button[3]")).Click();

    //                    //wait for new window to open 
    //                    Thread.Sleep(2000);

    //                    //get the current window handles 
    //                    string popupHandle = string.Empty;
    //                    ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

    //                    foreach (string handle in windowHandles)
    //                    {
    //                        if (handle != existingWindowHandle)
    //                        {
    //                            popupHandle = handle; break;
    //                        }
    //                    }

    //                    //switch to new window 
    //                   Driver.driver.SwitchTo().Window(popupHandle);
    //                    Driver.wait(5);
    //                    //check for element on new page 
    //                    Driver.driver.FindElement(By.XPath("//*[@id='removemodal']/div/div/div[3]/form/input")).Click();
                        
    //                    //close the new window to navigate to the previous one
    //                    //driver.close();

    //                    //switch back to original window 
    //                    Driver.driver.SwitchTo().Window(existingWindowHandle);
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Able to Delete record");

    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message +" Error");
    //        }
    //        Thread.Sleep(2000);
    //        //Validation
    //       bool found1 = false;
    //        IList compList1 = Driver.driver.FindElements(By.XPath("//*[@id='compList']/tr"));
    //        int compListCount1 = compList1.Count;
    //        try
    //        {
    //            for (int i = 1; i <= compListCount1 && found1 == false; i += 2)
    //            {
    //                if (ExcelLib.ReadData(2, "Name").Equals(Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text))
    //                {
    //                    found1 = true;
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Item not deleted");
    //                }

    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Issue");
    //        }
    //        if(found1==false)
    //        {
              

                   
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Item deleted");

                
    //        }

    //            }

    //    //anu//
    //    internal void Edit_Company()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        // Defining a variable to assign the Company Name
    //        String Compname;

    //        //Clicking on  Company tab
    //        CompanyLink.Click();
    //        Thread.Sleep(3000);

    //        try
    //        {
    //            // Searching for a company to Edit
    //            CompanySearch.SendKeys(ExcelLib.ReadData(6, "Name"));

    //            //Click on the "Search" button
    //            CompanySearchB.Click();

    //            // Creating a list  for the search critearia 
    //            IList complist = Driver.driver.FindElements(By.XPath(".//*[@id='compList']/tr"));
    //            int complistcount = complist.Count;
    //            Thread.Sleep(3000);

    //            for (int i = 1; i <= complistcount; i++)
    //            {

    //                //Assigning  Company name in the grid to a variable
    //                Compname = Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text;


    //                if (Compname == ExcelLib.ReadData(6, "Name"))
    //                {

    //                    //Click on the Edit button
    //                    CompanyEdit.Click();


    //                    // Edit Company Website 
    //                    CompanyWebsite.Click();
    //                    CompanyWebsite.Clear();
    //                    CompanyWebsite.SendKeys(ExcelLib.ReadData(6, "Website"));


    //                    //Edit Phone Number                
    //                    PhoneNumber.Click();
    //                    PhoneNumber.Clear();
    //                    PhoneNumber.SendKeys(ExcelLib.ReadData(6, "Phone Number"));


    //                    //Edit physical address
    //                    ANumber.Click();
    //                    ANumber.Clear();
    //                    ANumber.SendKeys(ExcelLib.ReadData(6, "ANumber"));

    //                    AStreet.Click();
    //                    AStreet.Clear();
    //                    AStreet.SendKeys(ExcelLib.ReadData(6, "AStreet"));

    //                    //Select billing address is same as the physical address
    //                    CheckShipSame.Click();

    //                    //Page down to locate "Save" button
    //                    IWebElement element = Save;
    //                    Actions actions = new Actions(Driver.driver);
    //                    actions.MoveToElement(element);
    //                    element.Click();
    //                    Thread.Sleep(2000);
    //                    actions.Perform();
    //                    Thread.Sleep(2000);


    //                }
    //                else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Record in else" + i);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e.Message + "Record not updated, Test Failed");
    //        }


    //    }
    //    internal void EditCompany_DetailValidation()
    //    {
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");

    //        // Defining a variable to assign the Company Name
    //        String Compname;

    //        //Clicking on  Company tab
    //        CompanyLink.Click();
    //        Thread.Sleep(3000);

    //        try
    //        {
    //            // Searching for a company to Edit
    //            CompanySearch.SendKeys(ExcelLib.ReadData(6, "Name"));

    //            //Click on the "Search" button
    //            CompanySearchB.Click();

    //            // Creating a list  for the search critearia 
    //            IList complist = Driver.driver.FindElements(By.XPath(".//*[@id='compList']/tr"));
    //            int complistcount = complist.Count;
    //            Thread.Sleep(3000);

    //            for (int i = 1; i <= complistcount; i++)
    //            {

    //                //Assigning the values of the Company name
    //                Compname = Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text;


    //                if (Compname == ExcelLib.ReadData(6, "Name"))
    //                {
    //                    //Click on the Detail button
    //                    CompanyDetail.Click();
    //                    String WebsiteName = Driver.driver.FindElement(By.XPath(".//*[@id='company-grid']/div[1]/div/div[2]/div/div[1]/div[3]/table/tbody/tr[1]/td")).Text;

    //                    if (ExcelLib.ReadData(6, "Website") == WebsiteName)
    //                    {
    //                        //Verifying the updated record
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "test , Record has updated successfully");
    //                        //Thread.Sleep(2000);

    //                    }
    //                    else
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Test, Record has not updated sucessfully");
    //                    }

    //                }
    //                else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Record in else" + i);
    //                }
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e.Message + "Record not updated, Test Failed");
    //        }
    //    }

    //    //anu ends//
    //    internal void CompanyMaxLength()
    //    {
    //        //TC_010_01

    //        //Click Company tab
    //        CompanyLink.Click();
    //        //Click AddNewCompany Button
    //        AddCompanyButton.Click();

    //    }
    //    internal void CompanyPopupValidation()
    //    {
    //        //TC_010_01

    //        //Click Company tab
    //        CompanyLink.Click();
    //        //Click AddNewCompany Button
    //        AddCompanyButton.Click();
    //        Driver.wait(5);
    //        String ExpectedTxt;
    //        //Verify the header
    //        ExpectedTxt = "ADD NEW COMPANY";
    //        //Driver.wait(5);
    //        bool b = AddCompanyHeader.Text.ToUpper().Contains(ExpectedTxt);
    //        try
    //        {
    //            Assert.IsTrue(AddCompanyHeader.Enabled);
    //          // Assert.IsTrue (b);
    //          // Assert.AreSame(ExpectedTxt, AddCompanyHeader.Text);
    //            Base.test.Log(LogStatus.Pass, "TC_010_01: Navigation and Add Company Header validation, Pass");
    //            Base.test.Log(LogStatus.Info, "Expected Header: '" + ExpectedTxt + " ' is displayed");
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(LogStatus.Fail, "Fail");
    //            Base.test.Log(LogStatus.Info, e.Message + ">> No Add New Company Popup");
    //        }
    //        Driver.wait(1);
    //        //Screenshot
    //        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Company Popup Validation");


    //    }
    //    internal void AddCompanyFieldValidation()
    //    {
    //        //TC_010_04


    //        //Check the fields are displayed
    //        Driver.wait(1);
    //        try
    //        {
    //            CompanyName.Click();
    //            Assert.IsTrue(CompanyName.Enabled);
    //            Base.test.Log(LogStatus.Pass, "Company Name field is displayed, Pass");
    //            Assert.IsTrue(CompanyWeb.Enabled);
    //            Base.test.Log(LogStatus.Pass, "Company Website field is displayed, Pass");
    //            Base.test.Log(LogStatus.Info, "Physical Address Frame Validation");
    //            Assert.IsTrue(SearchAddr.Enabled);
    //            Base.test.Log(LogStatus.Pass, "Search Address field is displayed, Pass");
    //            Assert.IsTrue(ANumber.Enabled);
    //            Base.test.Log(LogStatus.Pass, " Address Number field is displayed, Pass");
    //            Assert.IsTrue(AStreet.Enabled);
    //            Base.test.Log(LogStatus.Pass, " Address Street field is displayed, Pass");
    //            Assert.IsTrue(APostCode.Enabled);
    //            Base.test.Log(LogStatus.Pass, " Address PostCode field is displayed, Pass");
    //            Assert.IsTrue(ACity.Enabled);
    //            Base.test.Log(LogStatus.Pass, " Address City field is displayed, Pass");
    //            Assert.IsTrue(ASuburb.Enabled);
    //            Base.test.Log(LogStatus.Pass, " Address Suburb field is displayed, Pass");
    //            Assert.IsTrue(CheckShipSame.Enabled);
    //            Base.test.Log(LogStatus.Pass, "Checkbox field is displayed, Pass");
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(LogStatus.Fail, "Fail");
    //            Base.test.Log(LogStatus.Info, e.Message + "Some Fields are not displayed. Please Check");
    //        }


    //    }
    //    internal void CompanyInvalidDataValidation()
    //    {

    //        //            TC_010_05
    //        //TC_010_15
    //        //TC_010_16
    //        //TC_010_17
    //        //TC_010_06
            
    //        //            //Click Company tab
    //        CompanyLink.Click();
    //        //Explicit Wait
    //        Thread.Sleep(500);
    //        // Populating the data from Excel
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");
    //        AddCompanyButton.Click();
    //        //Validating Alphanumeric in property Details
    //        Driver.wait(3);
    //        string expectederr;
    //        //Property Brief Info
    //        CompanyName.SendKeys(ExcelLib.ReadData(RowCountBase, "Name"));
    //        Driver.wait(2);
    //        CompanyWeb.SendKeys(ExcelLib.ReadData(RowCountBase, "Website"));
    //        Driver.wait(2);
    //        //Physical Address
    //        SearchAddr.SendKeys(ExcelLib.ReadData(RowCountBase, "SearchAddr"));
    //        Driver.wait(2);
    //        ANumber.SendKeys(ExcelLib.ReadData(RowCountBase, "ANumber"));
    //        Driver.wait(2);
    //        AStreet.SendKeys(ExcelLib.ReadData(RowCountBase, "AStreet"));
    //        Driver.wait(2);
    //        APostCode.SendKeys(ExcelLib.ReadData(RowCountBase, "APostCode"));
    //        Driver.wait(2);
    //        ACity.SendKeys(ExcelLib.ReadData(RowCountBase, "ACity"));
    //        Driver.wait(2);
    //        ASuburb.SendKeys(ExcelLib.ReadData(RowCountBase, "ASuburb"));
    //        Driver.wait(1);
    //        if (ExcelLib.ReadData(RowCountBase, "Checkbox") == "Yes")
    //            CheckShipSame.Click();
    //        //Screenshot
    //        SaveScreenShotClass.SaveScreenshot(Driver.driver, "Company Details 1");
    //        Driver.wait(1);
    //        String data = ExcelLib.ReadData(RowCountBase, "Name");
    //        //Company Name Validation
    //        if (String.IsNullOrWhiteSpace(data))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please enter a company name.";
    //                Assert.AreEqual(expectederr, CompanyNameErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company Name Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");

    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Name");
    //            }
    //        }
    //        else if (data.Length <4 || data.Length >200)
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Name field must be alphanumeric and must be between 4-200 characters.";
    //                Assert.AreEqual(expectederr, CompanyNameErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company Name Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");

    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Name");
    //            }
    //        }

    //        //Website Validation
    //        data = ExcelLib.ReadData(RowCountBase, "Website");
            
    //        //Need to Add Validation for http and domain
    //        if (String.IsNullOrWhiteSpace(data))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please enter a website address.";
    //                Assert.AreEqual(expectederr, CompanyWebErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company Website Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Website Name");
    //            }
    //        }
    //        else
    //        {
    //            var searchFor = new List<string>();
    //            searchFor.Add("https://");
    //            searchFor.Add("www.");
    //            searchFor.Add(".com");

    //            if (searchFor.Any(x => data.ToLower().Contains(x)) == false)
    //            {
    //                submit = true;
    //                try
    //                {
    //                    expectederr = "Please enter a valid website address.";
    //                    Assert.AreEqual(expectederr, CompanyWebErr.Text);
    //                    Base.test.Log(LogStatus.Pass, "Company Website Error validation, Pass");
    //                    Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //                }
    //                catch (Exception e)
    //                {
    //                    Base.test.Log(LogStatus.Fail, "Fail");
    //                    Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Website Name");
    //                }
    //            }
    //        }
    //        //Physical Address

    //        //Search Address
    //       // SearchAddr.SendKeys(ExcelLib.ReadData(2, "SearchAddr"));
            
    //       // var regexItem = new Regex("^[a-zA-Z0-9]*$");
    //        const string charSet = "a-zA-Z";
    //        //   const string numSet = @"0-9";
    //        //Address Number
    //        //if (Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success || Regex.Match(txtnum, @"^[" + charSet + @"]+$").Success)
    //        //Regex rg = new Regex(@"^[-!$%^&*()_+|~=`{}\[\]:"; '<>?,.\/]*$");
    //        var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };

    //        //rg.IsMatch(txtnum) || Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
    //        string txtnum = ExcelLib.ReadData(RowCountBase, "ANumber");
    //        //doesnot validate if only chars
    //        if (String.IsNullOrWhiteSpace(txtnum))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your Number.";
    //                Assert.AreEqual(expectederr, ANumberErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Number Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Number");
    //            }
    //        }
    //      else  if (list.Any(txtnum.Contains)  )//|| !Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
              
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Number field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, ANumberErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company Number Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Number");
    //            }

    //        }
    //        else {
                
    //            Base.test.Log(LogStatus.Pass, "Company Number Address validation, Pass");
    //           }
    //        //Address Street
    //        string txtstreet = ExcelLib.ReadData(2, "AStreet"); 
    //        if (String.IsNullOrWhiteSpace(txtstreet))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your Street.";
    //                Assert.AreEqual(expectederr, AStreetErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Street Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Street");
    //            }
    //        }
    //        else if (list.Any(txtstreet.Contains))// || !Regex.Match(txtstreet, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
    //            //Regex.Match(txtstreet, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Street field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, AStreetErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company Street Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Street");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company Street Address validation, Pass");
    //          }
    //        //Address City
    //        string txtcity = ExcelLib.ReadData(RowCountBase, "ACity");
    //        if (String.IsNullOrWhiteSpace(txtcity))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your City.";
    //                Assert.AreEqual(expectederr, ACityErr.Text);
    //                Base.test.Log(LogStatus.Pass, "City Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address City");
    //            }
    //        }
    //        else if (list.Any(txtcity.Contains) )//|| !Regex.Match(txtcity, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The City field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, ACityErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company City Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address City");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company City Address validation, Pass");
    //        }
    //        //Address Suburb
    //        string txtsub = ExcelLib.ReadData(RowCountBase, "ASuburb");
    //         if (list.Any(txtsub.Contains))// || !Regex.Match(txtsub, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Suburb field must be alphanumeric characters.";
    //                Assert.AreEqual(expectederr, ACityErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company Suburb Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Suburb");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company Suburb Address validation, Pass");
    //        }
    //        //Address PostCode
    //        string txtpcode = ExcelLib.ReadData(RowCountBase, "APostCode");
    //        if (String.IsNullOrWhiteSpace(txtpcode))
    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "Please include your Post Code.";
    //                Assert.AreEqual(expectederr, ACityErr.Text);
    //                Base.test.Log(LogStatus.Pass, "PostCode Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address Post Code");
    //            }
    //        }
    //        else if (list.Any(txtpcode.Contains) || Regex.Match(txtpcode, @"^[" + charSet + @"]+$").Success)// || !Regex.Match(txtpcode, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

    //        {
    //            submit = true;
    //            try
    //            {
    //                expectederr = "The Post Code field must be alphanumeric characters and must be between 1-10 characters.";
    //                Assert.AreEqual(expectederr, APostCodeErr.Text);
    //                Base.test.Log(LogStatus.Pass, "Company PostCode Address Error validation, Pass");
    //                Base.test.Log(LogStatus.Info, "Expected err: '" + expectederr + " ' is displayed");
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //                Base.test.Log(LogStatus.Info, e.Message + ">> No error message for invalid Company Address PostCode");
    //            }

    //        }
    //        else
    //        {
    //            Base.test.Log(LogStatus.Pass, "Company Address PostCode validation, Pass");
    //        }

    //        Base.test.Log(LogStatus.Pass, "Test Pass");

    //    }
    //    internal void CompanySubmitValidation()
    //    {
    //        //Refer Excel Company Sheet
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Company");
    //        //Check the bool Submit, if true there are invalid data
    //        if (submit == true)
    //        {
    //            Base.test.Log(LogStatus.Info, " There are error message for invalid Company Data");
    //            Base.test.Log(LogStatus.Info, "  To Check the Submit button is disable");
    //            if (Submit.Enabled == true)
    //            {
    //                Base.test.Log(LogStatus.Info, "  Submit button is enabled");
    //                Base.test.Log(LogStatus.Fail, "Fail");
    //            }
    //            //Screenshot
    //            SaveScreenShotClass.SaveScreenshot(Driver.driver, " Submit button is disabled");
    //        }
    //        else
    //        {
    //            if (Submit.Enabled == true)
    //            {
    //                Base.test.Log(LogStatus.Info, "  Submit button is enabled");
    //                Submit.Click();
    //                Base.test.Log(LogStatus.Pass, "Pass");
    //                //Screenshot
    //                SaveScreenShotClass.SaveScreenshot(Driver.driver, " Submit button Click successful");
    //                //Check the new Company is added
    //                //Can be tested once pagination of Company is done.
    //                CompanyLink.Click();
    //               // bool Delete;
    //                //Search the excel data in the grid
    //                //try
    //                //{
    //                //    int j = 0;
    //                //    do
    //                //    {
    //                //        for (int i = 1; i <= 10; i++)
    //                //        {
    //                //            if (ExcelLib.ReadData(2, "Name") == Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[1]")).Text)
    //                //            {
                                   
    //                //                    //Click on Details Page
    //                //                    Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[ "+ i + "]/ td[3]/button[1]")).Click();
    //                //                    //Verify the Address 
    //                //                    if (Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr["+(i+j)+"]/td[2]/div/div/span[1]")).Text == ExcelLib.ReadData(2, "ANumber"))
    //                //                {
    //                //                        //Screenshot
    //                //                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Cancel Delete Property");
    //                //                        //Click Delete button
    //                //                        Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + i + "]/td[3]/a[3]")).Click();
    //                //                        //Implicit Wait
    //                //                        //  new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(Convert.ToDouble(20))).Until(ExpectedConditions.ElementIsVisible((By.XPath("//*[@id='removeModal']/div/div"))));
    //                //                        Thread.Sleep(500);

    //                //                        //Click Cancel on confirmation page                              

    //                //                        Driver.driver.FindElement(By.XPath("//*[@id='removeModal']/div/div/div[3]/form/button")).Click();
    //                //                        Delete = false;
    //                //                        //Log Info
    //                //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Property Cancelled");
    //                //                        break;

    //                //                    }
    //                //                    else
    //                //                    {
    //                //                        if (Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[1]/table/tbody/tr[1]/th")).Displayed)
    //                //                        {
    //                //                            //Click on Back button
    //                //                            Driver.driver.FindElement(By.XPath("//*[@id='property-grid']/div[1]/div/div[4]/button")).Click();
    //                //                        }
    //                //                    }

    //                //                j = j + 1;


    //                //            }
    //                //        }
    //                //        Thread.Sleep(500);
    //                //        if (Page.Enabled && Delete == true)
    //                //        {
    //                //            Page.Click();
    //                //            Thread.Sleep(500);
    //                //        }
    //                //        Count++;
    //                //        //Check Next Pg button
    //                //    } while (Page.Enabled && Delete == true && Count <= Totnum);
    //                //}
    //                //catch (Exception e)
    //                //{
    //                //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "Pagination issue, \n Please check");
    //                //}
    //            }
    //            //Screenshot
    //           // SaveScreenShotClass.SaveScreenshot(Driver.driver, " Submit button is disabled");
    //        }
    //    }

    //    #endregion 
    //}
    #endregion


}
