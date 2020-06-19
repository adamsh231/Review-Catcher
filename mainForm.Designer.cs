namespace Review_Catcher
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkUrl = new System.Windows.Forms.Button();
            this.url = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hotelName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalEstimateReview = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalEnglishReview = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalExcellentReview = new System.Windows.Forms.Label();
            this.totalReview = new System.Windows.Forms.Label();
            this.hotelLocation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.open = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.TextBox();
            this.proceed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkUrl
            // 
            this.checkUrl.Location = new System.Drawing.Point(494, 25);
            this.checkUrl.Name = "checkUrl";
            this.checkUrl.Size = new System.Drawing.Size(86, 31);
            this.checkUrl.TabIndex = 0;
            this.checkUrl.Text = "Check";
            this.checkUrl.UseVisualStyleBackColor = true;
            this.checkUrl.Click += new System.EventHandler(this.checkUrl_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(104, 29);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(384, 22);
            this.url.TabIndex = 1;
            this.url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Review URL";
            // 
            // hotelName
            // 
            this.hotelName.AutoSize = true;
            this.hotelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelName.Location = new System.Drawing.Point(6, 30);
            this.hotelName.Name = "hotelName";
            this.hotelName.Size = new System.Drawing.Size(174, 32);
            this.hotelName.TabIndex = 3;
            this.hotelName.Text = "Hotel Name";
            this.hotelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalEstimateReview);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.totalEnglishReview);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.totalExcellentReview);
            this.groupBox1.Controls.Add(this.totalReview);
            this.groupBox1.Controls.Add(this.hotelLocation);
            this.groupBox1.Controls.Add(this.hotelName);
            this.groupBox1.Location = new System.Drawing.Point(15, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 172);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotel Info";
            // 
            // totalEstimateReview
            // 
            this.totalEstimateReview.AutoSize = true;
            this.totalEstimateReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalEstimateReview.Location = new System.Drawing.Point(292, 128);
            this.totalEstimateReview.Name = "totalEstimateReview";
            this.totalEstimateReview.Size = new System.Drawing.Size(18, 20);
            this.totalEstimateReview.TabIndex = 12;
            this.totalEstimateReview.Text = "0";
            this.totalEstimateReview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Filtered Reviews";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalEnglishReview
            // 
            this.totalEnglishReview.AutoSize = true;
            this.totalEnglishReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalEnglishReview.Location = new System.Drawing.Point(542, 72);
            this.totalEnglishReview.Name = "totalEnglishReview";
            this.totalEnglishReview.Size = new System.Drawing.Size(18, 20);
            this.totalEnglishReview.TabIndex = 10;
            this.totalEnglishReview.Text = "0";
            this.totalEnglishReview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalEnglishReview.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "English Reviews";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Excellent + Good Reviews";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(258, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total Reviews";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Visible = false;
            // 
            // totalExcellentReview
            // 
            this.totalExcellentReview.AutoSize = true;
            this.totalExcellentReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.totalExcellentReview.Location = new System.Drawing.Point(292, 108);
            this.totalExcellentReview.Name = "totalExcellentReview";
            this.totalExcellentReview.Size = new System.Drawing.Size(18, 20);
            this.totalExcellentReview.TabIndex = 6;
            this.totalExcellentReview.Text = "0";
            this.totalExcellentReview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalReview
            // 
            this.totalReview.AutoSize = true;
            this.totalReview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReview.Location = new System.Drawing.Point(542, 52);
            this.totalReview.Name = "totalReview";
            this.totalReview.Size = new System.Drawing.Size(18, 20);
            this.totalReview.TabIndex = 5;
            this.totalReview.Text = "0";
            this.totalReview.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.totalReview.Visible = false;
            // 
            // hotelLocation
            // 
            this.hotelLocation.AutoSize = true;
            this.hotelLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLocation.Location = new System.Drawing.Point(7, 62);
            this.hotelLocation.Name = "hotelLocation";
            this.hotelLocation.Size = new System.Drawing.Size(86, 25);
            this.hotelLocation.TabIndex = 4;
            this.hotelLocation.Text = "Location";
            this.hotelLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.open);
            this.groupBox2.Controls.Add(this.fileName);
            this.groupBox2.Location = new System.Drawing.Point(15, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(582, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "File";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(479, 26);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(86, 31);
            this.open.TabIndex = 7;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // fileName
            // 
            this.fileName.Enabled = false;
            this.fileName.Location = new System.Drawing.Point(89, 30);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(384, 22);
            this.fileName.TabIndex = 7;
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proceed
            // 
            this.proceed.Enabled = false;
            this.proceed.Location = new System.Drawing.Point(252, 358);
            this.proceed.Name = "proceed";
            this.proceed.Size = new System.Drawing.Size(104, 38);
            this.proceed.TabIndex = 6;
            this.proceed.Text = "Proceed";
            this.proceed.UseVisualStyleBackColor = true;
            this.proceed.Click += new System.EventHandler(this.proceed_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 404);
            this.Controls.Add(this.proceed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.checkUrl);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trip Advisor Review Catcher";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkUrl;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label hotelName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label hotelLocation;
        private System.Windows.Forms.Label totalExcellentReview;
        private System.Windows.Forms.Label totalReview;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button proceed;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalEnglishReview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalEstimateReview;
    }
}

