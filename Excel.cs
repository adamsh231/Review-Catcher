using OfficeOpenXml;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

                var review_title = Controller.driver.FindElements(By.CssSelector("a.location-review-review-list-parts-ReviewTitle__reviewTitleText--2tFRT"));
                for (int i = 0; i < review_title.Count; i++)
                {
                    workSheet.Cells["A"+(i+1)].Value = review_title[i].Text;
                }
                excel.Save();
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
