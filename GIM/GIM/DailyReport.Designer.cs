namespace GIM
{
    partial class DailyReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReportText = new System.Windows.Forms.RichTextBox();
            this.tbReportStat = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {
            "1 May",
            "2 May",
            "3 May",
            "4 May",
            "5 May",
            "6 May",
            "7 May",
            "8 May",
            "9 May",
            "10 May",
            "11 May",
            "12 May",
            "13 May",
            "14 May",
            "15 May",
            "16 May",
            "17 May",
            "18 May",
            "19 May",
            "20 May",
            "21 May",
            "22 May",
            "23 May",
            "24 May",
            "25 May",
            "26 May",
            "27 May",
            "28 May",
            "29 May",
            "30 May",
            "31 May"});
            this.cbDate.Location = new System.Drawing.Point(51, 12);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(90, 21);
            this.cbDate.TabIndex = 1;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Report text";
            // 
            // tbReportText
            // 
            this.tbReportText.Location = new System.Drawing.Point(18, 69);
            this.tbReportText.Name = "tbReportText";
            this.tbReportText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbReportText.Size = new System.Drawing.Size(636, 173);
            this.tbReportText.TabIndex = 3;
            this.tbReportText.Text = "";
            // 
            // tbReportStat
            // 
            this.tbReportStat.Location = new System.Drawing.Point(18, 273);
            this.tbReportStat.Name = "tbReportStat";
            this.tbReportStat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.tbReportStat.Size = new System.Drawing.Size(636, 173);
            this.tbReportStat.TabIndex = 5;
            this.tbReportStat.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Report statistics";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(545, 452);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 23);
            this.btCancel.TabIndex = 14;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(428, 452);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 13;
            this.btSave.Text = " Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 485);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.tbReportStat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReportText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyReport";
            this.Text = "Daily Report";
            this.Load += new System.EventHandler(this.DailyReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbReportText;
        private System.Windows.Forms.RichTextBox tbReportStat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
    }
}