using Keys.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Keys.Pages
{
    class Test
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='Cname']")]
        private IWebElement CompanyName { get; set; }
        internal void CompanyInvalidDataValidation1()
        {

            //Handle popup
            int i = 1;

            //Handle Popup

            string existingWindowHandle = Driver.driver.CurrentWindowHandle;
            Driver.driver.FindElement(By.XPath("//*[@id='compList']/tr[" + i + "]/td[3]/button[3]")).Click();

            //wait for new window to open 
            Thread.Sleep(2000);

            //get the current window handles 
            string popupHandle = string.Empty;
            ReadOnlyCollection<string> windowHandles = Driver.driver.WindowHandles;

            foreach (string handle in windowHandles)
            {
                if (handle != existingWindowHandle)
                {
                    popupHandle = handle; break;
                }
            }

            //switch to new window 
            Driver.driver.SwitchTo().Window(popupHandle);
            Driver.wait(5);
            //check for element on new page 
            Driver.driver.FindElement(By.XPath("//*[@id='removemodal']/div/div/div[3]/form/input")).Click();

            //close the new window to navigate to the previous one
            //driver.close();

            //switch back to original window 
            Driver.driver.SwitchTo().Window(existingWindowHandle);
            Base.test.Log(RelevantCodes.ExtentReports.LogStatus.Info, "Able to Delete record");


            var regexItem = new Regex("^[a-zA-Z0-9]*$");

            //To check for Alphanumeric in the text
            const string charexpr = "a-zA-Z";
            const string numexpr = @"0-9";
            string txtnum = CompanyName.Text;
            if (Regex.Match(txtnum, @"^(?=[" + numexpr + @"]*?[" + charexpr + @"]+)(?=[" + charexpr + @"]*?[" + numexpr + @"]+)[" + charexpr + numexpr + @"]+$").Success)// || Regex.Match(txtnum, @"^[" + charexpr + @"]+$").Success)

            {
                //Code to be executed

            }
           
            Regex rg = new Regex(@"^[-!$%^&*()_+|~=`{}\[\]:;'<>?,.\/]*$");
            rg.IsMatch(txtnum);
            //
            //|| Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)

            //doesnot validate if only chars
            //|| !Regex.Match(txtnum, @"^(?=[" + numSet + @"]*?[" + charSet + @"]+)(?=[" + charSet + @"]*?[" + numSet + @"]+)[" + charSet + numSet + @"]+$").Success)
            var list = new[] { "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", "\"" };
            if (list.Any(txtnum.Contains))

            {
                //Code to be executed
            }
        }
    }
}
