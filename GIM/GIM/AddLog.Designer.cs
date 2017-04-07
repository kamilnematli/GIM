namespace GIM
{
    partial class AddLog
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMins = new System.Windows.Forms.ComboBox();
            this.dtOccurence = new System.Windows.Forms.DateTimePicker();
            this.tbLocationDesc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.clbImpactedVenues = new System.Windows.Forms.CheckedListBox();
            this.clbImpactedFuncs = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbLeadFunc = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.SystemColors.Info;
            this.tbTitle.Location = new System.Drawing.Point(15, 42);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(389, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Impacted Venues";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Impacted Furnctions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Date/time of occurence";
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Items.AddRange(new object[] {
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
            this.cbHour.Location = new System.Drawing.Point(149, 521);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(50, 21);
            this.cbHour.TabIndex = 9;
            // 
            // cbMins
            // 
            this.cbMins.FormattingEnabled = true;
            this.cbMins.Items.AddRange(new object[] {
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
            this.cbMins.Location = new System.Drawing.Point(219, 521);
            this.cbMins.Name = "cbMins";
            this.cbMins.Size = new System.Drawing.Size(51, 21);
            this.cbMins.TabIndex = 10;
            // 
            // dtOccurence
            // 
            this.dtOccurence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOccurence.Location = new System.Drawing.Point(15, 522);
            this.dtOccurence.Name = "dtOccurence";
            this.dtOccurence.Size = new System.Drawing.Size(120, 20);
            this.dtOccurence.TabIndex = 8;
            // 
            // tbLocationDesc
            // 
            this.tbLocationDesc.Location = new System.Drawing.Point(15, 455);
            this.tbLocationDesc.Multiline = true;
            this.tbLocationDesc.Name = "tbLocationDesc";
            this.tbLocationDesc.Size = new System.Drawing.Size(389, 38);
            this.tbLocationDesc.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Location Description";
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(208, 572);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 11;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(323, 572);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // clbImpactedVenues
            // 
            this.clbImpactedVenues.CheckOnClick = true;
            this.clbImpactedVenues.FormattingEnabled = true;
            this.clbImpactedVenues.Location = new System.Drawing.Point(219, 194);
            this.clbImpactedVenues.MultiColumn = true;
            this.clbImpactedVenues.Name = "clbImpactedVenues";
            this.clbImpactedVenues.Size = new System.Drawing.Size(185, 184);
            this.clbImpactedVenues.TabIndex = 4;
            // 
            // clbImpactedFuncs
            // 
            this.clbImpactedFuncs.CheckOnClick = true;
            this.clbImpactedFuncs.FormattingEnabled = true;
            this.clbImpactedFuncs.Location = new System.Drawing.Point(15, 194);
            this.clbImpactedFuncs.MultiColumn = true;
            this.clbImpactedFuncs.Name = "clbImpactedFuncs";
            this.clbImpactedFuncs.Size = new System.Drawing.Size(184, 184);
            this.clbImpactedFuncs.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLeadFunc);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbLocation);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.clbImpactedFuncs);
            this.groupBox1.Controls.Add(this.clbImpactedVenues);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbLocationDesc);
            this.groupBox1.Controls.Add(this.dtOccurence);
            this.groupBox1.Controls.Add(this.cbMins);
            this.groupBox1.Controls.Add(this.cbHour);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 554);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // cbLeadFunc
            // 
            this.cbLeadFunc.FormattingEnabled = true;
            this.cbLeadFunc.Location = new System.Drawing.Point(15, 407);
            this.cbLeadFunc.Name = "cbLeadFunc";
            this.cbLeadFunc.Size = new System.Drawing.Size(184, 21);
            this.cbLeadFunc.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 391);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Lead Function";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(219, 407);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(185, 21);
            this.cbLocation.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = ":";
            // 
            // tbDesc
            // 
            this.tbDesc.BackColor = System.Drawing.SystemColors.Info;
            this.tbDesc.Location = new System.Drawing.Point(15, 86);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(389, 82);
            this.tbDesc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Description";
            // 
            // AddLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Log";
            this.Load += new System.EventHandler(this.AddLog_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMins;
        private System.Windows.Forms.DateTimePicker dtOccurence;
        private System.Windows.Forms.TextBox tbLocationDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.CheckedListBox clbImpactedVenues;
        private System.Windows.Forms.CheckedListBox clbImpactedFuncs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbLeadFunc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLocation;
    }
}