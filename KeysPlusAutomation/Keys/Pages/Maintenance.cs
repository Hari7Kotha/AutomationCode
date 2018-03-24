//using AutoItX3Lib;
using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    #region maintenance
    //class Maintenance
    //{
    //    internal Maintenance()
    //    {
    //        PageFactory.InitElements(Driver.driver, this);

    //    }
    //    public string JobStatus = "Open";
    //    //POM Def
    //    //Click on Maitenance Link
    //    [FindsBy(How = How.XPath, Using = "html/body/div/div/div[1]/ul/li[4]/a/h4")]
    //    private IWebElement MaintenanceLink { get; set; }

    //    //Click on Manage Job for Property Manager
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='demo']/div[1]/a/h4")]
    //    private IWebElement ManageJobForPropertyManager { get; set; }
    //    //click on AddNew Job
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='pagination']/div/div[1]/a[1]")]
    //    private IWebElement AddNewBtnClick { get; set; }
    //    //JobDesc
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='jobFormModal']/div/div/div[2]/form/div[1]/div/textarea")]
    //    private IWebElement JobDesc { get; set; }
    //    //Property Name select
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='jobFormModal']/div/div/div[2]/form/div[2]/div/select")]
    //    private IWebElement PropNameSelect { get; set; }
    //    //Save Reocrd
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='jobFormModal']/div/div/div[3]/button[1]")]
    //    private IWebElement SaveBtnClick { get; set; }
    //    //Search record to delete
    //    [FindsBy(How = How.XPath, Using = ".//*[@id='SearchString']")]
    //    private IWebElement SearchRecord { get; set; }
    //    //Click on Search Button
    //    [FindsBy(How = How.XPath, Using = "html/body/div/div/div[2]/form/div/span/button")]
    //    private IWebElement SearchBtn { get; set; }
    //    public static int RowCountBase = Int32.Parse(KeysResource.RowNum);

    //    //Saranga
    //    //Add New Job 
    //    internal void ValidationsOfJobPropertyManager()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        //string jobdesc = ExcelLib.ReadData(RowCountBase, "JobDescription");
    //        //string propertyname=ExcelLib.ReadData(RowCountBase, "PropertyName");

    //        //ExcelLib.PopulateInCollection(Base.ExcelPath, "WebElement");
    //        //Goto Maintenance menu
    //        // MaintenanceLink.Click();

    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //        Thread.Sleep(1000);

    //        //Select Maintenace Job for Prop Manager
    //        //ManageJobForPropertyManager.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //        Thread.Sleep(1000);
    //        //Click on Add New Job
    //        // AddNewBtnClick.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        Thread.Sleep(1000);
    //        //Send Values to Job Desc
    //        // JobDesc.SendKeys(ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        Thread.Sleep(1000);
    //        //Select Prop Name from dropdown
    //        //PropNameSelect.Click();
    //        //PropNameSelect.SendKeys(ExcelLib.ReadData(2, "PropertyName"));

    //        try
    //        {
    //            if (ExcelLib.ReadData(RowCountBase, "JobDescription").Count() > 500 && ExcelLib.ReadData(RowCountBase, "JobDescription")!= Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value")))
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Not allowed more than 500 characters for Job Desc");
    //                Thread.Sleep(2000);
    //            }
    //            //else if(ExcelLib.ReadData(2, "JobDescription").Count()< 5)
    //            //{
    //            //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Not allowed less than 5 characters for Job Desc");
    //            //    Thread.Sleep(2000);

    //            //}

    //            else
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Job Desc is less than 300 ,Allowed to move forward for Save");
    //                Thread.Sleep(2000);
    //                //Select Prop Name from dropdown
    //                //PropNameSelect.Click();
    //                Driver.ActionButton(Driver.driver, (ExcelLib.ReadData(7, "Locator")), (ExcelLib.ReadData(7, "Value")));
    //                var propNameSelect = Driver.driver.FindElement(By.XPath((ExcelLib.ReadData(7, "Value"))));
    //                var pname = new SelectElement(propNameSelect);
    //                pname.SelectByText(ExcelLib.ReadData(RowCountBase, "PropertyName"));

    //                //PropNameSelect.Click();
    //                //Thread.Sleep(1000);
    //                //PropNameSelect(ExcelLib.ReadData(RowCountBase, "PropertyName"));
    //                //Thread.Sleep(2000);

    //                // GlobalDef.driver.FindElement(By.XPath("/html/body/div[6]/div[2]/div/div[18]/span/span/span[2]/span")).Click();
    //                //IList<IWebElement> eT = Driver.driver.FindElements(By.XPath("//*[@id='jobFormModal']/div/div/div[2]/form/div[2]/div/select"));
    //                //try
    //                //{
    //                //    foreach (IWebElement e in eT)
    //                //    {
    //                //        if ((ExcelLib.ReadData(RowCountBase, "PropertyName").ToLowerInvariant()).Equals(e.Text.ToLowerInvariant()))
    //                //        {
    //                //            e.Click();
    //                //            break;
    //                //        }

    //                //    }
    //                //}
    //                //catch
    //                //{
    //                //    throw new NoSuchElementException("Can't find" + ExcelLib.ReadData(RowCountBase, "Property Name") + " in Property Name dropdown");
    //                //}

    //                //Save Record
    //                //  SaveBtnClick.Click();
    //                Driver.ActionButton(Driver.driver,ExcelLib.ReadData(8, "Locator"),ExcelLib.ReadData(8,"Value"));
    //                Thread.Sleep(2000);
    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "There is an issue on Add Job,Please check");
    //            Thread.Sleep(2000);
    //        }

    //        //Validation


    //    }

    //    internal void DeleteJobFromMaintenance()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        //click on Maintenance Link
    //        //  MaintenanceLink.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //        Thread.Sleep(1000);
    //        //click on Manage job for property manager
    //        //  ManageJobForPropertyManager.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //        Thread.Sleep(1000);

    //        //Search record for delete
    //       // SearchRecord.SendKeys(ExcelLib.ReadData(2, "JobDescription"));
    //       Driver.Textbox(Driver.driver,ExcelLib.ReadData(9,"Locator"), ExcelLib.ReadData(9,"Value"),ExcelLib.ReadData(2, "JobDescription"));
    //        Thread.Sleep(1000);
    //        //SearchBtn.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
    //        Thread.Sleep(1000);

    //        //string JobdDescriptionSearch = Driver.driver.FindElement(By.XPath(".//*[@id='jobDeleteModal']/div/div/div[2]/button[1]")).Text +
    //        //                 Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[2]")).Text;
    //        //Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;
    //        try
    //        {
    //            if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div")).Displayed)
    //            {
    //                if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div/div[1]/p[2]")).Text == ExcelLib.ReadData(RowCountBase, "JobDescription"))

    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Not Available to Delete");

    //                else
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error in validation");
    //            }
    //        }
    //        catch(Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Similar Record found");
    //        }
    //            try
    //            {
    //                IList getrow = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(11, "Value")));
    //                int listcount = getrow.Count;

    //                for (int i = 1; i <= listcount; i++)
    //                {
    //                    if (ExcelLib.ReadData(RowCountBase, "JobDescription") == Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[1]")).Text)
    //                    {
    //                        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Found JobDescroption matched");
    //                        //Thread.Sleep(2000);

    //                        if (ExcelLib.ReadData(RowCountBase, "PropertyName") == Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[2]")).Text)
    //                        {
    //                            if (Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[3]")).Text == JobStatus)
    //                            {
    //                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Found all Job Description,Property & JobStatus=Open  matched record to delete");
    //                                Thread.Sleep(2000);
    //                            //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "found record to delete");
    //                            //Thread.Sleep(2000);
    //                            if (listcount > 1)
    //                            {
    //                                //Click on Action dropdown
    //                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/button")).Click();
    //                                //*[@id="propList"]/tr[1]/td[4]/div/button
    //                                //Delete button click
    //                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/ul/li[5]/a")).Click();
    //                                //*[@id="propList"]/tr[1]/td[4]/div/ul/li[5]/a
    //                                Thread.Sleep(1000);
    //                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Record found & deleted");
    //                                Driver.driver.FindElement(By.XPath("//*[@id='jobDeleteModal']/div/div/div[3]/button[1]")).Click();
    //                                //*[@id="jobDeleteModal"]/div/div/div[3]/button[1]
    //                                Thread.Sleep(1000);
    //                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Record found & deleted");
    //                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record Deleted");
    //                                Thread.Sleep(1000);
    //                                //   break;
    //                            }
    //                            else
    //                            {
    //                                //Click on Action dropdown
    //                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/button")).Click();
    //                                //*[@id="propList"]/tr[1]/td[4]/div/button
    //                                //Delete button click
    //                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/ul/li[5]/a")).Click();
    //                                Thread.Sleep(1000);
    //                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Record found & deleted");
    //                                Driver.driver.FindElement(By.XPath("//*[@id='jobDeleteModal']/div/div/div[3]/button[1]")).Click();
    //                                Thread.Sleep(1000);
    //                                SaveScreenShotClass.SaveScreenshot(Driver.driver, "Record found & deleted");
    //                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record Deleted");
    //                                Thread.Sleep(1000);
    //                            }

    //                            }
    //                            else
    //                            {
    //                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Not allowed to delete because Job Status is either Pending or In Progress");
    //                                Thread.Sleep(1000);
    //                            }


    //                        }
    //                        else
    //                        {
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Not found matching record to delete");
    //                            Thread.Sleep(1000);
    //                        }
    //                    }


    //                }
    //            }
    //            catch (Exception e)
    //            {

    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, e.Message + "There is an issue on delete,Please check");


    //            }
    //        //Validation
    //        //Search record for delete

    //        //Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "JobDescription"));
    //        //Thread.Sleep(1000);
    //        ////SearchBtn.Click();
    //        //Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
    //        //Thread.Sleep(2000);
    //        //If no record found
    //        try
    //        {
    //            if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div")).Displayed)

    //            {
    //                if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div/div[1]/p[2]")).Text == ExcelLib.ReadData(RowCountBase, "JobDescription"))
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record Deleted successfully");
    //                else
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error in validation");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Similar Record found");
    //        }

    //        //if similar record available, verify the data
    //        try
    //        {
    //            IList getrow = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(11, "Value")));
    //            int listcount = getrow.Count;

    //            for (int i = 1; i <= listcount; i++)
    //            {
    //                if (ExcelLib.ReadData(RowCountBase, "JobDescription") == Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[1]")).Text)
    //                {
    //                    //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Found JobDescroption matched");
    //                    //Thread.Sleep(2000);

    //                    if (ExcelLib.ReadData(RowCountBase, "PropertyName") == Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[2]")).Text)
    //                    {
    //                        if (Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[3]")).Text == JobStatus)
    //                        {
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Not Deleted, Please check");
    //                        }
    //                    }
    //                }
    //            }
    //        }
    //        catch(Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Issue in validating the data");
    //        }

    //                        }

    //    //Preethi 

    //    public void Commonsteps()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        Driver.wait(2);
    //        // MaintenanceLink.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //        Driver.wait(2);
    //        // ManageJobForPropertyManager.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //    }

    //    public void AddJob()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        Driver.wait(2);
    //        Commonsteps();
    //        Driver.wait(2);

    //        //verification of Manage Job for Property Manager page
    //        string PMpage = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));// Driver.driver.FindElement(By.XPath("html/body/div/div/div[2]/h4[1]")).Text;
    //        try
    //        {
    //            if (PMpage == "Manage Job Property Manager")
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Manage Job for Property Manager page loaded successfully");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Manage Job for Property Manager page is not loaded" + e.Message);

    //        }

    //        //Add new job
    //        // AddNewBtnClick.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        Thread.Sleep(1000);

    //        //verification of add new job page
    //        string newjobpage = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));// Driver.driver.FindElement(By.XPath(".//*[@id='jobFormModal']/div/div/div[1]/h4[1]")).Text;
    //        Thread.Sleep(1000);
    //        try
    //        {
    //            if (newjobpage == "Add New Job")
    //            {

    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Window to add new job opens");
    //            }
    //        }
    //        catch (Exception e)
    //        {

    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Window to add new job is not opened" + e.Message);
    //        }

    //        //job description
    //        //JobDesc.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        Thread.Sleep(1000);
    //        //Maximum Budget
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "MaximumBudget"));


    //        //property name
    //        // PropNameSelect.Click();
    //        Driver.ActionButton(Driver.driver, (ExcelLib.ReadData(7, "Locator")), (ExcelLib.ReadData(7, "Value")));
    //        Driver.wait(2);
    //        var selectpropname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(7, "Value")));
    //        var myselect = new SelectElement(selectpropname);
    //        myselect.SelectByText(ExcelLib.ReadData(2, "PropertyName"));
    //        Driver.wait(2);

    //        //Upload Photo
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
    //        try
    //        {
    //            // File upload begins here

    //            AutoItX3 autoIt = new AutoItX3();
    //            autoIt.WinActivate("Open");
    //            Thread.Sleep(1000);
    //            //  autoIt.Send(@"E:\KEYS\property1.jpg");
    //            autoIt.Send(ExcelLib.ReadData(RowCountBase, "PhotoPath"));
    //            Thread.Sleep(1000);
    //            autoIt.Send("{Enter}");
    //            Thread.Sleep(1000);
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

    //        }

    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

    //            Console.WriteLine("Error" + e.ToString());
    //        }

    //        //save
    //        //SaveBtnClick.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //        Driver.wait(5);

    //        //verification of added job

    //        //search
    //        // SearchRecord.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "JobDescription"));
    //        Thread.Sleep(1000);
    //        //searchbtn1.Click();
    //        //Driver.wait(2);
    //        // SearchBtn.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
    //        Thread.Sleep(1000);
    //        //to check the record added
    //        try
    //        {
    //            if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div")).Displayed)
    //            {
    //                if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div/div[1]/p[2]")).Text == ExcelLib.ReadData(RowCountBase, "JobDescription"))
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Not Added");
    //                else
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error in validation");

    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Similar Record found");
    //        } 

    //            IList joblist = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(11, "Value")));
    //            int joblistcount = joblist.Count;
    //            string jname;
    //            string jobstatus;
    //            string proname;

    //            for (int i = 1; i <= joblistcount; i++)
    //            {
    //                jname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[1]")).Text;
    //                jobstatus = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[3]")).Text;
    //                proname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[2]")).Text;
    //                try
    //                {
    //                    if (jname == ExcelLib.ReadData(RowCountBase, "JobDescription") && proname == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                    {
    //                        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details of the added job can be viewed");
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job description and location added, Job has been added and saved");

    //                        if (jobstatus == "Open")
    //                        {
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "New job added is in open state");
    //                            break;
    //                        }
    //                        else
    //                        {
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "the status grid displays incorrect jobstatus");
    //                        }

    //                    }
    //                    else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record not found");
    //                }
    //                }
    //                catch (Exception e)
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "property not added" + e.Message);
    //                }
    //            }


    //    }

    //    //to check if a job can be edited and saved
    //    internal void editjob()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        Driver.wait(2);
    //        Commonsteps();
    //        Driver.wait(2);
    //        //searching a job
    //        // searchjob.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        // searchbtn2.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));

    //        IList jobs = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(11, "Value")));
    //        int jobscount = jobs.Count;
    //        string editjobname;
    //        string editpropname;

    //        for (int i = 1; i <= jobscount; i++)
    //        {
    //            if (jobscount > 1)
    //            {
    //                editjobname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[1]")).Text;
    //                Thread.Sleep(1000);
    //                editpropname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[2]")).Text;
    //                Thread.Sleep(1000);
    //            }
    //            else
    //            {
    //                editjobname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "/td[1]")).Text;
    //                Thread.Sleep(1000);
    //                editpropname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "/td[2]")).Text;
    //                Thread.Sleep(1000);
    //            }
    //            try
    //            {
    //                if (editjobname == ExcelLib.ReadData(RowCountBase, "JobDescription") && editpropname == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Searched job is present");
    //                    //Click on Action dropdown
    //                    if (jobscount > 1)
    //                    {
    //                        Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[4]/div/button/div")).Click();
    //                        //clicking on edit button
    //                        Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[4]/div/ul/li[3]/a")).Click();
    //                        Thread.Sleep(1000);
    //                    }
    //                    else
    //                    {
    //                        Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "/td[4]/div/button/div")).Click();
    //                        //Clicking on Edit button
    //                        Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "/td[4]/div/ul/li[3]/a")).Click();
    //                        Thread.Sleep(1000);
    //                    }

    //                    //editing the job description field
    //                  //  jobdesc.Clear();
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"));
    //                    Thread.Sleep(1000);
    //                    //  jobdesc.SendKeys(ExcelLib.ReadData(2, "New Job description"));
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "NewJobdescription"));
    //                    Thread.Sleep(1000);

    //                    //Update Maximum Budget
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"));
    //                    Thread.Sleep(1000);
    //                    //  jobdesc.SendKeys(ExcelLib.ReadData(2, "New Job description"));
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(16, "Locator"), ExcelLib.ReadData(16, "Value"), ExcelLib.ReadData(RowCountBase, "MaximumBudget"));
    //                    Thread.Sleep(1000);
    //                    // save.Click();
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(15, "Locator"), ExcelLib.ReadData(15, "Value"));
    //                    Driver.wait(2);
    //                    //Thread.Sleep(1000);

    //                    //entering edited value in searchbar
    //                    //searchjob.Clear();
    //                    //Thread.Sleep(1000);
    //                    //searchjob.SendKeys(ExcelLib.ReadData(2, "New Job description"));
    //                    //Thread.Sleep(1000);
    //                    //searchbtn2.Click();
    //                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
    //                    Thread.Sleep(1000);
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(2, "NewJobdescription"));
    //                    Thread.Sleep(1000);
    //                    // searchbtn2.Click();
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));

    //                    Thread.Sleep(1000);

    //                    //validation of edited record
    //                    string neweditjobname = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text;

    //                    if (neweditjobname == ExcelLib.ReadData(2, "NewJobdescription"))
    //                    {
    //                        Thread.Sleep(2000);
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The job Name is edited and saved");
    //                        // break;
    //                        //Click on Action dropdown
    //                        if (jobscount > 1)
    //                        {
    //                            Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[4]/div/button/div")).Click();
    //                            //clicking on Details button
    //                            Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + i + "]/td[4]/div/ul/li[1]/a")).Click();
    //                            //*[@id="propList"]/tr/td[4]/div/ul/li[1]/a
    //                            Thread.Sleep(1000);
    //                        }
    //                        else
    //                        {
    //                            Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "/td[4]/div/button/div")).Click();
    //                            //Clicking on Edit button
    //                            Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "/td[4]/div/ul/li[1]/a")).Click();
    //                            Thread.Sleep(1000);
    //                        }
    //                        //check the maximum budget in details page
    //                      //  Driver.ActionButton(Driver.driver, ExcelLib.ReadData(36, "Locator"), ExcelLib.ReadData(36, "Value"));
    //                        Driver.wait(2);
    //                        string a = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(37, "Locator"), ExcelLib.ReadData(36, "Value"));
    //                        if (a == ExcelLib.ReadData(RowCountBase, "MaximumBudget"))
    //                        {
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The Maximum Budget is edited and saved");
    //                        }
    //                        else
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, a +"The Maximum Budget is not edited");

    //                    }

    //                    else
    //                    {
    //                        //Thread.Sleep(2000);
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job Name is not edited");
    //                    }

    //                }
    //            }
    //            catch (Exception e)
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Error" + e.Message);
    //            }
    //        }


    //    }


    //    //to Check if added job is present in pick job page
    //    internal void pickjob()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        Driver.wait(2);
    //        // Maintainence tab
    //        Commonsteps();
    //        //  addnewjob.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"));
    //        Thread.Sleep(1000);
    //        // jobdesc.SendKeys(ExcelLib.ReadData(3, "Job Description"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        Thread.Sleep(1000);

    //        //Maximum Budget
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "MaximumBudget"));


    //        //property name
    //        // propname.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(7, "Locator"), ExcelLib.ReadData(7, "Value"));
    //        Driver.wait(2);
    //        var selectpropname2 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(7, "Value")));//".//*[@id='jobFormModal']/div/div/div[2]/form/div[2]/div/select"));
    //        var myselect2 = new SelectElement(selectpropname2);
    //        myselect2.SelectByText(ExcelLib.ReadData(RowCountBase, "PropertyName"));

    //        Thread.Sleep(1000);

    //        //Upload Photo
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
    //        try
    //        {
    //            // File upload begins here

    //            AutoItX3 autoIt = new AutoItX3();
    //            autoIt.WinActivate("Open");
    //            Thread.Sleep(5000);
    //            //  autoIt.Send(@"E:\KEYS\property1.jpg");
    //            autoIt.Send(ExcelLib.ReadData(RowCountBase, "PhotoPath"));
    //            Thread.Sleep(5000);
    //            autoIt.Send("{Enter}");
    //            Thread.Sleep(2000);
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

    //        }

    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

    //            Console.WriteLine("Error" + e.ToString());
    //        }

    //        //save
    //        //   save.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //        Thread.Sleep(1000);

    //        //maintainence tab and pick job
    //        // maintainence.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //        Thread.Sleep(1000);
    //        //Click Pick Job link
    //        //pickjobbtn.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"));

    //        Thread.Sleep(1000);

    //        //Verification of pick job page
    //        string pickjob = Driver.GetTextValue(Driver.driver,ExcelLib.ReadData(23,"Locator"),ExcelLib.ReadData(23,"Value"));
    //            //Driver.driver.FindElement(By.XPath("html/body/div/div/div[2]/h4[3]")).Text;
    //        Thread.Sleep(1000);
    //        try
    //        {
    //            if (pickjob == "Pick Job Service Provider")
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Page to apply job for service provider is loaded");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Page to apply job for service provider is not loaded" + e.Message);
    //        }

    //        //Searching the job in pick job page
    //        // searchjob.SendKeys(ExcelLib.ReadData(3, "Job Description"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        Thread.Sleep(1000);
    //        // searchbtn2.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"));
    //        Thread.Sleep(1000);

    //        //to Check if added job is present in pick job page
    //        IList joblist2 = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(26, "Value")));
    //        int joblistcount2 = joblist2.Count;
    //        string propertyname;
    //        string jobname;
    //        string jobstatus;
    //        for (int i = 1; i <= joblistcount2; i++)
    //        {
    //            jobname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value")+"[" + i + "]/td[1]")).Text;
    //            Thread.Sleep(1000);
    //            propertyname = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "[" + i + "]/td[2]")).Text;

    //            Thread.Sleep(1000);
    //            try
    //            {
    //                if (jobname == ExcelLib.ReadData(RowCountBase, "JobDescription") && propertyname == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                {
    //                    Thread.Sleep(1000);
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job added under manage job for property manager is present under pick job for service provider");
    //                    jobstatus = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "[" + i + "]/td[3]")).Text;

    //                    if (jobstatus == "Open")
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The newly added job in pick job is in open status");
    //                        break;
    //                    }


    //                    else
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "The status of newly added job is displayed incorrectly");
    //                    }
    //                }
    //            }
    //            catch (Exception e)
    //            {
    //                //Thread.Sleep(1000);
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job added under manage job for property manager is not present under pick job for service provider" + e.Message);
    //            }
    //        }

    //    }

    //    //to Check if the job status changes accordingly in all Maintenance Pages 
    //    internal void jobstatus()
    //    {
    //        //AddJob();
    //        //Thread.Sleep(1000);
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        //Picking job
    //        // maintainence.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //        Thread.Sleep(1000);
    //        //pickjobbtn.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"));
    //       Thread.Sleep(1000);

    //        //searching job
    //        // searchjob.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        Thread.Sleep(500);
    //        // searchbtn2.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"));

    //        //to check the record added
    //        try
    //        {

    //            if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div")).Displayed)
    //            {
    //                if (Driver.driver.FindElement(By.XPath("//*[@id='NoProperty']/div/div/div[1]/p[2]")).Text == ExcelLib.ReadData(RowCountBase, "JobDescription"))
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Record Not Available");
    //                else
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error in validation");

    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Similar Record found");
    //        }

    //        IList joblist3 = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(26, "Value")));
    //        int joblistcount3 = joblist3.Count;
    //        string propertyname3;
    //        string jobname3;

    //        for (int i = 1; i <= joblistcount3; i++)
    //        {
    //            jobname3 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value")+"[" + i + "]/td[1]")).Text;
    //            Thread.Sleep(1000);
    //            propertyname3 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "[" + i + "]/td[2]")).Text;
    //            Thread.Sleep(1000);
    //            if (jobname3 == ExcelLib.ReadData(RowCountBase, "JobDescription") && propertyname3 == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job added under manage job for property manager is present under pick job for service provider");
    //                if (joblistcount3 > 1)
    //                {
    //                    //Click Action dropdown
    //                    Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "[" + i + "]/td[4]/div/button")).Click();
    //                    //*[@id="propList"]/tr[1]/td[4]/div/button
    //                    //Clicking apply
    //                    Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "[" + i + "]/td[4]/div/ul/li[9]/a")).Click();
    //                    //*[@id="propList"]/tr[1]/td[4]/div/ul/li[9]/a
    //                    Thread.Sleep(1000);
    //                }
    //                else
    //                {
    //                    //Click Action dropdown
    //                    Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "/td[4]/div/button")).Click();
    //                    //Clicking apply
    //                    Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(26, "Value") + "/td[4]/div/ul/li[9]/a")).Click();
    //                    Thread.Sleep(1000);
    //                }
    //                //quote amount
    //                // quoteamnt.SendKeys(ExcelLib.ReadData(2, "Quote Amount"));
    //                Driver.Textbox(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"), ExcelLib.ReadData(RowCountBase, "Quote Amount"));
    //                Thread.Sleep(1000);
    //                //random click
    //               // tab.Click();
    //                Thread.Sleep(1000);
    //                //  savequote.Click();
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value"));
    //                Thread.Sleep(1000);

    //                //navigating to manage job by PM
    //                // maintainence.Click();
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //                Thread.Sleep(1000);
    //                // managejobPM.Click();
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //                Thread.Sleep(500);

    //                //searching job
    //                //searchjob.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //                Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //                Thread.Sleep(500);
    //                //searchbtn2.Click();
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
    //                Thread.Sleep(500);

    //                IList joblist4 = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(11, "Value")));
    //                int joblistcount4 = joblist4.Count;
    //                string jobname4;
    //                string propertyname4;
    //                string test;
    //                for (int j = 1; j <= joblistcount4; j++)
    //                {
    //                    jobname4 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value")+"[" + j + "]/td[1]")).Text;
    //                    propertyname4 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(11, "Value") + "[" + j + "]/td[2]")).Text;

    //                    if (jobname4 == ExcelLib.ReadData(RowCountBase, "JobDescription") && propertyname4 == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                    {
    //                        ////Clicking view quote
    //                        //Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + j + "]/td[4]/button")).Click();
    //                        //Thread.Sleep(1000);
    //                        //IList quotes = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //                        //int quotescount = quotes.Count;

    //                        //string qjobname;
    //                        //string qpropertyname;
    //                        if(joblistcount4>1)
    //                        {
    //                            test = "["+Convert.ToString(j)+"]";
    //                        }
    //                        else
    //                        {
    //                            test = "";
    //                        }
    //                        if (Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr" + test + "/td[3]")).Text=="Open")//Check status of the job
    //                        { 
    //                        if (joblistcount4 > 1)
    //                        {
    //                            //Click on Action button
    //                            Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + j + "]/td[4]/div/button")).Click();

    //                            //viewing quote
    //                            Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + j + "]/td[4]/div/ul/li[10]/a")).Click();

    //                            //Selecting quote
    //                            Thread.Sleep(1000);
    //                        }
    //                        else
    //                        {
    //                            //Click on Action button
    //                            Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]/div/button")).Click();

    //                            //viewing quote
    //                            Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]/div/ul/li[10]/a")).Click();
    //                            //Selecting quote
    //                            Thread.Sleep(1000);
    //                        }

    //                        IList jobquote = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(26, "Value")));
    //                        int jobquotecount4 = jobquote.Count;
    //                        string jobquote1;
    //                        for (int k = 1; k <= jobquotecount4; k++)
    //                        {
    //                                if (jobquotecount4 > 1)
    //                                {
    //                                    jobquote1 = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr[" + k + "]/td[4]")).Text;
    //                                   // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, k + jobquote1);
    //                                    if (jobquote1 == ExcelLib.ReadData(RowCountBase, "Quote Amount"))
    //                                    {
    //                                        //Click on Action button
    //                                        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + k + "]/td[6]/div/button")).Click();
    //                                        //*[@id="propList"]/tr/td[6]/div/button

    //                                        //Click on Select
    //                                        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + k + "]/td[6]/div/ul/li[4]/a")).Click();


    //                                    }
    //                                    //*[@id="propList"]/tr[1]/td[6]/button[2]
    //                                    //handle Alert
    //                                    Thread.Sleep(1000);
    //                                }
    //                                else
    //                                {
    //                                    jobquote1 = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[4]")).Text;
    //                                //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, k + jobquote1);
    //                                    if (jobquote1 == ExcelLib.ReadData(RowCountBase, "Quote Amount"))
    //                                    {
    //                                        //Click on Action button
    //                                        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/button")).Click();

    //                                        //Click on Select
    //                                        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/ul/li[4]/a")).Click();


    //                                    }
    //                                    //*[@id="propList"]/tr[1]/td[6]/button[2]
    //                                    //handle Alert
    //                                    Thread.Sleep(1000);
    //                                }
    //                                //*[@id="propList"]/tr/td[4]

    //                        }

    //                        //
    //                        //searching the job
    //                        //  searchjob.Clear();
    //                        Driver.GetClear(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
    //                        Thread.Sleep(500);
    //                        //searchjob.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //                        Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //                        // searchbtn2.Click();
    //                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));



    //                        IList joblist5 = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //                        int joblistcount5 = joblist5.Count;
    //                        string jobname5;
    //                        string propertyname5;

    //                        for (int k = 1; k <= joblistcount5; k++)
    //                        {
    //                            jobname5 = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + k + "]/td[1]")).Text;
    //                            propertyname5 = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + k + "]/td[2]")).Text;
    //                            if (jobname5 == ExcelLib.ReadData(RowCountBase, "JobDescription") && propertyname5 == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                            {
    //                                string jobstatus2 = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + k + "]/td[3]")).Text;
    //                                if (jobstatus2 == "Pending")
    //                                {
    //                                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job status changes to Pending when quote is selected by project manager");
    //                                    //Navigate to manage job by SM
    //                                    // maintainence.Click();
    //                                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //                                    Thread.Sleep(1000);
    //                                    // managejobSM.Click();
    //                                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(31, "Locator"), ExcelLib.ReadData(31, "Value"));
    //                                    Thread.Sleep(1000);

    //                                    //searching the job
    //                                    // searchjob.Clear();
    //                                    Driver.GetClear(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"));
    //                                    Thread.Sleep(500);
    //                                    //searchjob.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //                                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //                                    //  searchbtn2.Click();
    //                                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));
    //                                    Thread.Sleep(1000);

    //                                    IList joblist6 = Driver.driver.FindElements(By.XPath(ExcelLib.ReadData(34, "Value")));
    //                                    int joblistcount6 = joblist6.Count;
    //                                    string jobname6;
    //                                    string propertyname6;
    //                                    string starttext;
    //                                    for (int l = 1; l <= joblistcount6; l++)
    //                                    {
    //                                        jobname6 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(34, "Value") + "[" + l + "]/td[1]")).Text;
    //                                        propertyname6 = Driver.driver.FindElement(By.XPath(ExcelLib.ReadData(34, "Value") + "[" + l + "]/td[2]")).Text;
    //                                        if (jobname6 == ExcelLib.ReadData(RowCountBase, "JobDescription") && propertyname6 == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                                        {
    //                                            if (joblistcount6 > 1)
    //                                            {//Click on Action dropdown

    //                                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + l + "]/td[4]/div/button")).Click();
    //                                                //Clicking on start
    //                                                starttext = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + l + "]/td[4]/div/ul/li[7]/a")).Text;
    //                                                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, starttext);
    //                                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + l + "]/td[4]/div/ul/li[7]/a")).Click();

    //                                                Thread.Sleep(1000);
    //                                            }
    //                                            else
    //                                            {
    //                                                //Click on Action dropdown

    //                                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]/div/button")).Click();
    //                                                //Clicking on start
    //                                                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]/div/ul/li[7]/a")).Click();
    //                                                Thread.Sleep(1000);
    //                                            }
    //                                            //Navigating to manage job for PM
    //                                            // maintainence.Click();
    //                                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //                                            Thread.Sleep(1000);
    //                                            // managejobPM.Click();
    //                                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));
    //                                            Thread.Sleep(1000);

    //                                            //searching the job
    //                                            //searchjob.Clear();
    //                                            Driver.GetClear(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));
    //                                            Thread.Sleep(500);
    //                                            // searchjob.SendKeys(ExcelLib.ReadData(2, "Job Description"));
    //                                            Driver.Textbox(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //                                            //  searchbtn2.Click();
    //                                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));

    //                                            IList joblist7 = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //                                            int joblistcount7 = joblist7.Count;
    //                                            string jobname7;
    //                                            string propertyname7;

    //                                            for (int m = 1; m <= joblistcount7; m++)
    //                                            {
    //                                                jobname7 = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + m + "]/td[1]")).Text;
    //                                                propertyname7 = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + m + "]/td[2]")).Text;
    //                                                if (jobname7 == ExcelLib.ReadData(RowCountBase, "JobDescription") && propertyname7 == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                                                {
    //                                                    //Checking if the status of job is "in process"
    //                                                    string jobstatus3 = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + m + "]/td[3]")).Text;
    //                                                    if (jobstatus3 == "In process")
    //                                                    {
    //                                                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job status changes to In Process when service provider starts the job");


    //                                                    }
    //                                                    else
    //                                                    {
    //                                                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job status displayed incorrectly");
    //                                                    }
    //                                                }
    //                                                else
    //                                                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job does not exist");
    //                                            }
    //                                        }
    //                                        else
    //                                        {
    //                                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job does not exist");
    //                                        }
    //                                    }
    //                                }
    //                                else
    //                                {
    //                                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job status displayed incorrectly");
    //                                }


    //                            }

    //                        }
    //                    }
    //                    else
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Similar Job in Process state");
    //                    }
    //                    }
    //                    else
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job does not exist");

    //                }
    //            }
    //            else
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job does not exist");
    //        }


    //    }

    //    //Preethi ends here

    //        //Janani

    //    internal void pickJobJanani()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceProvider");
    //        //Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));
    //        //Waiting
    //        Thread.Sleep(1000);
    //        //Navigating to Pick job to provide a quote
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));
    //        //Searching for the new job 
    //        //SearchTextBox.SendKeys(ExcelLib.ReadData(2, "JobDescription"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //        //Search Button click
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));
    //        //Waiting
    //        Thread.Sleep(1000);
    //        //Validation Check
    //        try
    //        {
    //            if (Driver.driver.FindElement(By.XPath(".//*[@id='NoProperty']/div/div")).Displayed)
    //            {
    //                if (Driver.driver.FindElement(By.XPath(".//*[@id='NoProperty']/div/div/div[1]/p[2]")).Text == ExcelLib.ReadData(RowCountBase, "JobDescription"))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "No Records Found. Test Failed");
    //                    //Clicking on OK
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
    //                }
    //                else
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error in validation");
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Proceeding since no error occured");
    //        }
    //        string jobDesc = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[1]")).Text;
    //        string propertyName = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[2]")).Text;
    //        string statusOfJob = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[3]")).Text;
    //        //String propertyName = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(22, "Locator"), ExcelLib.ReadData(22, "Value"));
    //        //String statusOfJob = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(23, "Locator"), ExcelLib.ReadData(23, "Value"));
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, propertyName + statusOfJob);
    //        if (jobDesc == ExcelLib.ReadData(RowCountBase, "JobDescription") &&
    //                  propertyName == ExcelLib.ReadData(RowCountBase, "PropertyName") &&
    //                  statusOfJob == ExcelLib.ReadData(5, "JobStatus"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Applying for the job. Quote the price");

    //            //Apply button click
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"));
    //            //Entering the quote amount
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "QuoteAmount"));
    //            //Entering the Notes
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "Note"));
    //            //Clicking on save
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
    //        }
    //        //IList jobList = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //        //    int jobListCount = jobList.Count;
    //        //    int count = 0;
    //        //    String propertyName;
    //        //    String jobDesc;
    //        //    String statusOfJob;
    //        //    for (int i = 1; i < jobListCount + 1; i++)
    //        //    {
    //        //        Thread.Sleep(500);
    //        //        jobDesc = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text;
    //        //        //To store the propertyName in a string we are clicking on "Detail" to find that out
    //        //        propertyName = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text;
    //        //        //status of the job
    //        //        statusOfJob = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;
    //        //        Thread.Sleep(500);
    //        //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, jobDesc+propertyName+statusOfJob);
    //        //    if (jobDesc == ExcelLib.ReadData(RowCountBase, "JobDescription") &&
    //        //            propertyName == ExcelLib.ReadData(RowCountBase, "PropertyName") &&
    //        //            statusOfJob == ExcelLib.ReadData(5, "JobStatus") && count == 0)
    //        //        {
    //        //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Applying for the job. Quote the price");
    //        //            count++;
    //        //        //Apply button click
    //        //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"));
    //        //        //Entering the quote amount
    //        //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "QuoteAmount"));
    //        //        //Entering the Notes
    //        //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "Note"));
    //        //        //Clicking on save
    //        //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));
    //        //        break;
    //        //        }
    //        //else if (jobDesc == ExcelLib.ReadData(2, "JobDescription") && count > 0)
    //        //{
    //        //    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Job description is the same");
    //        //    //Should check for the property name after the job description           
    //        //    //Checking the property name
    //        //    if (propertyName == ExcelLib.ReadData(2, "PropertyName") && statusOfJob == "Open")
    //        //    {
    //        //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Job description and property name are  the same. Duplicate job");
    //        //    }
    //        //    else
    //        //    {
    //        //        if (statusOfJob == "Open")
    //        //        {
    //        //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Applying for the job. Quote the price. The job description was the same. The Property1 Name was different.");
    //        //            //Apply button click
    //        //            ApplyButton.Click();
    //        //            //Entering the quote amount
    //        //            QuoteAmountTextBox.SendKeys(ExcelLib.ReadData(2, "QuoteAmount"));
    //        //            //Clicking on save
    //        //            SaveButtonPickJob.Click();
    //        //        }
    //        //    }
    //        //}
    //        // }
    //    }


    //    //Lewis

    //    //to check job property manager View Quote
    //    internal void viewquote()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");
    //        try
    //        {
    //            Commonsteps();

    //            // Find specific job
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(45, "Locator"), ExcelLib.ReadData(45, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(48, "Locator"), ExcelLib.ReadData(48, "Value"));
    //            Thread.Sleep(2000);

    //            //Check Job Status is open
    //            String jobStatus = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(61, "Locator"), ExcelLib.ReadData(61, "Value"));

    //            if (jobStatus == JobStatus)
    //            {
    //                int amountOfQuotes = Int32.Parse(Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(40, "Locator"), (ExcelLib.ReadData(40, "Value"))));
    //                //check amount of quotes are greater than 0
    //                if (amountOfQuotes > 0)
    //                {
    //                    //click link dropdown
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(43, "Locator"), (ExcelLib.ReadData(43, "Value")));
    //                    Thread.Sleep(2000);
    //                    //click view quotes
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(38, "Locator"), (ExcelLib.ReadData(38, "Value")));
    //                    Thread.Sleep(2000);

    //                    //loop through quotes to find the quote with selected amount.
    //                    for (int i = 1; i <= amountOfQuotes; i++)
    //                    {
    //                        if (ExcelLib.ReadData(RowCountBase, "Quote Amount") == Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(59, "Locator"), ExcelLib.ReadData(59, "Value") + i + ExcelLib.ReadData(62, "Value")))
    //                        {
    //                            //Click dropdown
    //                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(63, "Locator"), ExcelLib.ReadData(63, "Value") + i + ExcelLib.ReadData(64, "Value"));
    //                            Thread.Sleep(2000);
    //                            //Select Details
    //                            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(65, "Locator"), ExcelLib.ReadData(65, "Value") + i + ExcelLib.ReadData(66, "Value"));
    //                            Thread.Sleep(2000);
    //                            //Test passed log and screen shot
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "View Quote test passed: Quote amount showing in View quote");
    //                            SaveScreenShotClass.SaveScreenshot(Driver.driver, "Quote Amount Verified");
    //                        }
    //                        else if (i == amountOfQuotes)
    //                        {
    //                            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "View Quote test Failed: Quote amount not showing in View quote");
    //                        }
    //                    }
    //                }
    //                else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "View Quote test Failed: Selected job has no quotes");
    //                }
    //            }
    //            else
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "View Quote test Failed: Selected job status not open");
    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, e);
    //        }
    //    }

    //    //Delete pending job in Manage Job Property Manager
    //    internal void deletePending()
    //    {
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "Maintenance");

    //        try
    //        {
    //            Commonsteps();
    //            //find job using search
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(45, "Locator"), ExcelLib.ReadData(45, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(48, "Locator"), ExcelLib.ReadData(48, "Value"));

    //            //Check status is pending
    //            String jobStatus = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(60, "Locator"), ExcelLib.ReadData(60, "Value"));

    //            if (jobStatus == JobStatus)
    //            {
    //                //click link dropdown list
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(50, "Locator"), ExcelLib.ReadData(50, "Value"));
    //                Thread.Sleep(2000);
    //                //click delete
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(49, "Locator"), ExcelLib.ReadData(49, "Value"));
    //                Thread.Sleep(3000);
    //                //confirm delete
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));
    //                Thread.Sleep(3000);
    //                //warning pops up verify it is visible on the page
    //                if (Driver.ElementVisible(Driver.driver, ExcelLib.ReadData(55, "Locator"), ExcelLib.ReadData(55, "Value")))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job deletion warning displayed successfully");
    //                    SaveScreenShotClass.SaveScreenshot(Driver.driver, "Pending Delete test Success");
    //                }
    //                else
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Job deletion warning not displayed");
    //                }
    //            }
    //            else
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Selected Job status is not Pending");
    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, e);
    //        }
    //    }

    //    //Janani Code changes start
    //    internal void addNewJob()
    //    {

    //        //Extent Reports
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "In Maintenance page");

    //        //Populating from the excel sheet
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceProvider");

    //        //Maximizing the browser
    //        //Driver.driver.Manage().Window.Maximize();

    //        Driver.wait(2000);

    //        //Clicking on Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

    //        Thread.Sleep(2000);

    //        //Clicking on Manage Job for Property1 Manager
    //        //MaintenanceLinkForPropManager.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

    //        //Clicking on add new Job
    //        //AddNewJob.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Entering the job description
    //        //JobDescription.SendKeys(ExcelLib.ReadData(2, "JobDescription"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));

    //        //Maximum Budget
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "MaximumBudget"));

    //        //Selecting the property
    //        var propelement = Driver.driver.FindElement(By.XPath("//*[@id='jobFormModal']/div/div/div/div[2]/form/div[4]/div/select"));
    //        var propselect = new SelectElement(propelement);
    //        propselect.SelectByText(ExcelLib.ReadData(RowCountBase, "PropertyName"));


    //        //Upload Photo
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //        try
    //        {
    //            // File upload begins here

    //            AutoItX3 autoIt = new AutoItX3();
    //            autoIt.WinActivate("Open");
    //            Thread.Sleep(1000);
    //            //  autoIt.Send(@"E:\KEYS\property1.jpg");
    //            autoIt.Send(ExcelLib.ReadData(RowCountBase, "PhotoPath"));
    //            Thread.Sleep(1000);
    //            autoIt.Send("{Enter}");
    //            Thread.Sleep(1000);
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

    //        }

    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

    //            Console.WriteLine("Error" + e.ToString());
    //        }

    //        //Clicking on save
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Maintenance link
    //        //MaintenanceLink.Click();            

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Navigating to Maintenance to service provider
    //        //verifyDetailPage();

    //        //waiting
    //        Thread.Sleep(1000);

    //        //Picking a job and quoting the price
    //        pick_Job();

    //        //Finalize the quote
    //        selectQuote();

    //        Thread.Sleep(2000);

    //        //Validating the column names and buttons 
    //        ValidateColumnNameAndButtons();


    //    }

    //    //Method to pick a job
    //    private void pick_Job()
    //    {

    //        //Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Navigating to Pick job to provide a quote
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(10, "Locator"), ExcelLib.ReadData(10, "Value"));

    //        //Searching for the new job 
    //        //SearchTextBox.SendKeys(ExcelLib.ReadData(2, "JobDescription"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));

    //        //Search Button click
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        try
    //        {
    //            IList jobList = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //            int jobListCount = jobList.Count;
    //            int count = 0;
    //            String propertyName;
    //            String jobDesc;
    //            String statusOfJob;

    //            if (jobListCount == 1)
    //            {
    //                jobDesc = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[1]")).Text;
    //                propertyName = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[2]")).Text;
    //                statusOfJob = Driver.driver.FindElement(By.XPath("//*[@id='propList']/tr/td[3]")).Text;
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, jobDesc + propertyName + statusOfJob);

    //                if (jobDesc == ExcelLib.ReadData(RowCountBase, "JobDescription") &&
    //                   propertyName == ExcelLib.ReadData(RowCountBase, "PropertyName") &&
    //                   statusOfJob == ExcelLib.ReadData(5, "JobStatus"))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Applying for the job. Quote the price");

    //                    //Clicking on Action Dropdown
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));

    //                    Thread.Sleep(1000);

    //                    ////Apply button click
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(17, "Locator"), ExcelLib.ReadData(17, "Value"));

    //                    //waiting
    //                    Thread.Sleep(2000);

    //                    //Entering the quote amount
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "QuoteAmount"));

    //                    //Entering the Notes
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "Note"));

    //                    //Clicking on save
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));

    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Job Applied");

    //                }
    //                count++;

    //            }

    //            if (count == 0)
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "More than one search result");
    //                for (int i = 1; i < jobListCount + 1; i++)
    //                {
    //                    Thread.Sleep(500);
    //                    jobDesc = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text;

    //                    //To store the propertyName in a string we are clicking on "Detail" to find that out
    //                    propertyName = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text;

    //                    //status of the job
    //                    statusOfJob = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;

    //                    Thread.Sleep(500);
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, jobDesc + propertyName + statusOfJob);

    //                    if (jobDesc == ExcelLib.ReadData(RowCountBase, "JobDescription") &&
    //                      propertyName == ExcelLib.ReadData(RowCountBase, "PropertyName") &&
    //                      statusOfJob == ExcelLib.ReadData(5, "JobStatus"))
    //                    {
    //                        //Clicking on Action Dropdown
    //                        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/button")).Click();

    //                        Thread.Sleep(1000);

    //                        ////Apply button click
    //                        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/ul/li[9]/a")).Click();

    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Applying for the job. Quote the price");

    //                        //waiting
    //                        Thread.Sleep(2000);

    //                        //Entering the quote amount
    //                        Driver.Textbox(Driver.driver, ExcelLib.ReadData(18, "Locator"), ExcelLib.ReadData(18, "Value"), ExcelLib.ReadData(RowCountBase, "QuoteAmount"));

    //                        //Entering the Notes
    //                        Driver.Textbox(Driver.driver, ExcelLib.ReadData(19, "Locator"), ExcelLib.ReadData(19, "Value"), ExcelLib.ReadData(RowCountBase, "Note"));

    //                        //Clicking on save
    //                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(20, "Locator"), ExcelLib.ReadData(20, "Value"));

    //                        break;
    //                    }
    //                }
    //            }
    //        }
    //        catch
    //        {
    //            try
    //            {
    //                if (Driver.driver.FindElement(By.XPath(".//*[@id='NoProperty']/div/div")).Displayed)
    //                {
    //                    if (Driver.driver.FindElement(By.XPath(".//*[@id='NoProperty']/div/div/div[1]/p[2]")).Text == ExcelLib.ReadData(RowCountBase, "JobDescription"))
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "No Records Found. Test Failed");
    //                        //Clicking on OK
    //                        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(13, "Locator"), ExcelLib.ReadData(13, "Value"));
    //                    }
    //                    else
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Error, "Error in validation");

    //                }
    //            }
    //            catch
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Not displaying no results found");
    //            }
    //        }


    //    }

    //    //Selecting the best quote
    //    private void selectQuote()
    //    {
    //        //Waiting
    //        Thread.Sleep(2000);

    //        //Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Property1 Manager Link to finalize the quote
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

    //        //Searching for the job description
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));

    //        //Click on search
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

    //        //Waiting
    //        Thread.Sleep(2000);

    //        //Select a quote from the service provider
    //        //View quote click
    //        IList jobListinPropManager = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //        int jobListCountinPropManager = jobListinPropManager.Count;
    //        String jobStatusinPropManager;
    //        String jobDescinPropManager;
    //        String PropNameinPropManager;
    //        int count = 0;

    //        if (jobListCountinPropManager == 1)
    //        {
    //            jobDescinPropManager = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[1]")).Text;
    //            PropNameinPropManager = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[2]")).Text;
    //            jobStatusinPropManager = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;
    //            if (jobStatusinPropManager == ExcelLib.ReadData(5, "JobStatus") &&
    //             jobDescinPropManager == ExcelLib.ReadData(RowCountBase, "JobDescription")
    //             && PropNameinPropManager == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //            {
    //                //Clicking on Action Dropdown
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));

    //                Thread.Sleep(1000);

    //                //Clicking on View Quote button
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(25, "Locator"), ExcelLib.ReadData(25, "Value"));
    //            }
    //            count++;

    //        }

    //        if (count == 0)
    //        {
    //            for (int i = 1; i < jobListCountinPropManager + 1; i++)
    //            {
    //                jobDescinPropManager = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text;
    //                PropNameinPropManager = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text;
    //                jobStatusinPropManager = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;
    //                if (jobStatusinPropManager == ExcelLib.ReadData(5, "JobStatus") &&
    //                    jobDescinPropManager == ExcelLib.ReadData(RowCountBase, "JobDescription")
    //                    && PropNameinPropManager == ExcelLib.ReadData(RowCountBase, "PropertyName"))
    //                {
    //                    //Clicking on Action Dropdown
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/button")).Click();

    //                    Thread.Sleep(1000);

    //                    //Clicking on View Quote button
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/ul/li[10]/a")).Click();

    //                    break;
    //                }
    //            }
    //        }

    //        //waiting
    //        Thread.Sleep(2000);

    //        //selecting the quote that has less cost

    //        IList quoteList = Driver.driver.FindElements(By.XPath("//*[@id='propList']/tr"));
    //        int quoteCount = quoteList.Count;
    //        IList priceList = new ArrayList();
    //        int[] number = new int[quoteList.Count];
    //        int count1 = 0;

    //        //only one quote
    //        if (quoteCount == 1)
    //        {
    //            //Clicking on Action Dropdown
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(26, "Locator"), ExcelLib.ReadData(26, "Value"));

    //            Thread.Sleep(2000);

    //            //Clicking on Select button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(27, "Locator"), ExcelLib.ReadData(27, "Value"));

    //            count1++;
    //        }

    //        if (count1 == 0)
    //        {
    //            //more than one quote
    //            for (int i = 1; i < quoteCount + 1; i++)
    //            {
    //                String first = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]")).Text;
    //                priceList.Add(first);
    //            }


    //            //Debug.WriteLine(priceList);

    //            for (int i = 0; i < priceList.Count; i++)
    //            {
    //                try
    //                {
    //                    number[i] = Int32.Parse(priceList[i].ToString());

    //                }
    //                catch
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Quote is in string. Incorrect input format encountered");
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Test case fails since quote is not in proper format");
    //                }
    //            }


    //            String minQuote = number.Min().ToString();

    //            for (int i = 1; i < quoteCount + 1; i++)
    //            {
    //                String min = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]")).Text;
    //                if (min == minQuote)
    //                {
    //                    //Clicking on Action Dropdown
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/button")).Click();

    //                    Thread.Sleep(2000);

    //                    //Clicking on Select button
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/ul/li[4]/a")).Click();

    //                    break;
    //                }
    //            }
    //        }
    //    }

    //    //Validating the column name and buttons
    //    public void ValidateColumnNameAndButtons()
    //    {
    //        Driver.wait(2000);

    //        //Moving on to the service provider to start the job
    //        //Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

    //        //Waiting
    //        Thread.Sleep(2000);

    //        //Clicking on service provider link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Validating the column names
    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(29, "Locator"), ExcelLib.ReadData(29, "Value")) == ExcelLib.ReadData(6, "ColumnsForServProvider") &&
    //          Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(30, "Locator"), ExcelLib.ReadData(30, "Value")) == ExcelLib.ReadData(7, "ColumnsForServProvider") &&
    //          Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(31, "Locator"), ExcelLib.ReadData(31, "Value")) == ExcelLib.ReadData(8, "ColumnsForServProvider") &&
    //          Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(32, "Locator"), ExcelLib.ReadData(32, "Value")) == ExcelLib.ReadData(9, "ColumnsForServProvider"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Headers in Service Provider Page are in place");
    //        }

    //        //Clicking on action button to validate the Details button
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));
    //        Thread.Sleep(4000);


    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value")).Trim() == ExcelLib.ReadData(10, "ColumnsForServProvider"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Details button in Service Provider Page are in place");
    //        }

    //        //waiting
    //        Thread.Sleep(5000);

    //        Driver.driver.Navigate().Refresh();


    //        // String PageNumber = PageNumberinSerProvider.Text.Substring(10, 2);

    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "PageNumber" + PageNumber);

    //        //Searching for that job which is to be started
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));

    //        //Search button
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

    //        //waiting
    //        Thread.Sleep(2000);

    //        IList jobListforSerProvider = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //        int jobCountforServProvider = jobListforSerProvider.Count;
    //        String jobDescforServProvider;
    //        String propNameforServProvider;
    //        String jobStatusforServProvider;
    //        String StartbuttonForServProvider;
    //        String FinishbuttonForServProvider;
    //        int count = 0;

    //        //if only one entry 
    //        if (jobCountforServProvider == 1)
    //        {
    //            jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[1]")).Text;
    //            propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[2]")).Text;
    //            jobStatusforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;

    //            if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //            propNameforServProvider == ExcelLib.ReadData(2, "PropertyName") &&
    //            jobStatusforServProvider == ExcelLib.ReadData(3, "JobStatus"))
    //            {
    //                //Clicking on Action button
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));

    //                //waiting 
    //                Thread.Sleep(2000);

    //                StartbuttonForServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]/div/ul/li[7]/a")).Text;

    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Start button "+ StartbuttonForServProvider);
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Start button " + ExcelLib.ReadData(11, "ColumnsForServProvider"));

    //                if (StartbuttonForServProvider.Trim() == ExcelLib.ReadData(11, "ColumnsForServProvider"))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Start button in Service Provider Page is in place");
    //                }

    //                //clicking on start button
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(35, "Locator"), ExcelLib.ReadData(35, "Value"));
    //                //increasing the count

    //                count++;
    //            }

    //        }

    //        if (count == 0)
    //        {
    //            //Starting the work
    //            for (int i = 1; i < jobCountforServProvider + 1; i++)
    //            {
    //                jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text;
    //                propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text;
    //                jobStatusforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;

    //                if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //                propNameforServProvider == ExcelLib.ReadData(2, "PropertyName") &&
    //                jobStatusforServProvider == ExcelLib.ReadData(3, "JobStatus"))
    //                {
    //                    StartbuttonForServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/a[4]")).Text;
    //                    if (StartbuttonForServProvider.Trim() == ExcelLib.ReadData(11, "ColumnsForServProvider"))
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Start button in Service Provider Page is in place");
    //                    }
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/a[4]")).Click();

    //                    //waiting
    //                    Thread.Sleep(2000);

    //                    //Enterting text in search textbox
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //                    //Search button
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

    //                }
    //            }
    //        }

    //        if (count != 0)
    //        {
    //            //Enterting text in search textbox
    //            Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //            //Search button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

    //            //click on the action dropdown
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));

    //            //click on details button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"));
    //        }

    //        if (count == 0)
    //        {
    //            //click on the action dropdown
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));

    //            //click on details button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));
    //        }

    //        //waiting
    //        Thread.Sleep(500);
    //        //Debug.WriteLine(DetailPageHeaderInServProvider.Text);            


    //        //Checking the Header for the Details button
    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(36, "Locator"), ExcelLib.ReadData(36, "Value")) == ExcelLib.ReadData(2, "HeaderName"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Header for Detail Button in Service Provider is in place");
    //        }
    //        //Waiting
    //        Thread.Sleep(500);

    //        //Validating the field names for View Detail
    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(37, "Locator"), ExcelLib.ReadData(37, "Value")) == ExcelLib.ReadData(13, "ColumnsForServProvider") &&
    //         Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(38, "Locator"), ExcelLib.ReadData(38, "Value")) == ExcelLib.ReadData(14, "ColumnsForServProvider") &&
    //         Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(39, "Locator"), ExcelLib.ReadData(39, "Value")) == ExcelLib.ReadData(15, "ColumnsForServProvider") &&
    //         Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(40, "Locator"), ExcelLib.ReadData(40, "Value")) == ExcelLib.ReadData(16, "ColumnsForServProvider") &&
    //         Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(41, "Locator"), ExcelLib.ReadData(41, "Value")) == ExcelLib.ReadData(17, "ColumnsForServProvider") &&
    //         Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(42, "Locator"), ExcelLib.ReadData(42, "Value")) == ExcelLib.ReadData(18, "ColumnsForServProvider"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The View Detail page has the proper fields");
    //        }

    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(45, "Locator"), ExcelLib.ReadData(45, "Value")));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ExcelLib.ReadData(2, "JobDescription"));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(46, "Locator"), ExcelLib.ReadData(46, "Value")));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ExcelLib.ReadData(2, "PropertyName"));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(47, "Locator"), ExcelLib.ReadData(47, "Value")));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ExcelLib.ReadData(4, "JobStatus"));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(48, "Locator"), ExcelLib.ReadData(48, "Value")));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ExcelLib.ReadData(2, "QuoteAmount"));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(49, "Locator"), ExcelLib.ReadData(49, "Value")));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, DateTime.Now.ToString("MMMM d, yyyy"));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(50, "Locator"), ExcelLib.ReadData(50, "Value")));
    //        //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ExcelLib.ReadData(19, "ColumnsForServProvider"));

    //        //Validating the details in the View Detail page
    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(45, "Locator"), ExcelLib.ReadData(45, "Value")) == ExcelLib.ReadData(2, "JobDescription") &&
    //           Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(46, "Locator"), ExcelLib.ReadData(46, "Value")) == ExcelLib.ReadData(2, "PropertyName") &&
    //           Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(47, "Locator"), ExcelLib.ReadData(47, "Value")) == ExcelLib.ReadData(4, "JobStatus") &&
    //           Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(48, "Locator"), ExcelLib.ReadData(48, "Value")) == "$" + ExcelLib.ReadData(2, "MaximumBudget") &&
    //           Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(49, "Locator"), ExcelLib.ReadData(49, "Value")) == DateTime.Now.ToString("MMMM d, yyyy") &&
    //           Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(50, "Locator"), ExcelLib.ReadData(50, "Value")) == ExcelLib.ReadData(19, "ColumnsForServProvider"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The View Detail page has been populated correctly");
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "The end date has not yet been updated properly");
    //        }

    //        //Closing view details
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(44, "Locator"), ExcelLib.ReadData(44, "Value"));
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The Close button in View details page is working properly");

    //        //Sleep
    //        Thread.Sleep(500);

    //        if (count == 0)
    //        {
    //            //click on the action dropdown
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));

    //            //click on details button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(33, "Locator"), ExcelLib.ReadData(33, "Value"));
    //        }

    //        if (count != 0)
    //        {
    //            //click on the action dropdown
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(24, "Locator"), ExcelLib.ReadData(24, "Value"));

    //            //click on details button
    //            Driver.ActionButton(Driver.driver, ExcelLib.ReadData(43, "Locator"), ExcelLib.ReadData(43, "Value"));
    //        }

    //        //waiting
    //        Thread.Sleep(500);

    //        //Clicking on "X" button
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(51, "Locator"), ExcelLib.ReadData(51, "Value"));
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The X button in View details page is working properly");

    //        //Finishing the work
    //        if (count == 0)
    //        {
    //            for (int i = 1; i < jobCountforServProvider + 1; i++)
    //            {
    //                jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[1]")).Text;
    //                propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[2]")).Text;
    //                jobStatusforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;

    //                if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //                propNameforServProvider == ExcelLib.ReadData(2, "PropertyName") &&
    //                jobStatusforServProvider == ExcelLib.ReadData(4, "JobStatus"))
    //                {
    //                    FinishbuttonForServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/ul/li[8]/a")).Text;
    //                    if (FinishbuttonForServProvider.Trim() == ExcelLib.ReadData(12, "ColumnsForServProvider"))
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Finish button in Service Provider Page is in place");
    //                    }
    //                    Thread.Sleep(1000);

    //                    //click on the action dropdown
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));

    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]/div/ul/li[8]/a")).Click();
    //                    i--;
    //                    jobCountforServProvider--;

    //                    //Enterting text in search textbox
    //                    Driver.Textbox(Driver.driver, ExcelLib.ReadData(11, "Locator"), ExcelLib.ReadData(11, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));
    //                    //Search button
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(12, "Locator"), ExcelLib.ReadData(12, "Value"));

    //                    Thread.Sleep(500);

    //                }
    //            }
    //        }

    //        if (count != 0)
    //        {
    //            jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[1]")).Text;
    //            propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[2]")).Text;
    //            jobStatusforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;

    //            if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //               propNameforServProvider == ExcelLib.ReadData(2, "PropertyName") &&
    //               jobStatusforServProvider == ExcelLib.ReadData(4, "JobStatus"))
    //            {
    //                FinishbuttonForServProvider = Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value"));
    //                Thread.Sleep(2000);
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value")));
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ExcelLib.ReadData(12, "ColumnsForServProvider"));
    //                if (FinishbuttonForServProvider.Trim() == ExcelLib.ReadData(12, "ColumnsForServProvider") || FinishbuttonForServProvider.Trim() == "")
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Finish button in Service Provider Page is in place");
    //                }
    //                Thread.Sleep(1000);

    //                //click on the action dropdown
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(34, "Locator"), ExcelLib.ReadData(34, "Value"));

    //                //Finsihing the job
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(52, "Locator"), ExcelLib.ReadData(52, "Value"));

    //                //Job finished
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Job is finished");
    //            }
    //        }
    //    }

    //    internal void view_my_quote()
    //    {
    //        //Extent Reports
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "In Maintenance page");

    //        //Populating from the excel sheet
    //        ExcelLib.PopulateInCollection(Base.ExcelPath, "ServiceProvider");

    //        //Maximizing the browser
    //        //Driver.driver.Manage().Window.Maximize();

    //        Driver.wait(2000);

    //        //Clicking on Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

    //        Thread.Sleep(2000);

    //        //Clicking on Manage Job for Property1 Manager
    //        //MaintenanceLinkForPropManager.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(3, "Locator"), ExcelLib.ReadData(3, "Value"));

    //        //Clicking on add new Job
    //        //AddNewJob.Click();
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(4, "Locator"), ExcelLib.ReadData(4, "Value"));

    //        //Waiting
    //        Thread.Sleep(1000);

    //        //Entering the job description
    //        //JobDescription.SendKeys(ExcelLib.ReadData(2, "JobDescription"));
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(5, "Locator"), ExcelLib.ReadData(5, "Value"), ExcelLib.ReadData(RowCountBase, "JobDescription"));

    //        //Maximum Budget
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(6, "Locator"), ExcelLib.ReadData(6, "Value"), ExcelLib.ReadData(RowCountBase, "MaximumBudget"));

    //        //Selecting the property
    //        var propelement = Driver.driver.FindElement(By.XPath("//*[@id='jobFormModal']/div/div/div/div[2]/form/div[4]/div/select"));
    //        var propselect = new SelectElement(propelement);
    //        propselect.SelectByText(ExcelLib.ReadData(RowCountBase, "PropertyName"));


    //        //Upload Photo
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(8, "Locator"), ExcelLib.ReadData(8, "Value"));
    //        try
    //        {
    //            // File upload begins here

    //            AutoItX3 autoIt = new AutoItX3();
    //            autoIt.WinActivate("Open");
    //            Thread.Sleep(1000);
    //            //  autoIt.Send(@"E:\KEYS\property1.jpg");
    //            autoIt.Send(ExcelLib.ReadData(RowCountBase, "PhotoPath"));
    //            Thread.Sleep(1000);
    //            autoIt.Send("{Enter}");
    //            Thread.Sleep(1000);
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Selected photo to upload");

    //        }

    //        catch (Exception e)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Photo upload Failed");

    //            Console.WriteLine("Error" + e.ToString());
    //        }

    //        //Clicking on save
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(9, "Locator"), ExcelLib.ReadData(9, "Value"));

    //        //Waiting
    //        Thread.Sleep(2000);

    //        //pick job - applying
    //        pick_Job();

    //        //waiting
    //        Thread.Sleep(2000);

    //        //Navigating to Serv Provider

    //        //Clicking on Maintenance link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(2, "Locator"), ExcelLib.ReadData(2, "Value"));

    //        //waiting
    //        Thread.Sleep(2000);

    //        //Serv Provider Link
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(28, "Locator"), ExcelLib.ReadData(28, "Value"));

    //        //sleep
    //        Thread.Sleep(500);

    //        //Click on View my Quote 53
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));

    //        //Sleep
    //        Thread.Sleep(2000);

    //        //last page
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));

    //        //Sleep
    //        Thread.Sleep(3000);

    //        //*[@id="propList"]/tr[1]/td[3]
    //        IList myQuoteforSerProvider = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //        int myQuoteCountforServProvider = myQuoteforSerProvider.Count;
    //        String jobDescforServProvider;
    //        String quoteAmountforServProvider;
    //        String propNameforServProvider;

    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "myQuoteCountforServProvider" + myQuoteCountforServProvider);

    //        if (myQuoteCountforServProvider == 1)
    //        {
    //            jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;
    //            quoteAmountforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]")).Text;
    //            propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[5]")).Text;


    //            if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //               quoteAmountforServProvider == ExcelLib.ReadData(2, "QuoteAmount") &&
    //               propNameforServProvider == ExcelLib.ReadData(2, "PropertyName"))
    //            {
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/button")).Click();

    //                //Details button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/ul/li[1]/a")).Click();

    //                //waiting
    //                Thread.Sleep(2000);

    //                verifyLabelandDetails();

    //                //sleep
    //                Thread.Sleep(2000);

    //                //Action Button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/button")).Click();

    //                //Details button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/ul/li[1]/a")).Click();

    //                //waiting
    //                Thread.Sleep(2000);

    //                //X button
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(66, "Locator"), ExcelLib.ReadData(66, "Value"));
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The X button in View my Quote - Details is working properly");

    //                //waiting
    //                Thread.Sleep(1000);

    //                //Action Button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/button")).Click();

    //                //Edit button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/ul/li[3]/a")).Click();

    //                //waiting
    //                Thread.Sleep(4000);

    //                //Entering the new quote
    //                Driver.Textbox(Driver.driver, ExcelLib.ReadData(67, "Locator"), ExcelLib.ReadData(67, "Value"), ExcelLib.ReadData(RowCountBase, "EditQuote"));

    //                //Notes
    //                Driver.Textbox(Driver.driver, ExcelLib.ReadData(68, "Locator"), ExcelLib.ReadData(68, "Value"), ExcelLib.ReadData(RowCountBase, "Note"));

    //                //Save button
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(69, "Locator"), ExcelLib.ReadData(69, "Value"));

    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The value is edited");

    //            }
    //        }

    //        if (myQuoteCountforServProvider != 1)
    //        {
    //            for (int i = 1; i < myQuoteCountforServProvider + 1; i++)
    //            {
    //                //*[@id="propList"]/tr[1]/td[3]//*[@id="propList"]/tr[1]/td[3]//*[@id="propList"]/tr[1]/td[4]//*[@id="propList"]/tr[1]/td[5]
    //                jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ".//*[@id='propList']/tr[" + i + "]/td[3]");
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ".//*[@id='propList']/tr[" + i + "]/td[4]");
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, ".//*[@id='propList']/tr[" + i + "]/td[5]");
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "jobDescforServProvider" + jobDescforServProvider);
    //                quoteAmountforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]")).Text;
    //                // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "quoteAmountforServProvider" + quoteAmountforServProvider);
    //                propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[5]")).Text;
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "propNameforServProvider" + propNameforServProvider);

    //                if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //                   quoteAmountforServProvider == ExcelLib.ReadData(2, "QuoteAmount") &&
    //                   propNameforServProvider == ExcelLib.ReadData(2, "PropertyName"))
    //                {

    //                    verifyDetailsEdit(i);
    //                    break;
    //                }
    //            }
    //        }

    //        //waiting
    //        Thread.Sleep(2000);

    //        //Clicking on View my quote
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(53, "Locator"), ExcelLib.ReadData(53, "Value"));

    //        //Navigating to last page
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));

    //        //waiting
    //        Thread.Sleep(3000);

    //        if (myQuoteCountforServProvider == 1)
    //        {
    //            jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;
    //            quoteAmountforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]")).Text;
    //            // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "quoteAmountforServProvider" + quoteAmountforServProvider);
    //            propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[5]")).Text;
    //            //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "propNameforServProvider" + propNameforServProvider);

    //            if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //             quoteAmountforServProvider == ExcelLib.ReadData(2, "EditQuote") &&
    //             propNameforServProvider == ExcelLib.ReadData(2, "PropertyName"))
    //            {
    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edit is working properly");

    //                //Action button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/button")).Click();

    //                //Delete button
    //                Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[6]/div/ul/li[6]/a")).Click();

    //                //waiting
    //                Thread.Sleep(2000);

    //                //Checking the label

    //                if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(70, "Locator"), ExcelLib.ReadData(70, "Value")) == ExcelLib.ReadData(25, "ColumnsForServProvider"))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete confirmation message is correct");
    //                }

    //                //Yes Delete
    //                Driver.ActionButton(Driver.driver, ExcelLib.ReadData(71, "Locator"), ExcelLib.ReadData(71, "Value"));

    //                Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record is deleted");

    //            }
    //        }

    //        if (myQuoteCountforServProvider != 1)
    //        {
    //            for (int i = 1; i < myQuoteCountforServProvider + 1; i++)
    //            {
    //                //*[@id="propList"]/tr[1]/td[3]//*[@id="propList"]/tr[1]/td[3]//*[@id="propList"]/tr[1]/td[4]//*[@id="propList"]/tr[1]/td[5]
    //                jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;
    //                quoteAmountforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]")).Text;
    //                // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "quoteAmountforServProvider" + quoteAmountforServProvider);
    //                propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[5]")).Text;
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "propNameforServProvider" + propNameforServProvider);

    //                if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //                   quoteAmountforServProvider == ExcelLib.ReadData(2, "EditQuote") &&
    //                   propNameforServProvider == ExcelLib.ReadData(2, "PropertyName"))
    //                {
    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Edit is working properly");

    //                    //Action button
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/button")).Click();

    //                    //Delete button
    //                    Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/ul/li[6]/a")).Click();

    //                    //waiting
    //                    Thread.Sleep(2000);

    //                    //Checking the label

    //                    if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(70, "Locator"), ExcelLib.ReadData(70, "Value")) == ExcelLib.ReadData(25, "ColumnsForServProvider"))
    //                    {
    //                        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete confirmation message is correct");
    //                    }

    //                    //Yes Delete
    //                    Driver.ActionButton(Driver.driver, ExcelLib.ReadData(71, "Locator"), ExcelLib.ReadData(71, "Value"));

    //                    Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Record is deleted");
    //                    break;
    //                }

    //            }
    //        }
    //        //waiting
    //        Thread.Sleep(2000);

    //        //last page
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(54, "Locator"), ExcelLib.ReadData(54, "Value"));

    //        //waiting
    //        Thread.Sleep(3000);

    //        myQuoteforSerProvider = Driver.driver.FindElements(By.XPath(".//*[@id='propList']/tr"));
    //        myQuoteCountforServProvider = myQuoteforSerProvider.Count;
    //        int deleteCount = 0;

    //        if (myQuoteCountforServProvider == 1)
    //        {
    //            jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[3]")).Text;
    //            quoteAmountforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[4]")).Text;
    //            // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "quoteAmountforServProvider" + quoteAmountforServProvider);
    //            propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr/td[5]")).Text;
    //            //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "propNameforServProvider" + propNameforServProvider);

    //            if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //               quoteAmountforServProvider == ExcelLib.ReadData(2, "EditQuote") &&
    //               propNameforServProvider == ExcelLib.ReadData(2, "PropertyName"))
    //            {
    //                deleteCount++;
    //            }
    //        }

    //        if (myQuoteCountforServProvider != 1)
    //        {
    //            for (int i = 1; i < myQuoteCountforServProvider + 1; i++)
    //            {
    //                jobDescforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[3]")).Text;
    //                quoteAmountforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[4]")).Text;
    //                // Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "quoteAmountforServProvider" + quoteAmountforServProvider);
    //                propNameforServProvider = Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[5]")).Text;
    //                //Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "propNameforServProvider" + propNameforServProvider);

    //                if (jobDescforServProvider == ExcelLib.ReadData(2, "JobDescription") &&
    //                   quoteAmountforServProvider == ExcelLib.ReadData(2, "EditQuote") &&
    //                   propNameforServProvider == ExcelLib.ReadData(2, "PropertyName"))
    //                {
    //                    deleteCount++;
    //                }

    //            }
    //        }

    //        if (deleteCount == 0)
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "Delete is working properly");
    //        }
    //        else
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Fail, "Delete is not working properly");
    //        }
    //    }

    //    //Verifying the Details and editing
    //    private void verifyDetailsEdit(int i)
    //    {
    //        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/button")).Click();

    //        //Details button
    //        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/ul/li[1]/a")).Click();

    //        //waiting
    //        Thread.Sleep(2000);

    //        //Verifying the labels and details
    //        verifyLabelandDetails();

    //        //sleep
    //        Thread.Sleep(2000);

    //        //Action Button
    //        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/button")).Click();

    //        //Details button
    //        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/ul/li[1]/a")).Click();

    //        //waiting
    //        Thread.Sleep(2000);

    //        //X button
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(66, "Locator"), ExcelLib.ReadData(66, "Value"));
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The X button in View my Quote - Details is working properly");

    //        //waiting
    //        Thread.Sleep(1000);

    //        //Action Button
    //        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/button")).Click();

    //        //Edit button
    //        Driver.driver.FindElement(By.XPath(".//*[@id='propList']/tr[" + i + "]/td[6]/div/ul/li[3]/a")).Click();

    //        //waiting
    //        Thread.Sleep(4000);

    //        //Entering the new quote
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(67, "Locator"), ExcelLib.ReadData(67, "Value"), ExcelLib.ReadData(RowCountBase, "EditQuote"));

    //        //Notes
    //        Driver.Textbox(Driver.driver, ExcelLib.ReadData(68, "Locator"), ExcelLib.ReadData(68, "Value"), ExcelLib.ReadData(RowCountBase, "Note"));

    //        //Save button
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(69, "Locator"), ExcelLib.ReadData(69, "Value"));

    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The value is edited");

    //    }

    //    //To verify the label and the details
    //    private static void verifyLabelandDetails()
    //    {
    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(55, "Locator"), ExcelLib.ReadData(55, "Value")) == ExcelLib.ReadData(20, "ColumnsForServProvider") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(56, "Locator"), ExcelLib.ReadData(56, "Value")) == ExcelLib.ReadData(21, "ColumnsForServProvider") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(57, "Locator"), ExcelLib.ReadData(57, "Value")) == ExcelLib.ReadData(22, "ColumnsForServProvider") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(58, "Locator"), ExcelLib.ReadData(58, "Value")) == ExcelLib.ReadData(23, "ColumnsForServProvider") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(59, "Locator"), ExcelLib.ReadData(59, "Value")) == ExcelLib.ReadData(24, "ColumnsForServProvider"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The labels in View my Quote - Details are populated correctly");
    //        }

    //        if (Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(60, "Locator"), ExcelLib.ReadData(60, "Value")) == ExcelLib.ReadData(2, "ProviderName") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(61, "Locator"), ExcelLib.ReadData(61, "Value")) == ExcelLib.ReadData(2, "CompanyName") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(62, "Locator"), ExcelLib.ReadData(62, "Value")) == ExcelLib.ReadData(2, "JobDescription") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(63, "Locator"), ExcelLib.ReadData(63, "Value")) == ExcelLib.ReadData(2, "PropertyName") &&
    //            Driver.GetTextValue(Driver.driver, ExcelLib.ReadData(64, "Locator"), ExcelLib.ReadData(64, "Value")) == ExcelLib.ReadData(2, "QuoteAmount"))
    //        {
    //            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The details in View my Quote - Details are populated correctly");
    //        }

    //        //Close button
    //        Driver.ActionButton(Driver.driver, ExcelLib.ReadData(65, "Locator"), ExcelLib.ReadData(65, "Value"));
    //        Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Pass, "The close button in View my Quote - Details is working properly");
    //    }

    //    //Janani code changes end

    //}
    #endregion
}
