using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDataReader;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Windows.Forms;
using System.Threading;

namespace Review_Catcher
{
    class Hotel
    {
        public static string hotelName { get; set; }
        public static string hotelLocation { get; set; }
        public static string totalReview { get; set; }
        public static string totalExcellentReview { get; set; }
        public static string totalEnglishReview { get; set; }
        public static string totalEstimateReview { get; set; }
        public static int totalPage { get; set; }

        private static int ENGLISH_REVIEW_VALUE { get; set; }

        public static void filterReview()
        {
            try
            {
                Controller.wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)Controller.driver;
                js.ExecuteScript("document.getElementById('ReviewRatingFilter_5').click()"); //Excellent Reviews
                js.ExecuteScript("document.getElementById('ReviewRatingFilter_4').click()"); //Very Good Reviews

                for(int i = 0; i < 4; i++) //English Reviews
                {
                    string value = (string) js.ExecuteScript("return document.getElementById('LanguageFilter_"+ i +"').value");
                    if (value.Equals("en"))
                    {
                        ENGLISH_REVIEW_VALUE = i;
                        js.ExecuteScript("return document.getElementById('LanguageFilter_" + i + "').click()");
                    }
                }
       
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        public static string getHotelName()
        {
            try
            {
                hotelName = Controller.driver.FindElement(By.Id("HEADING")).Text;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                hotelName = "No data!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return hotelName;
        }

        public static string getHotelLocation()
        {
            try
            {
                hotelLocation = Controller.driver.FindElement(By.CssSelector("span.public-business-listing-ContactInfo__ui_link--1_7Zp.public-business-listing-ContactInfo__level_4--3JgmI")).Text;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                hotelLocation = "No data!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return hotelLocation;
        }

        public static string getTotalReview()
        {
            try
            {
                totalReview = Controller.driver.FindElements(By.CssSelector("span.location-review-review-list-parts-LanguageFilter__paren_count--2vk3f"))[0].Text;
                totalReview = totalReview.Replace("(", "").Replace(")", "");
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                totalReview = "No data!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return totalReview;
        }

        public static string getTotalExcellentReview()
        {
            try
            {
                string excellentReview = Controller.driver.FindElements(By.CssSelector("span.location-review-review-list-parts-ReviewRatingFilter__row_num--3cSP7"))[0].Text;
                string goodReview = Controller.driver.FindElements(By.CssSelector("span.location-review-review-list-parts-ReviewRatingFilter__row_num--3cSP7"))[1].Text;
                totalExcellentReview = excellentReview + " + " + goodReview;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                totalExcellentReview = "No data!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return totalExcellentReview;
        }

        public static string getTotalEnglishReview()
        {
            try
            {
                totalEnglishReview = Controller.driver.FindElements(By.CssSelector("span.location-review-review-list-parts-LanguageFilter__paren_count--2vk3f"))[ENGLISH_REVIEW_VALUE].Text;
                totalEnglishReview = totalEnglishReview.Replace("(", "").Replace(")", "");
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                totalEnglishReview = "No data!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return totalEnglishReview;
        }

        public static string getEstimateReview()
        {
            try
            {
                //TODO: Better using wait.Until rather than Thread.Sleep
                Thread.Sleep(2000);
                totalPage = Int32.Parse(Controller.driver.FindElements(By.CssSelector("a.pageNum.cx_brand_refresh_phase2 "))[5].Text);
                //TODO: Handle code if reviews just 1 page 
                int calculateTotalEstimateReview = totalPage * 5; // Max Page x 5 reviews each page
                totalEstimateReview = (calculateTotalEstimateReview - 4) + " s/d " + calculateTotalEstimateReview;
            }
            catch (OpenQA.Selenium.NoSuchElementException ex)
            {
                totalEstimateReview = "No data!";
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return totalEstimateReview;
        }
    }
}
