namespace GIM
{
    partial class ReportList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbDate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gvReports = new System.Windows.Forms.DataGridView();
            this.reportid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reporttext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportstat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datemonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDate
            // 
            this.cbDate.FormattingEnabled = true;
            this.cbDate.Items.AddRange(new object[] {
            "1 April",
            "2 April",
            "3 April",
            "4 April",
            "5 April",
            "6 April",
            "7 April",
            "8 April",
            "9 April",
            "10 April",
            "11 April",
            "12 April",
            "13 April",
            "14 April",
            "15 April",
            "16 April",
            "17 April",
            "18 April",
            "19 April",
            "20 April",
            "21 April",
            "22 April",
            "23 April",
            "24 April",
            "25 April",
            "26 April",
            "27 April",
            "28 April",
            "29 April",
            "30 April",
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
            this.cbDate.Location = new System.Drawing.Point(55, 12);
            this.cbDate.Name = "cbDate";
            this.cbDate.Size = new System.Drawing.Size(90, 21);
            this.cbDate.TabIndex = 3;
            this.cbDate.SelectedIndexChanged += new System.EventHandler(this.cbDate_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // gvReports
            // 
            this.gvReports.AllowUserToAddRows = false;
            this.gvReports.AllowUserToDeleteRows = false;
            this.gvReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvReports.BackgroundColor = System.Drawing.Color.Azure;
            this.gvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reportid,
            this.usercode,
            this.reporttext,
            this.reportstat,
            this.finished,
            this.datemonth,
            this.dateday,
            this.userid,
            this.usertype});
            this.gvReports.Location = new System.Drawing.Point(12, 48);
            this.gvReports.Name = "gvReports";
            this.gvReports.RowHeadersVisible = false;
            this.gvReports.Size = new System.Drawing.Size(960, 601);
            this.gvReports.TabIndex = 4;
            // 
            // reportid
            // 
            this.reportid.DataPropertyName = "ID";
            this.reportid.HeaderText = "Report ID";
            this.reportid.Name = "reportid";
            this.reportid.Visible = false;
            // 
            // usercode
            // 
            this.usercode.DataPropertyName = "Ucode";
            this.usercode.HeaderText = "User";
            this.usercode.Name = "usercode";
            this.usercode.Width = 80;
            // 
            // reporttext
            // 
            this.reporttext.DataPropertyName = "ReportText";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reporttext.DefaultCellStyle = dataGridViewCellStyle1;
            this.reporttext.HeaderText = "Report Text";
            this.reporttext.Name = "reporttext";
            this.reporttext.Width = 395;
            // 
            // reportstat
            // 
            this.reportstat.DataPropertyName = "ReportStats";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.reportstat.DefaultCellStyle = dataGridViewCellStyle2;
            this.reportstat.HeaderText = "Report statistics";
            this.reportstat.Name = "reportstat";
            this.reportstat.Width = 395;
            // 
            // finished
            // 
            this.finished.DataPropertyName = "Finished";
            this.finished.HeaderText = "Completed";
            this.finished.Name = "finished";
            this.finished.Width = 80;
            // 
            // datemonth
            // 
            this.datemonth.DataPropertyName = "DateMonth";
            this.datemonth.HeaderText = "datemonth";
            this.datemonth.Name = "datemonth";
            this.datemonth.Visible = false;
            // 
            // dateday
            // 
            this.dateday.DataPropertyName = "DateDay";
            this.dateday.HeaderText = "dateday";
            this.dateday.Name = "dateday";
            this.dateday.Visible = false;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "UserID";
            this.userid.HeaderText = "userid";
            this.userid.Name = "userid";
            this.userid.Visible = false;
            // 
            // usertype
            // 
            this.usertype.DataPropertyName = "UserType";
            this.usertype.HeaderText = "User Type";
            this.usertype.Name = "usertype";
            this.usertype.Visible = false;
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(860, 10);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 23);
            this.btExport.TabIndex = 18;
            this.btExport.Text = "Export to Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // ReportList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.gvReports);
            this.Controls.Add(this.cbDate);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "ReportList";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Daily Report List";
            this.Load += new System.EventHandler(this.ReportList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvReports;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportid;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn reporttext;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportstat;
        private System.Windows.Forms.DataGridViewTextBoxColumn finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn datemonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateday;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn usertype;
    }
}