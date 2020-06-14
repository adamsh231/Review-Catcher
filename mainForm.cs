using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Review_Catcher
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        

        private void checkUrl_Click(object sender, EventArgs e)
        {
            Controller.navigateToUrl(url.Text);
            hotelName.Text = Hotel.getHotelName();
            hotelLocation.Text = Hotel.getHotelLocation();
            totalReview.Text = Hotel.getTotalReview();
            totalExcellentReview.Text = Hotel.getTotalExcellentReview();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.closeBrowser();
            Application.Exit();
        }
    }
}
