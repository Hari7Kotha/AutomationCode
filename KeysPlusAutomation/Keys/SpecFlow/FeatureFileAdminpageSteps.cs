using Keys.Pages;
using Keys.Global;

using RelevantCodes.ExtentReports;
using System;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports.Model;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
//using RelevantCodes.ExtentReports.Model;

namespace Keys.SpecFlow
{
    [Binding]
    public class FeatureFileAdminpageSteps : Base
    {
    
    [BeforeScenario]
    public void BeforeScenario()
    {

        // advisasble to read this documentation before proceeding http://extentreports.relevantcodes.com/net/
        switch (Browser)
        {
            case 1:
                Driver.driver = new FirefoxDriver();
                break;
            case 2:
                    //ChromeOptions options = new ChromeOptions();
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
   
        [Given(@"User have logged into keys application")]
        
        
        public void GivenUserHaveLoggedIntoKeysApplication()
        {
           
        }
        
        [Then(@"User will be navigated to Admin module")]
        public void ThenUserWillBeNavigatedToAdminModule()
        {
            test = extent.StartTest("Admin page navigation");
            Admin adminpageobj = new Admin();
            adminpageobj.Adminpage();
           // Base.TearDown();
        }

        [Then(@"User details are edited and saved")]
        public void ThenUserDetailsAreEditedAndSaved()
        {
            test = extent.StartTest("Editing user details");
            Admin editpageobj = new Admin();
            editpageobj.Adminpage();
            editpageobj.adminedit2();
        }

        [Then(@"Field validation messages are displayed for invalid data")]
        public void ThenFieldValidationMessagesAreDisplayedForInvalidData()
        {
            test = extent.StartTest("Field validations");
            Admin validationobj = new Admin();
            validationobj.Adminpage();

            validationobj.adminfieldval();
        }


        [AfterScenario]

    public void AfterScenario()
        {
            // Screenshot
            String img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");//AddScreenCapture(@"E:\Dropbox\VisualStudio\Projects\Beehive\TestReports\ScreenShots\");
            test.Log(LogStatus.Info, "Image example: " + img);
            // end test. (Reports)
            extent.EndTest(test);
            // calling Flush writes everything to the log file (Reports)
            extent.Flush();
            // Close the driver :)            
            Driver.driver.Close();
        }

    }
}
