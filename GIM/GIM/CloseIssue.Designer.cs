namespace GIM
{
    partial class CloseIssue
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
            this.label15 = new System.Windows.Forms.Label();
            this.dtActualEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCloseText = new System.Windows.Forms.RichTextBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbH = new System.Windows.Forms.ComboBox();
            this.cbM = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(217, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = ":";
            // 
            // dtActualEnd
            // 
            this.dtActualEnd.CalendarMonthBackground = System.Drawing.SystemColors.MenuBar;
            this.dtActualEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtActualEnd.Location = new System.Drawing.Point(17, 41);
            this.dtActualEnd.Name = "dtActualEnd";
            this.dtActualEnd.Size = new System.Drawing.Size(136, 20);
            this.dtActualEnd.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Actual end date/time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Final comments";
            // 
            // tbCloseText
            // 
            this.tbCloseText.Location = new System.Drawing.Point(17, 89);
            this.tbCloseText.Name = "tbCloseText";
            this.tbCloseText.Size = new System.Drawing.Size(657, 220);
            this.tbCloseText.TabIndex = 56;
            this.tbCloseText.Text = "";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(594, 345);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 23);
            this.btCancel.TabIndex = 58;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSave.Location = new System.Drawing.Point(477, 345);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 57;
            this.btSave.Text = " Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbH
            // 
            this.cbH.FormattingEnabled = true;
            this.cbH.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbH.Location = new System.Drawing.Point(165, 40);
            this.cbH.Name = "cbH";
            this.cbH.Size = new System.Drawing.Size(46, 21);
            this.cbH.TabIndex = 59;
            // 
            // cbM
            // 
            this.cbM.FormattingEnabled = true;
            this.cbM.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.cbM.Location = new System.Drawing.Point(232, 40);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(46, 21);
            this.cbM.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbM);
            this.groupBox1.Controls.Add(this.tbCloseText);
            this.groupBox1.Controls.Add(this.cbH);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtActualEnd);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 327);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Closing details";
            // 
            // CloseIssue
            // 
            this.AcceptButton = this.btSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 377);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(731, 416);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(731, 416);
            this.Name = "CloseIssue";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close Issue";
            this.Load += new System.EventHandler(this.CloseIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtActualEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox tbCloseText;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbH;
        private System.Windows.Forms.ComboBox cbM;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}