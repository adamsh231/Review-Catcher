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

namespace Review_Catcher
{
    static class Hotel
    {
        public static string hotelName { get; set; }
        public static string hotelLocation { get; set; }
        public static string totalReview { get; set; }
        public static string totalExcellentReview { get; set; }

        public static string getHotelName()
        {
            try
            {
                hotelName = Controller.driver.FindElement(By.Id("HEADING")).Text;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                hotelName = "Invalid URL!";
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
                hotelLocation = "Invalid URL!";
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
                totalReview = Controller.driver.FindElement(By.CssSelector("span.hotels-hotel-review-about-with-photos-Reviews__seeAllReviews--3PpLR")).Text;
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                totalReview = "Invalid URL!";
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
                totalExcellentReview = Controller.driver.FindElement(By.CssSelector("span.location-review-review-list-parts-ReviewRatingFilter__row_num--3cSP7")).Text;
                totalExcellentReview = totalExcellentReview + " excellent reviews";
            }
            catch (OpenQA.Selenium.NoSuchElementException)
            {
                totalExcellentReview = "Invalid URL!";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
            return totalExcellentReview;
        }
    }
}
