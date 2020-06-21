using OfficeOpenXml;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Review_Catcher
{
    class Excel
    {
        public static OpenFileDialog ofd { get; set; }
        public static ExcelPackage excel { get; set; }
        public static ExcelWorksheet workSheet { get; set; }

        public static void openReviewFile()
        {
            try
            {
                ofd = new OpenFileDialog() { Filter = "Excel Worksheet|*.xlsx", ValidateNames = true };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FileInfo fileInfo = new FileInfo(ofd.FileName);
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    excel = new ExcelPackage(fileInfo);
                    workSheet = excel.Workbook.Worksheets[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        public static string getFileName()
        {
            string fileName;
            try
            {
                fileName = ofd.FileName;
            }
            catch (Exception ex)
            {
                fileName = "";
            }
            return fileName;
        }

        public static void writeFileTest()
        {
            try
            {
                int total_review = 1;
                int current_page = 1;
                while (current_page <= Hotel.totalPage)
                {
                    Controller.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.CssSelector("span.pageNum.current.cx_brand_refresh_phase2.disabled")));
                    current_page = Int32.Parse(Controller.driver.FindElement(By.CssSelector("span.pageNum.current.cx_brand_refresh_phase2.disabled")).Text);
                    IJavaScriptExecutor js = (IJavaScriptExecutor)Controller.driver;

                    try
                    {
                        js.ExecuteScript("document.getElementById('autoTranslateNo').click()");
                    }
                    catch (Exception){}
                    
                    var review_title = Controller.driver.FindElements(By.CssSelector("a.location-review-review-list-parts-ReviewTitle__reviewTitleText--2tFRT"));
                    var review_text = Controller.driver.FindElements(By.CssSelector("q.location-review-review-list-parts-ExpandableReview__reviewText--gOmRC"));
                    for (int i = 0; i < review_title.Count; i++)
                    {

                        workSheet.Cells["A" + total_review].Value = Controller.driver.FindElement(By.CssSelector("span.pageNum.current.cx_brand_refresh_phase2.disabled")).Text;
                        workSheet.Cells["B" + total_review].Value = review_title[i].Text;
                        workSheet.Cells["C" + total_review].Value = review_text[i].Text;
                        total_review++;
                    }

                    
                    js.ExecuteScript("document.getElementsByClassName('ui_button nav next primary ')[0].click()");

                    excel.Save();

                    //TODO: Better using wait.Until rather than Thread.Sleep
                    Thread.Sleep(1500);

                    if(current_page == Hotel.totalPage)
                    {
                        break;
                    }
                }  
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("You need to open the file first");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

    }
}
