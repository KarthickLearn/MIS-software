using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace MIS
{
    internal class WebLoging
    {
        IWebDriver driver = new ChromeDriver(Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), @"Master Data Base"));


        private WebLoging()
        {

        }

        public static WebLoging obj;
        public static WebLoging Getobj()
        {
            if(obj == null) 
            obj = new WebLoging();

            return obj;

        }


        public void Logintobox(string username, string password)
        {
            //login to Box

            try { 


            driver.Navigate().GoToUrl("https://drchrono.app.box.com/folder/49924279771?s=nvxu2a84p3tspxipncaba2gjpfntwnp9");
            driver.FindElement(By.Id("login-email")).SendKeys(username);
            driver.FindElement(By.Id("login-submit")).Click();
            driver.FindElement(By.Id("password-login")).SendKeys(password);
            driver.FindElement(By.Id("login-submit-password")).Click();
            driver.Manage().Window.Maximize();
                Box2StepVerification box2Step = new Box2StepVerification();
                box2Step.Show();
                
             }
            catch
            {
                MessageBox.Show("Kindly internet connection!!");

            }

        }

        public void Box2stepverifiction(string passcode)
        {
            string box2step = Box2StepVerification.box2setp;
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("input[name='authCode']")).SendKeys(passcode);
            Thread.Sleep(500);
            driver.FindElement(By.CssSelector("button[type='submit']")).Click();
            Thread.Sleep(2000);
                

        }



        public void Filedownload(string fname)    
        {
            // To downlaod a folder from box
            Thread.Sleep(5000);
            string m = driver.FindElement(By.PartialLinkText(fname)).GetAttribute("data-resin-folder_id");
            driver.FindElement(By.CssSelector("div[data-resin-folder_id ='"+ m +"']")).Click();
            driver.FindElement(By.CssSelector("button[aria-label='Download']")).Click();
            
        }



        public void UploadingFIle( string pathfilename, string boxurllink)
        {

            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());

            
            driver.Navigate().GoToUrl(boxurllink);
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector("button[aria-label='New']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("li[tabindex='-1']")).Click();
            
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(pathfilename);
            Thread.Sleep(2000);
            SendKeys.SendWait(@"{Escape}");


        }

        public void LogintoHRMS(string fpath, string afile, string bfile)
        {
            string today = DateTime.Today.AddDays(1).ToString("d").Replace("/", "");
            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://hrms.theglobex.com/Web/Default.aspx");
            driver.FindElement(By.CssSelector("input[id='txt_UserName']")).SendKeys("GB05940");
            driver.FindElement(By.CssSelector("input[id = 'txt_UserPassword']")).SendKeys("Welcome1@");
            driver.FindElement(By.CssSelector("input[id ='btn_login']")).Click();
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector("a[title='Globex Links']")).Click();
            Thread.Sleep(8000);
            driver.FindElement(By.CssSelector("a[id='a_Chrono']")).Click();
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            Thread.Sleep(2000);
            try { 
            driver.FindElement(By.XPath("//*[@id='sidebar-menu']/div/ul/li[5]/a/span[1]")).Click();
            }
            catch { Thread.Sleep(3000); }
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='c7640726-ddaa-4137-9f23-f72802cef598']/li[2]/a/span")).Click();
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys(fpath + "\\"+ bfile);
            driver.FindElement(By.Id("tb_Comment")).SendKeys(bfile);
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//*[@id='c7640726-ddaa-4137-9f23-f72802cef598']/li[1]/a")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("input[type='file']")).SendKeys (fpath + "\\"+ afile);
            driver.FindElement(By.Id("tb_Comment")).SendKeys(afile);
            try { 
            driver.FindElement(By.CssSelector("input[type='submit']")).Click();
            }
            catch
            {
                Thread.Sleep(50000);
            };
             

        }


        public void Chromebrowserclose()
        {


           driver.Quit();


        }

        
        public void DrchronoLogin(string username, string password)
        {
            driver.Navigate().GoToUrl("https://app.drchrono.com/accounts/login/");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            driver.FindElement(By.Id("username")).SendKeys (username);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("password")).SendKeys(password);
            Thread.Sleep(2000);
            driver.FindElement(By.Id("login")).Click();
            Thread.Sleep(5000);
        }

        Excel ex = Excel.Getobj();
        private string pos;

        public void AppVsNoApp()
        {

            App_Vs_Not_App app = new App_Vs_Not_App();



            ((IJavaScriptExecutor)driver).ExecuteScript("window.open();");
            driver.SwitchTo().Window(driver.WindowHandles.Last());
            driver.Navigate().GoToUrl("https://dpierce.drchrono.com/billing/live_claims_feed?page=1&all_doctors=on&all_examrooms=on&all_claim_statuses=on&all_claim_types=on&all_billing_statuses=on&all_appt_profiles=on&patient_id=&payer_name=&payer_id=&start_date=07%2F12%2F2021&end_date=08%2F12%2F2021");
            Thread.Sleep(5000);
            driver.FindElement(By.Id("switch-button")).Click();

            for (int i = 2; ex.Readcell(i, 38) != null; i++)
            {
                if (ex.Readcelldouble(i, 64) == -255)
                {
                    int j = 2;


                    string m = "Temp";



                    while (m != null)
                    {
                        try { IWebElement providername1 = driver.FindElement(By.XPath("//*[@id='updateDoctor']/li[" + j + "]/a")); }
                        catch
                        {
                            driver.FindElement(By.Id("switch-button")).Click();
                            break;

                        }

                        IWebElement providername = driver.FindElement(By.XPath("//*[@id='updateDoctor']/li[" + j + "]/a"));

                        string na = providername.Text;

                        if (na == ex.Readcell(i, 67))
                        {
                            providername.Click();
                            Thread.Sleep(2000);
                            try
                            {
                                driver.FindElement(By.Id("switch-button")).Click();
                                driver.FindElement(By.CssSelector("a[data-doctor='practicegroup']")).Click();
                            }
                            catch
                            { }

                            double cliamstart = double.Parse(ex.Readcelldouble(i, 68).ToString());
                            var datetimecliamstart = DateTime.FromOADate(cliamstart).ToString("d");
                            double lastfridatedate = double.Parse(ex.Readcelldouble(1, 69).ToString());
                            var datetimelastfridatedate = DateTime.FromOADate(lastfridatedate).ToString("d");



                            Thread.Sleep(2000);
                            driver.FindElement(By.CssSelector("input[ng-model='start_date']")).Clear();
                            driver.FindElement(By.CssSelector("input[ng-model='start_date']")).SendKeys(datetimecliamstart);
                            driver.FindElement(By.CssSelector("input[ng-model='end_date']")).Clear();
                            driver.FindElement(By.CssSelector("input[ng-model='end_date']")).SendKeys(datetimelastfridatedate);

                            Thread.Sleep(5000);
                            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                            try
                            {
                                driver.FindElement(By.CssSelector("button[ng-click='calculateCounts()']")).Click();
                            }
                            catch
                            {
                                js.ExecuteScript("window.scrollTo(0, 0)");
                                driver.FindElement(By.CssSelector("button[ng-click='calculateCounts()']")).Click();
                            }
                            Thread.Sleep(20000);

                            driver.FindElement(By.CssSelector("a[class='btn btn-white dropdown-toggle']")).Click();
                            Thread.Sleep(2000);
                            ex.Writecell(i, 64, driver.FindElement(By.CssSelector("#filters_well > form > div:nth-child(1) > div.btn-group.open > ul > li:nth-child(1) > label > span")).Text);
                            ex.Writecell(i, 65, driver.FindElement(By.CssSelector("#filters_well > form > div:nth-child(1) > div.btn-group.open > ul > li:nth-child(11) > label > span ")).Text);
                            //driver.FindElement(By.CssSelector("#filters_well > form > div:nth-child(3) > select > option:nth-child(2)")).Click();
                            //*[@id="filters_well"]/form/div[2]/select/option[2]
                            // driver.FindElement(By.XPath("//*[@id='filters_well']/form/div[2]/select/option[2]")).Click();
                            driver.FindElement(By.CssSelector("option[value='locked']")).Click();
                            Thread.Sleep(2000);
                            try
                            {
                                driver.FindElement(By.CssSelector("button[ng-click='calculateCounts()']")).Click();
                            }
                            catch
                            {
                                js.ExecuteScript("window.scrollTo(0, 0)");
                                driver.FindElement(By.CssSelector("button[ng-click='calculateCounts()']")).Click();
                            }
                            Thread.Sleep(10000);
                            driver.FindElement(By.CssSelector("a[class='btn btn-white dropdown-toggle']")).Click();
                            Thread.Sleep(20000);
                            ex.Writecell(i, 66, driver.FindElement(By.CssSelector("#filters_well > form > div:nth-child(1) > div.btn-group.open > ul > li:nth-child(11) > label> span")).Text); ex.Save();

                            //app.textAllStatusNumbaer.Text = ex.Readcelldouble(i, 64).ToString();
                            //app.textBoxNotSubNumber.Text = ex.Readcelldouble(i, 65).ToString();
                            //app.textCompletedLockedNotSub.Text = ex.Readcelldouble(i, 66).ToString();
                            break;


                        }

                        j++;
                    }

                    driver.FindElement(By.Id("switch-button")).Click();

                }
                }


        }

        

        public void RCMFiledownload(string fname)

        
        {
            //To download RCM file from box
            try { string pos = driver.FindElement(By.CssSelector("div[data-resin-folder_id ='90308375260']")).GetAttribute("data-item-index"); }
            catch { }
            if (pos == "0" || pos == "1"){
                driver.FindElement(By.PartialLinkText("Failed-Exports")).Click();
                Thread.Sleep(10000);
                for (int i = 0; i < 7; i++)
                {
                    try {

                        string m = driver.FindElements(By.PartialLinkText(fname))[i].GetAttribute("href");
                        string n = m.Substring(34);
                        Thread.Sleep(5000);
                        driver.FindElement(By.CssSelector("div[data-resin-file_id ='" + n + "']")).Click();
                        Thread.Sleep(5000);
                        driver.FindElement(By.CssSelector("button[aria-label='Download']")).Click();
                        Thread.Sleep(5000);
                    }
                    catch(Exception)
                    {
                        break;
                    }
                    
                }
            }

        }

    }
}
