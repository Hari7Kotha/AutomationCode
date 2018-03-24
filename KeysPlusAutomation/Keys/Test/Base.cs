using Keys.Global;
using Keys.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using System;

namespace Keys
{

    //[TestFixture]
    public abstract class Base
    {

        #region To access Path from resource file

        public static int Browser = Int32.Parse(KeysResource.Browser);
        public static String ExcelPath = KeysResource.ExcelPath;
        public static string ScreenshotPath = KeysResource.ScreenShotPath;
        public static string ReportPath = KeysResource.ReportPath;
        public static int RowCountBase = Int32.Parse(KeysResource.RowNum);
        public static int LoginBase = Int32.Parse(KeysResource.Login);
        //#endregion

        #region reports
        public static ExtentTest test;
        public static ExtentReports extent;
        #endregion

        #region setup and tear down
        [SetUp]
        public void Inititalize()
        {

            // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
            switch (Browser)
            {
                case 1:
                    Driver.driver = new FirefoxDriver();
                    break;
                case 2:
                    
                    var options = new ChromeOptions();

                    options.AddArguments("--disable-extensions --disable-extensions-file-access-check --disable-extensions-http-throttling --disable-infobars --enable-automation --start-maximized");
                    options.AddUserProfilePreference("credentials_enable_service", false);
                    options.AddUserProfilePreference("profile.password_manager_enabled", false);
                    Driver.driver = new ChromeDriver(options);

                    //Driver.driver = new ChromeDriver();
                    //Driver.driver.Manage().Window.Maximize();
                    break;

            }
            if (KeysResource.IsLogin == "true")
            {
                Login loginobj = new Login();
                loginobj.LoginSuccessfull();
            }
            else
            {
                Register obj = new Register();
                obj.Navigateregister();
            }
            extent = new ExtentReports(ReportPath, true, DisplayOrder.OldestFirst);
            extent.LoadConfig(KeysResource.ReportXMLPath);
        }


        [TearDown]
        public void TearDown()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            //Driver.driver.Close();
        }
        #endregion
    }
}

#endregion