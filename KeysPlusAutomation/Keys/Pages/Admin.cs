using Keys.Global;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using static NUnit.Core.NUnitFramework;

namespace Keys.Pages
{
    class Admin
    {
        internal Admin()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        //search field
        [FindsBy(How = How.XPath, Using = ".//*[@id='SearchString']")]
        IWebElement searchfield { set; get; }

        //search button
        [FindsBy(How = How.XPath, Using = "html/body/div[1]/div/div[2]/form/div/span/button")]
        IWebElement searchbutton { set; get; }

        //save  button
        [FindsBy(How = How.XPath, Using = ".//*[@id='userEdit']/div[3]/button[2]")]
        IWebElement savebutton { set; get; }

        //first name
        [FindsBy(How = How.CssSelector, Using = "#userDetails-firstName")]
        IWebElement firstname { set; get; }

        //Middle name
        [FindsBy(How = How.XPath, Using = ".//*[@id='userDetails-middleName']")]
        IWebElement middlename { set; get; }

        //last name
        [FindsBy(How = How.XPath, Using = ".//*[@id='userDetails-lastName']")]
        IWebElement lastname { set; get; }

        //language
        [FindsBy(How = How.XPath, Using = ".//*[@id='userDetails-language']")]
        IWebElement language { set; get; }

        //Place of birth
        [FindsBy(How = How.XPath, Using = ".//*[@id='userDetails-placeOfBirth']")]
        IWebElement placeofbirth { set; get; }

        //physical address number
        [FindsBy(How = How.XPath, Using = ".//*[@id='street_number']")]
        IWebElement pnumber { set; get; }

        //physical address street
        [FindsBy(How = How.XPath, Using = ".//*[@id='route']")]
        IWebElement pstreet { set; get; }

        //physical post code
        [FindsBy(How = How.XPath, Using = ".//*[@id='postal_code']")]
        IWebElement ppostcode { set; get; }

        //physical address city
        [FindsBy(How = How.XPath, Using = ".//*[@id='locality']")]
        IWebElement pcity { set; get; }

        //physical address suburb
        [FindsBy(How = How.XPath, Using = ".//*[@id='sublocality_level_1']")]
        IWebElement psuburb { set; get; }

        public void Adminpage()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Admin");

            //Verifying admin page

