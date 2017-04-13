namespace GIM
{
    partial class AddIssue
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
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtOccurence = new System.Windows.Forms.DateTimePicker();
            this.cbLeadFunc = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clbImpactedFuncs = new System.Windows.Forms.CheckedListBox();
            this.clbImpactedVenues = new System.Windows.Forms.CheckedListBox();
            this.btCancel = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbMins = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chReportable = new System.Windows.Forms.CheckBox();
            this.chDashboard = new System.Windows.Forms.CheckBox();
            this.cbMin3 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbHour3 = new System.Windows.Forms.ComboBox();
            this.dtActualEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbLocationDesc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.tbAttachment = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(19, 38);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(409, 20);
            this.tbTitle.TabIndex = 1;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(19, 81);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(409, 79);
            this.tbDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Severity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lead function";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 483);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date/time of occurence";
            // 
            // dtOccurence
            // 
            this.dtOccurence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOccurence.Location = new System.Drawing.Point(19, 499);
            this.dtOccurence.Name = "dtOccurence";
            this.dtOccurence.Size = new System.Drawing.Size(136, 20);
            this.dtOccurence.TabIndex = 8;
            // 
            // cbLeadFunc
            // 
            this.cbLeadFunc.FormattingEnabled = true;
            this.cbLeadFunc.Location = new System.Drawing.Point(19, 274);
            this.cbLeadFunc.Name = "cbLeadFunc";
            this.cbLeadFunc.Size = new System.Drawing.Size(197, 21);
            this.cbLeadFunc.TabIndex = 4;
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.Location = new System.Drawing.Point(231, 274);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 21);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // cbSeverity
            // 
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(231, 184);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(197, 21);
            this.cbSeverity.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Impacted functions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Impacted venues";
            // 
            // clbImpactedFuncs
            // 
            this.clbImpactedFuncs.CheckOnClick = true;
            this.clbImpactedFuncs.FormattingEnabled = true;
            this.clbImpactedFuncs.Location = new System.Drawing.Point(19, 319);
            this.clbImpactedFuncs.MultiColumn = true;
            this.clbImpactedFuncs.Name = "clbImpactedFuncs";
            this.clbImpactedFuncs.Size = new System.Drawing.Size(197, 154);
            this.clbImpactedFuncs.TabIndex = 6;
            // 
            // clbImpactedVenues
            // 
            this.clbImpactedVenues.CheckOnClick = true;
            this.clbImpactedVenues.FormattingEnabled = true;
            this.clbImpactedVenues.Location = new System.Drawing.Point(231, 319);
            this.clbImpactedVenues.MultiColumn = true;
            this.clbImpactedVenues.Name = "clbImpactedVenues";
            this.clbImpactedVenues.Size = new System.Drawing.Size(197, 154);
            this.clbImpactedVenues.TabIndex = 7;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(352, 632);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(235, 632);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 11;
            this.btSave.Text = " Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
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
            this.cbHour.Location = new System.Drawing.Point(170, 499);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(46, 21);
            this.cbHour.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = ":";
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
            this.cbMins.Location = new System.Drawing.Point(231, 499);
            this.cbMins.Name = "cbMins";
            this.cbMins.Size = new System.Drawing.Size(46, 21);
            this.cbMins.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chReportable);
            this.groupBox1.Controls.Add(this.chDashboard);
            this.groupBox1.Controls.Add(this.cbMin3);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbHour3);
            this.groupBox1.Controls.Add(this.dtActualEnd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbLocationDesc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbLocation);
            this.groupBox1.Controls.Add(this.tbAttachment);
            this.groupBox1.Controls.Add(this.cbSeverity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbMins);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.clbImpactedVenues);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbHour);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.clbImpactedFuncs);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtOccurence);
            this.groupBox1.Controls.Add(this.cbLeadFunc);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 614);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // chReportable
            // 
            this.chReportable.AutoSize = true;
            this.chReportable.Location = new System.Drawing.Point(338, 541);
            this.chReportable.Name = "chReportable";
            this.chReportable.Size = new System.Drawing.Size(78, 17);
            this.chReportable.TabIndex = 51;
            this.chReportable.Text = "Reportable";
            this.chReportable.UseVisualStyleBackColor = true;
            // 
            // chDashboard
            // 
            this.chDashboard.AutoSize = true;
            this.chDashboard.Location = new System.Drawing.Point(338, 504);
            this.chDashboard.Name = "chDashboard";
            this.chDashboard.Size = new System.Drawing.Size(78, 17);
            this.chDashboard.TabIndex = 50;
            this.chDashboard.Text = "Dashboard";
            this.chDashboard.UseVisualStyleBackColor = true;
            // 
            // cbMin3
            // 
            this.cbMin3.Enabled = false;
            this.cbMin3.FormattingEnabled = true;
            this.cbMin3.Items.AddRange(new object[] {
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
            this.cbMin3.Location = new System.Drawing.Point(231, 539);
            this.cbMin3.Name = "cbMin3";
            this.cbMin3.Size = new System.Drawing.Size(46, 21);
            this.cbMin3.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(219, 542);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = ":";
            // 
            // cbHour3
            // 
            this.cbHour3.Enabled = false;
            this.cbHour3.FormattingEnabled = true;
            this.cbHour3.Items.AddRange(new object[] {
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
            this.cbHour3.Location = new System.Drawing.Point(170, 539);
            this.cbHour3.Name = "cbHour3";
            this.cbHour3.Size = new System.Drawing.Size(46, 21);
            this.cbHour3.TabIndex = 47;
            // 
            // dtActualEnd
            // 
            this.dtActualEnd.Enabled = false;
            this.dtActualEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtActualEnd.Location = new System.Drawing.Point(19, 540);
            this.dtActualEnd.Name = "dtActualEnd";
            this.dtActualEnd.Size = new System.Drawing.Size(136, 20);
            this.dtActualEnd.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 523);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Actual end date/time";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 214);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Location description";
            // 
            // tbLocationDesc
            // 
            this.tbLocationDesc.Location = new System.Drawing.Point(19, 230);
            this.tbLocationDesc.Name = "tbLocationDesc";
            this.tbLocationDesc.Size = new System.Drawing.Size(409, 20);
            this.tbLocationDesc.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Location";
            // 
            // cbLocation
            // 
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(19, 184);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(197, 21);
            this.cbLocation.TabIndex = 30;
            // 
            // tbAttachment
            // 
            this.tbAttachment.Location = new System.Drawing.Point(19, 582);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.Size = new System.Drawing.Size(409, 20);
            this.tbAttachment.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Attachment";
            // 
            // AddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(474, 661);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(490, 700);
            this.Name = "AddIssue";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Issue";
            this.Load += new System.EventHandler(this.AddIssue_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtOccurence;
        private System.Windows.Forms.ComboBox cbLeadFunc;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbSeverity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox clbImpactedFuncs;
        private System.Windows.Forms.CheckedListBox clbImpactedVenues;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbMins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbAttachment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbLocationDesc;
        private System.Windows.Forms.ComboBox cbMin3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbHour3;
        private System.Windows.Forms.DateTimePicker dtActualEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chReportable;
        private System.Windows.Forms.CheckBox chDashboard;
    }
}