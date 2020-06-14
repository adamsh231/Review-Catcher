using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ExcelDataReader;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Windows.Forms;

namespace Review_Catcher
{
    class Controller
    {
        public static IWebDriver driver { get; set; }
        public static string url { set; get; }
        public const int WAIT_FOR_SECONDS = 10;
        public static ChromeDriverService service = ChromeDriverService.CreateDefaultService();
        public static ChromeOptions option = new ChromeOptions();
        public static WebDriverWait wait { set; get; }

        public static void navigateToUrl(string reviewUrl)
        {
            url = reviewUrl;
            try
            {
                driver.Navigate().GoToUrl(url);
                Hotel.filterExcellentReview();
            }
            catch (System.NullReferenceException)
            {
                closeBrowser();
                openBrowser();
                navigateToUrl(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        private static void openBrowser()
        {
            service.HideCommandPromptWindow = true;
            option.AddArgument("--lang=en");
            try
            {
                driver = new ChromeDriver(service, option);
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAIT_FOR_SECONDS));
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Browser failed to open, Please wait and try again.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        public static void closeBrowser()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception) { }
        }

        public static bool checkReadinessToProceed()
        {
            bool ready = false;
            try
            {
                if(driver != null && Excel.excel != null)
                {
                    ready = true;
                }
            }
            catch (Exception ex)
            {
                ready = false;
            }
            return ready;
        }
    }
}