            //clicking on admin tab
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
            Thread.Sleep(1000);
            string adminpage = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));
            //string adminpage = Driver.driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/h3")).Text;
            string admin = "Admin";
            Thread.Sleep(2000);
            try
            {

                if (adminpage == admin)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Admin page loaded");

                }

            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Admin page not loaded" + e.Message);
            }

        }

        public void adminedit()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Admin");

            //searching a user

            //sending value in search bar
            //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "FirstName"));
            Thread.Sleep(1000);
            //searchfield.SendKeys(ExcelLib.ReadData(2, "First Name"));
            //searchbutton.Click();

            //clicking search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));

            //checking if the user is present
            IList users = Driver.driver.FindElements(By.XPath(".//*[@id='listUserTable']/tbody/tr"));
            int userscount = users.Count;
            string fname;
            string mname;
            string lname;
            for (int i = 1; i <= userscount; i++)
            {
                fname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[1]")).Text;
                mname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[2]")).Text;
                lname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[3]")).Text;
                try
                {
                    if (fname == ExcelLib.ReadData(2, "FirstName") && mname == ExcelLib.ReadData(2, "Middle Name") && lname == ExcelLib.ReadData(2, "Last Name"))
                    {
                        //string existingWindowHandle = Driver.driver.CurrentWindowHandle;
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[4]/button[2]")).Click();
                        Thread.Sleep(2000);

                        //string editwindow = Driver.driver.FindElement(By.XPath(".//*[@id='userEdit']/div[1]/h4")).Text;
                        //string firstname1 = Driver.driver.FindElement(By.XPath(".//*[@id='userEdit']/div[2]/form/div[1]/div[2]/label")).Text;

                        string editwindow = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
                        Thread.Sleep(1000);

                        if (editwindow == "Edit User")
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edit User pop-up is opened successfully");
                        }

                        else
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Edit user pop-up is not opened.");
                        }

                        //get the current window handles

                        //string popupHandle = string.Empty;
                        //ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

                        //foreach (string handle in windowHandles)
                        //{
                        //    if (handle != existingWindowHandle)
                        //    {
                        //        popupHandle = handle; break;
                        //    }
                        //}

                        //switch to new window
                        //Driver.driver.SwitchTo().Window(popupHandle);

                        //Driver.driver.FindElement(By.Id("userDetails-firstName")).Click();
                        //Driver.driver.FindElement(By.Id("userDetails-firstName")).Clear();
                        //Driver.driver.FindElement(By.Id("userDetails-firstName")).SendKeys(ExcelLib.ReadData(2, "New First Name"));

                        //editing fields
                        //Thread.Sleep(2000);
                        //string firstname = Driver.driver.FindElement(By.XPath(".//*[@id='userEdit']/div[2]/form/div[1]/div[2]/label")).Text;

                        //IJavaScriptExecutor jse = (IJavaScriptExecutor)Driver.driver;
                        //jse.ExecuteScript("arguments[0].setAttribute('value', 'new')", firstname);

                        //first name
                        Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "New First Name"));
                        //Driver.driver.SwitchTo().ActiveElement().FindElement(By.XPath(".//*[@id='userEdit']/div[1]/h4")).Click();
                        //Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);
                        //Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).Click();
                        //Thread.Sleep(1000);
                        //Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).Clear();
                        //Thread.Sleep(1000);
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).SendKeys(ExcelLib.ReadData(2, "New First Name"));
                        Thread.Sleep(1000);

                        //Tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //middle name

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-middleName")).Click();
                        Thread.Sleep(1000);
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-middleName")).Clear();
                        Thread.Sleep(1000);

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-middleName")).SendKeys(ExcelLib.ReadData(2, "New Middle Name"));

                        //Tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-middleName")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //last name

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-lastName")).SendKeys(ExcelLib.ReadData(2, "New Last Name"));
                        Thread.Sleep(2000);

                        //Tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-lastName")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //language
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-language")).Clear();
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-language")).SendKeys(ExcelLib.ReadData(2, "Language"));
                        Thread.Sleep(500);
                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-language")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //place of birth
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-placeOfBirth")).Clear();
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-placeOfBirth")).SendKeys(ExcelLib.ReadData(2, "Place of Birth"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-placeOfBirth")).SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);

                        //Number1

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("street_number")).SendKeys(ExcelLib.ReadData(2, "Number1"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("street_number")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //Street1

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("route")).SendKeys(ExcelLib.ReadData(2, "Street1"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("route")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //post code1

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("postal_code")).SendKeys(ExcelLib.ReadData(2, "Post Code1"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("postal_code")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        Thread.Sleep(500);

                        //city1

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("locality")).SendKeys(ExcelLib.ReadData(2, "City1"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("locality")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //suburb1
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("sublocality_level_1")).Clear();
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("sublocality_level_1")).SendKeys(ExcelLib.ReadData(2, "Suburb1"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("sublocality_level_1")).SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);

                        //Number2

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("street_number")).SendKeys(ExcelLib.ReadData(2, "Number2"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("street_number")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //Street2

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("route")).SendKeys(ExcelLib.ReadData(2, "Street2"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("route")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //post code2

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("postal_code")).SendKeys(ExcelLib.ReadData(2, "Post Code2"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("postal_code")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //city2

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("locality")).SendKeys(ExcelLib.ReadData(2, "City2"));
                        Thread.Sleep(500);

                        //tab out
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("locality")).SendKeys(OpenQA.Selenium.Keys.Tab);

                        //suburb2
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("sublocality_level_1")).Clear();
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("sublocality_level_1")).SendKeys(ExcelLib.ReadData(2, "Suburb2"));
                        Thread.Sleep(500);

                        //save 
                        savebutton.Click();
                        Thread.Sleep(2000);

                        break;

                        //jse.executeScript("document.getElementById('gbqfq').value = 'Ripon Al Wasim';");

                    }
                }

                catch (Exception e1)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e1.Message);
                }
            }

            //searching user
            searchfield.Click();
            Thread.Sleep(500);
            searchfield.Clear();
            Thread.Sleep(500);
            searchfield.SendKeys(ExcelLib.ReadData(2, "tffjfg"));
            Thread.Sleep(500);
            //search button
            searchbutton.Click();
            Thread.Sleep(500);

            //checking if the user is present
            IList users2 = Driver.driver.FindElements(By.XPath("html/body/div[1]/div/div[2]/table/tbody/tr/td"));
            int userscount2 = users2.Count;
            string newfname;
            //string newmname;
            string newlname;
            string firstname;
            string middlename;
            string lastname;
            string language;
            string placeofbirth;
            string pnumber;
            string pstreet;
            string ppostcode;
            string pcity;
            string psuburb;
            //string bnumber;
            //string bstreet;
            //string bpostcode;
            //string bcity;
            //string bsuburb;

            for (int j = 1; j <= userscount2; j++)
            {
                newfname = Driver.driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/table/tbody/tr[" + j + "]/td[1]")).Text;
                //mname = Driver.driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/table/tbody/tr["+ i +"]/td[2]")).Text;
                newlname = Driver.driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/table/tbody/tr[" + j + "]/td[3]")).Text;
                try
                {
                    if (newfname == ExcelLib.ReadData(2, "tffjfg") && newlname == ExcelLib.ReadData(2, "New Last Name"))
                    {
                        Driver.driver.FindElement(By.XPath("html/body/div[1]/div/div[2]/table/tbody/tr[" + j + "]/td[4]/button[1]")).Click();

                        //Driver.driver.SwitchTo().ActiveElement().FindElement(By.XPath(".//*[@id='userDetails']/div/div[1]/button")).SendKeys(OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab + OpenQA.Selenium.Keys.Tab);
                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-userName")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        //Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).Click();
                        firstname = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-firstName")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        middlename = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-middleName")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-middleName")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        lastname = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-lastName")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-lastName")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        language = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-language")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-language")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        placeofbirth = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-placeOfBirth")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("userDetails-placeOfBirth")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        pnumber = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-number")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-number")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        pstreet = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-street")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-street")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        ppostcode = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-postCode")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-postCode")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        pcity = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-city")).Text;

                        Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-city")).SendKeys(OpenQA.Selenium.Keys.Tab);
                        psuburb = Driver.driver.SwitchTo().ActiveElement().FindElement(By.Id("readAddress-suburb")).Text;

                        if (firstname == ExcelLib.ReadData(2, "tffjfg") && middlename == ExcelLib.ReadData(2, "New Middle Name") &&
                            lastname == ExcelLib.ReadData(2, "New Last Name") && language == ExcelLib.ReadData(2, "Language") &&
                            placeofbirth == ExcelLib.ReadData(2, "Place of Birth") && pnumber == ExcelLib.ReadData(2, "Number1") &&
                            pstreet == ExcelLib.ReadData(2, "Street1") && ppostcode == ExcelLib.ReadData(2, "Post Code1") &&
                            pcity == ExcelLib.ReadData(2, "City1") && psuburb == ExcelLib.ReadData(2, "Suburb1"))
                        {
                            //close button
                            Driver.driver.FindElement(By.XPath(".//*[@id='userDetails']/div/div[3]/button")).Click();


                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The user details are edited");
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, e.Message);
                }


            }

        }

        public void admindelete()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Admin");

            //searching a user

            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(4, "FirstName"));
            Thread.Sleep(1000);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
            //searchfield.SendKeys(ExcelLib.ReadData(3, "First Name"));
            //searchbutton.Click();

            //checking if the user is present
            IList users = Driver.driver.FindElements(By.XPath(".//*[@id='listUserTable']/tbody/tr"));
            int userscount = users.Count;
            string fname;
            string mname;
            string lname;

            for (int i = 1; i <= userscount; i++)

            {
                fname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[1]")).Text;
                mname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[2]")).Text;
                lname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[3]")).Text;
                try
                {
                    if (fname == ExcelLib.ReadData(4, "FirstName") && mname == ExcelLib.ReadData(4, "Middle Name") && lname == ExcelLib.ReadData(4, "Last Name"))
                    {
                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record is searched successfully");
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[4]/div/button")).Click();
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[4]/div/ul/li[5]/a")).Click();
                        Thread.Sleep(500);
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value"));
                        Thread.Sleep(1000);
                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(38, "Locator"), ExcelLib.ReadData(38, "Value"));
                        //Driver.driver.FindElement(By.XPath(".//*[@id='userDelete']/div/div[3]/button[1]")).Click();
                        break;
                    }
                }
                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e.Message);
                }
            }

            //checking if the user is deleted

            //clicking on admin tab
            Thread.Sleep(2000);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
            Thread.Sleep(2000);

            //searching
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(4, "FirstName"));
            Thread.Sleep(500);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));

            string deletetext1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(36, "Locator"), ExcelLib.ReadData(36, "Value"));
            //string deletetext2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value"));
            try
            {
                if (deletetext1 == "No records found for:")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record deleted successfully");
                }
                else
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record not deleted");
                }

            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e.Message);
            }

            //IList users2 = Driver.driver.FindElements(By.XPath(".//*[@id='listUserTable']/tbody/tr"));
            //int userscount2 = users.Count;
            //string fname2;
            //string mname2;
            //string lname2;

            //for (int j = 1; j <= userscount; j++)
            //{
            //    fname2 = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[1]")).Text;
            //    mname2 = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[2]")).Text;
            //    lname2 = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[3]")).Text;

            //    try
            //    {
            //        if (fname2 != ExcelLib.ReadData(4, "FirstName") && mname2 != ExcelLib.ReadData(4, "Middle Name") && lname2 != ExcelLib.ReadData(4, "Last Name"))
            //        {
            //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "User is deleted successfully");
            //            break;
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "User is not deleted" + e.Message);
            //    }
            //}

        }

        public void adminedit2()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Admin");

            //searching a user

            //sending value in search bar
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "FirstName"));
            Thread.Sleep(1000);

            //clicking search button
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));

            //checking if the user is present
            IList users = Driver.driver.FindElements(By.XPath(".//*[@id='listUserTable']/tbody/tr"));
            int userscount = users.Count;
            string fname;
            string mname;
            string lname;
            for (int i = 1; i <= userscount; i++)
            {
                fname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[1]")).Text;
                mname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[2]")).Text;
                lname = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[3]")).Text;
                try
                {
                    if (fname == ExcelLib.ReadData(2, "FirstName") && mname == ExcelLib.ReadData(2, "Middle Name") && lname == ExcelLib.ReadData(2, "Last Name"))
                    {
                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record searched successfully");

                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[4]/div/button")).Click();

                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + i + "]/td[4]/div/ul/li[3]/a")).Click();
                        Thread.Sleep(2000);

                        string editwindow = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
                        Thread.Sleep(1000);

                        if (editwindow == "Edit User")
                        {
                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edit User pop-up is opened successfully");

                            //first name
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "NewFirstName"));

                            //Middle Name
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(2, "NewMiddleName"));

                            //Last Name
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(2, "NewLastName"));

                            //Language
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(2, "Language"));

                            //Place of birth
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"), ExcelLib.ReadData(2, "Place of Birth"));

                            //Physical Address
                            //Number
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(2, "Number1"));

                            //Street
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(2, "Street1"));

                            //PostCode
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"), ExcelLib.ReadData(2, "Post Code1"));

                            //City
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(2, "City1"));

                            //Suburb
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(2, "Suburb1"));
                            Thread.Sleep(2000);


                            //Billing Address
                            //Number
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(2, "Number2"));

                            //Street
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(2, "Street2"));

                            //PostCode
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"), ExcelLib.ReadData(2, "Post Code2"));

                            //City
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(2, "City2"));

                            //Suburb
                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(2, "Suburb2"));

                            Thread.Sleep(2000);

                            //save
                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"));
                            Thread.Sleep(1000);
                            //refreshing page
                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
                            break;


                        }
                    }

                    else
                    {
                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Similar record found");
                    }
                }


                catch (Exception e)
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e.Message);
                }
            }

            //validation of edited record

            //searching the edited record
            Thread.Sleep(2000);
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"), ExcelLib.ReadData(2, "NewFirstName"));
            Thread.Sleep(2000);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));

            Thread.Sleep(2000);

            IList users2 = Driver.driver.FindElements(By.XPath(".//*[@id='listUserTable']/tbody/tr"));
            int userscount2 = users2.Count;
            string fnameedit;
            //string mname2;
            string lnameedit;
            string email;

            string fullname = ExcelLib.ReadData(2, "NewFirstName") + " " +
                             ExcelLib.ReadData(2, "NewMiddleName") + " " +
                             ExcelLib.ReadData(2, "NewLastName");
            string fullnametext;

            for (int j = 1; j <= userscount2; j++)
            {
                fnameedit = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[1]")).Text;
                //mname2 = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[2]")).Text;
                lnameedit = Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[3]")).Text;

                if (fnameedit == ExcelLib.ReadData(2, "NewFirstName") && lnameedit == ExcelLib.ReadData(2, "NewLastName"))
                {
                    //detail
                    if (userscount2 > 1)
                    {
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[4]/div/button")).Click();
                        Thread.Sleep(500);
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr[" + j + "]/td[4]/div/ul/li[1]/a")).Click();
                        Thread.Sleep(500);
                        fullnametext = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));
                        email = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"));
                    }
                    else
                    {
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr/td[4]/div/button")).Click();
                        Thread.Sleep(500);
                        Driver.driver.FindElement(By.XPath(".//*[@id='listUserTable']/tbody/tr/td[4]/div/ul/li[1]/a")).Click();
                        Thread.Sleep(500);
                        fullnametext = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));
                        email = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"));
                    }


                    if (email == ExcelLib.ReadData(2, "Email") && fullnametext == fullname)
                    {

                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edited job is saved successfully");
                        break;
                    }
                    else
                    {
                        Driver.driver.FindElement(By.XPath(".//*[@id='userDetails']/div/div[3]/button")).Click();
                    }
                }
            }
        }




        public void adminfieldval()
        {
            ExcelLib.PopulateInCollection(Base.ExcelPath, "Admin");

            //Click on edit button
            Thread.Sleep(2000);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(44, "Locator"), ExcelLib.ReadData(44, "Value"));
            Thread.Sleep(1000);
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value"));
            Thread.Sleep(1000);

            //First Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(5, "FirstName"));
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
            string fnameerror = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(41, "Locator"), ExcelLib.ReadData(41, "Value"));
            try
            {
                if (fnameerror == "Please enter a valid First Name")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for first name");
                }

            }
            catch (Exception e)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e.Message);
            }
            Thread.Sleep(1000);
            //Middle Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"), ExcelLib.ReadData(5, "Middle Name"));
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"));
            string mnameerror = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(42, "Locator"), ExcelLib.ReadData(42, "Value"));
            try
            {
                if (mnameerror == "Please enter a valid Middle Name")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for middle name");
                }
            }
            catch (Exception e1)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e1.Message);
            }
            Thread.Sleep(1000);
            //Last Name
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(5, "Last Name"));
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));
            string lnameerror = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"));
            try
            {
                if (lnameerror == "Please enter a valid Last Name")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for last name");
                }
            }
            catch (Exception e2)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e2.Message);
            }
            Thread.Sleep(1000);
            //Language
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"), ExcelLib.ReadData(5, "Language"));
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
            string language = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(45, "Locator"), ExcelLib.ReadData(45, "Value"));
            try
            {
                if (language == "Please enter a valid data must be less than 20 characters")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for language");
                }
            }
            catch (Exception e3)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e3.Message);
            }
            Thread.Sleep(1000);
            //Place of birth
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"), ExcelLib.ReadData(5, "Place of Birth"));
            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
            string pob = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(46, "Locator"), ExcelLib.ReadData(46, "Value"));
            try
            {
                if (language == "Please enter a valid Place of Birth")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for place of birth");
                }
            }
            catch (Exception e4)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e4.Message);
            }

            //Number (Physical address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"), ExcelLib.ReadData(5, "Number1"));
            string number1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(47, "Locator"), ExcelLib.ReadData(47, "Value"));
            try
            {
                if (number1 == "Please enter a valid Number")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for number");
                }
            }
            catch (Exception e5)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e5.Message);
            }
            Thread.Sleep(1000);

            //Street (Physical address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(5, "Street1"));
            string street1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(48, "Locator"), ExcelLib.ReadData(48, "Value"));
            try
            {
                if (street1 == "Please enter a valid Street")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for street");
                }
            }
            catch (Exception e6)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e6.Message);
            }
            Thread.Sleep(1000);

            //Post code(physical address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"), ExcelLib.ReadData(5, "Post Code1"));
            string postcode1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(49, "Locator"), ExcelLib.ReadData(49, "Value"));
            try
            {
                if (postcode1 == "Please enter a valid Post Code and maximum 4 characters only.")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for postcode");
                }
            }
            catch (Exception e7)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e7.Message);
            }
            Thread.Sleep(1000);

            //City
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(5, "City1"));
            string city1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(50, "Locator"), ExcelLib.ReadData(50, "Value"));
            try
            {
                if (city1 == "Please enter a valid City")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for city");
                }
            }
            catch (Exception e8)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e8.Message);
            }
            Thread.Sleep(1000);

            //Suburb (physical address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(5, "Suburb1"));
            string suburb1 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(51, "Locator"), ExcelLib.ReadData(51, "Value"));
            try
            {
                if (suburb1 == "Please enter a valid Suburb")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for suburb");
                }
            }
            catch (Exception e9)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e9.Message);
            }
            Thread.Sleep(1000);

            //Number (Billing address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(21, "Locator"), ExcelLib.ReadData(21, "Value"), ExcelLib.ReadData(5, "Number2"));
            string number2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value"));
            try
            {
                if (number2 == "Please enter a valid Number")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for number");
                }
            }
            catch (Exception e10)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e10.Message);
            }
            Thread.Sleep(1000);

            //Street (Billing address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"), ExcelLib.ReadData(5, "Street2"));
            string street2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));
            try
            {
                if (street2 == "Please enter a valid Street")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for street");
                }
            }
            catch (Exception e11)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e11.Message);
            }
            Thread.Sleep(1000);

            //Post code(billing address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"), ExcelLib.ReadData(5, "Post Code2"));
            string postcode2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));
            try
            {
                if (postcode2 == "Please enter a valid Post Code and maximum 4 characters only.")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for postcode");
                }
            }
            catch (Exception e12)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e12.Message);
            }
            Thread.Sleep(1000);

            //City
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(5, "City2"));
            string city2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(55, "Locator"), ExcelLib.ReadData(55, "Value"));
            try
            {
                if (city2 == "Please enter a valid City")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for city");
                }
            }
            catch (Exception e13)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e13.Message);
            }
            Thread.Sleep(1000);

            //Suburb (physical address)
            Driver.Textbox(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"), ExcelLib.ReadData(5, "Suburb2"));
            string suburb2 = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(56, "Locator"), ExcelLib.ReadData(56, "Value"));
            try
            {
                if (suburb2 == "Please enter a valid Suburb")
                {
                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Appropriate error messages are displayed for invalid data entered for suburb");
                }
            }
            catch (Exception e14)
            {
                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e14.Message);
            }
            //Thread.Sleep(1000);

        }

    }
}

