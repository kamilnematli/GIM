namespace GIM
{
    partial class MainWindow
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
            this.gvIssues = new System.Windows.Forms.DataGridView();
            this.btAddIssue = new System.Windows.Forms.Button();
            this.btAddLog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.OpenIssue = new System.Windows.Forms.Button();
            this.chIssue = new System.Windows.Forms.CheckBox();
            this.chLog = new System.Windows.Forms.CheckBox();
            this.chLow = new System.Windows.Forms.CheckBox();
            this.chMedium = new System.Windows.Forms.CheckBox();
            this.chHigh = new System.Windows.Forms.CheckBox();
            this.chClosed = new System.Windows.Forms.CheckBox();
            this.chInprogress = new System.Windows.Forms.CheckBox();
            this.chNew = new System.Windows.Forms.CheckBox();
            this.chOnhold = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chDashboard = new System.Windows.Forms.CheckBox();
            this.chReportable = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvIssues)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvIssues
            // 
            this.gvIssues.AllowUserToAddRows = false;
            this.gvIssues.AllowUserToDeleteRows = false;
            this.gvIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIssues.Location = new System.Drawing.Point(12, 129);
            this.gvIssues.Name = "gvIssues";
            this.gvIssues.Size = new System.Drawing.Size(995, 448);
            this.gvIssues.TabIndex = 0;
            // 
            // btAddIssue
            // 
            this.btAddIssue.Location = new System.Drawing.Point(12, 33);
            this.btAddIssue.Name = "btAddIssue";
            this.btAddIssue.Size = new System.Drawing.Size(112, 23);
            this.btAddIssue.TabIndex = 1;
            this.btAddIssue.Text = "Create Issue";
            this.btAddIssue.UseVisualStyleBackColor = true;
            this.btAddIssue.Click += new System.EventHandler(this.AddIssue_Click);
            // 
            // btAddLog
            // 
            this.btAddLog.Location = new System.Drawing.Point(130, 33);
            this.btAddLog.Name = "btAddLog";
            this.btAddLog.Size = new System.Drawing.Size(112, 23);
            this.btAddLog.TabIndex = 2;
            this.btAddLog.Text = "Create Log";
            this.btAddLog.UseVisualStyleBackColor = true;
            this.btAddLog.Click += new System.EventHandler(this.AddLog_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(826, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 3;
            // 
            // OpenIssue
            // 
            this.OpenIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenIssue.Location = new System.Drawing.Point(949, 33);
            this.OpenIssue.Name = "OpenIssue";
            this.OpenIssue.Size = new System.Drawing.Size(58, 23);
            this.OpenIssue.TabIndex = 4;
            this.OpenIssue.Text = "Open";
            this.OpenIssue.UseVisualStyleBackColor = true;
            // 
            // chIssue
            // 
            this.chIssue.AutoSize = true;
            this.chIssue.Location = new System.Drawing.Point(13, 21);
            this.chIssue.Name = "chIssue";
            this.chIssue.Size = new System.Drawing.Size(56, 17);
            this.chIssue.TabIndex = 5;
            this.chIssue.Text = "Issues";
            this.chIssue.UseVisualStyleBackColor = true;
            this.chIssue.CheckedChanged += new System.EventHandler(this.chIssue_CheckedChanged);
            // 
            // chLog
            // 
            this.chLog.AutoSize = true;
            this.chLog.Location = new System.Drawing.Point(75, 21);
            this.chLog.Name = "chLog";
            this.chLog.Size = new System.Drawing.Size(49, 17);
            this.chLog.TabIndex = 6;
            this.chLog.Text = "Logs";
            this.chLog.UseVisualStyleBackColor = true;
            this.chLog.CheckedChanged += new System.EventHandler(this.chLog_CheckedChanged);
            // 
            // chLow
            // 
            this.chLow.AutoSize = true;
            this.chLow.Location = new System.Drawing.Point(11, 21);
            this.chLow.Name = "chLow";
            this.chLow.Size = new System.Drawing.Size(46, 17);
            this.chLow.TabIndex = 7;
            this.chLow.Text = "Low";
            this.chLow.UseVisualStyleBackColor = true;
            this.chLow.CheckedChanged += new System.EventHandler(this.chLow_CheckedChanged);
            // 
            // chMedium
            // 
            this.chMedium.AutoSize = true;
            this.chMedium.Location = new System.Drawing.Point(63, 21);
            this.chMedium.Name = "chMedium";
            this.chMedium.Size = new System.Drawing.Size(63, 17);
            this.chMedium.TabIndex = 8;
            this.chMedium.Text = "Medium";
            this.chMedium.UseVisualStyleBackColor = true;
            this.chMedium.CheckedChanged += new System.EventHandler(this.chMedium_CheckedChanged);
            // 
            // chHigh
            // 
            this.chHigh.AutoSize = true;
            this.chHigh.Location = new System.Drawing.Point(130, 21);
            this.chHigh.Name = "chHigh";
            this.chHigh.Size = new System.Drawing.Size(48, 17);
            this.chHigh.TabIndex = 9;
            this.chHigh.Text = "High";
            this.chHigh.UseVisualStyleBackColor = true;
            this.chHigh.CheckedChanged += new System.EventHandler(this.chHigh_CheckedChanged);
            // 
            // chClosed
            // 
            this.chClosed.AutoSize = true;
            this.chClosed.Location = new System.Drawing.Point(222, 21);
            this.chClosed.Name = "chClosed";
            this.chClosed.Size = new System.Drawing.Size(58, 17);
            this.chClosed.TabIndex = 12;
            this.chClosed.Text = "Closed";
            this.chClosed.UseVisualStyleBackColor = true;
            this.chClosed.CheckedChanged += new System.EventHandler(this.chClosed_CheckedChanged);
            // 
            // chInprogress
            // 
            this.chInprogress.AutoSize = true;
            this.chInprogress.Location = new System.Drawing.Point(69, 21);
            this.chInprogress.Name = "chInprogress";
            this.chInprogress.Size = new System.Drawing.Size(78, 17);
            this.chInprogress.TabIndex = 11;
            this.chInprogress.Text = "In progress";
            this.chInprogress.UseVisualStyleBackColor = true;
            this.chInprogress.CheckedChanged += new System.EventHandler(this.chInprogress_CheckedChanged);
            // 
            // chNew
            // 
            this.chNew.AutoSize = true;
            this.chNew.Location = new System.Drawing.Point(15, 21);
            this.chNew.Name = "chNew";
            this.chNew.Size = new System.Drawing.Size(48, 17);
            this.chNew.TabIndex = 10;
            this.chNew.Text = "New";
            this.chNew.UseVisualStyleBackColor = true;
            this.chNew.CheckedChanged += new System.EventHandler(this.chNew_CheckedChanged);
            // 
            // chOnhold
            // 
            this.chOnhold.AutoSize = true;
            this.chOnhold.Location = new System.Drawing.Point(153, 21);
            this.chOnhold.Name = "chOnhold";
            this.chOnhold.Size = new System.Drawing.Size(63, 17);
            this.chOnhold.TabIndex = 13;
            this.chOnhold.Text = "On hold";
            this.chOnhold.UseVisualStyleBackColor = true;
            this.chOnhold.CheckedChanged += new System.EventHandler(this.chOnhold_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chLow);
            this.groupBox1.Controls.Add(this.chMedium);
            this.groupBox1.Controls.Add(this.chHigh);
            this.groupBox1.Location = new System.Drawing.Point(160, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Severity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chNew);
            this.groupBox2.Controls.Add(this.chInprogress);
            this.groupBox2.Controls.Add(this.chOnhold);
            this.groupBox2.Controls.Add(this.chClosed);
            this.groupBox2.Location = new System.Drawing.Point(363, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 51);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chIssue);
            this.groupBox3.Controls.Add(this.chLog);
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 51);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(248, 33);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 23);
            this.btExport.TabIndex = 17;
            this.btExport.Text = "Export to Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 26);
            this.panel1.TabIndex = 18;
            // 
            // lbUsername
            // 
            this.lbUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.Location = new System.Drawing.Point(929, 6);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(63, 13);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Username";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chDashboard);
            this.groupBox4.Controls.Add(this.chReportable);
            this.groupBox4.Location = new System.Drawing.Point(670, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 51);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flagged issues";
            // 
            // chDashboard
            // 
            this.chDashboard.AutoSize = true;
            this.chDashboard.Location = new System.Drawing.Point(13, 21);
            this.chDashboard.Name = "chDashboard";
            this.chDashboard.Size = new System.Drawing.Size(110, 17);
            this.chDashboard.TabIndex = 5;
            this.chDashboard.Text = "Dashboard issues";
            this.chDashboard.UseVisualStyleBackColor = true;
            this.chDashboard.CheckedChanged += new System.EventHandler(this.chDashboard_CheckedChanged);
            // 
            // chReportable
            // 
            this.chReportable.AutoSize = true;
            this.chReportable.Location = new System.Drawing.Point(130, 21);
            this.chReportable.Name = "chReportable";
            this.chReportable.Size = new System.Drawing.Size(110, 17);
            this.chReportable.TabIndex = 6;
            this.chReportable.Text = "Reportable issues";
            this.chReportable.UseVisualStyleBackColor = true;
            this.chReportable.CheckedChanged += new System.EventHandler(this.chReportable_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OpenIssue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btAddLog);
            this.Controls.Add(this.btAddIssue);
            this.Controls.Add(this.gvIssues);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Main Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvIssues)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvIssues;
        private System.Windows.Forms.Button btAddIssue;
        private System.Windows.Forms.Button btAddLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpenIssue;
        private System.Windows.Forms.CheckBox chIssue;
        private System.Windows.Forms.CheckBox chLog;
        private System.Windows.Forms.CheckBox chLow;
        private System.Windows.Forms.CheckBox chMedium;
        private System.Windows.Forms.CheckBox chHigh;
        private System.Windows.Forms.CheckBox chClosed;
        private System.Windows.Forms.CheckBox chInprogress;
        private System.Windows.Forms.CheckBox chNew;
        private System.Windows.Forms.CheckBox chOnhold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chDashboard;
        private System.Windows.Forms.CheckBox chReportable;
    }
}

