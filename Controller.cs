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
    public class Controller
    {
        public static IWebDriver driver { get; set; }
        public static ChromeDriverService option { get; set; }
        public static string url { set; get; }
        public const int WAIT_FOR_SECONDS = 10;
        public static WebDriverWait wait { get; set; }

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
            option = ChromeDriverService.CreateDefaultService();
            option.HideCommandPromptWindow = true;
            try
            {
                driver = new ChromeDriver(option, new ChromeOptions());
                wait = new WebDriverWait(driver, TimeSpan.FromSeconds(WAIT_FOR_SECONDS));
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Browser gagal dibuka!, Harap tunggu beberapa saat dan coba lagi.");
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

    }
}
