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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvIssues = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeadFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reportable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dashboard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAddIssue = new System.Windows.Forms.Button();
            this.btAddLog = new System.Windows.Forms.Button();
            this.tbIssueID = new System.Windows.Forms.TextBox();
            this.btOpenIssue = new System.Windows.Forms.Button();
            this.btExport = new System.Windows.Forms.Button();
            this.btRefresh = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btClearFilter = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chMyList = new System.Windows.Forms.CheckBox();
            this.btApplyFilter = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chIssue = new System.Windows.Forms.CheckBox();
            this.chLog = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chLow = new System.Windows.Forms.CheckBox();
            this.chMedium = new System.Windows.Forms.CheckBox();
            this.chHigh = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chNew = new System.Windows.Forms.CheckBox();
            this.chInprogress = new System.Windows.Forms.CheckBox();
            this.chClosed = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chDashboard = new System.Windows.Forms.CheckBox();
            this.chReportable = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbLead = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.clbImpactedVenues = new System.Windows.Forms.CheckedListBox();
            this.clbImpactedFuncs = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbDailyReport = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvIssues)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvIssues
            // 
            this.gvIssues.AllowUserToAddRows = false;
            this.gvIssues.AllowUserToDeleteRows = false;
            this.gvIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvIssues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvIssues.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIssues.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Updated,
            this.IssueType,
            this.Status,
            this.Severity,
            this.Title,
            this.Desc,
            this.LeadFunc,
            this.Reportable,
            this.Dashboard});
            this.gvIssues.Location = new System.Drawing.Point(270, 49);
            this.gvIssues.Name = "gvIssues";
            this.gvIssues.ReadOnly = true;
            this.gvIssues.RowHeadersVisible = false;
            this.gvIssues.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvIssues.Size = new System.Drawing.Size(1068, 639);
            this.gvIssues.TabIndex = 0;
            this.gvIssues.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvIssues_CellDoubleClick);
            this.gvIssues.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gvIssues_CellFormatting);
            this.gvIssues.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.gvIssues_DataBindingComplete);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // Updated
            // 
            this.Updated.DataPropertyName = "DateUpdated";
            dataGridViewCellStyle9.Format = "d MMMM H:mm";
            dataGridViewCellStyle9.NullValue = null;
            this.Updated.DefaultCellStyle = dataGridViewCellStyle9;
            this.Updated.HeaderText = "Updated";
            this.Updated.Name = "Updated";
            this.Updated.ReadOnly = true;
            this.Updated.Width = 90;
            // 
            // IssueType
            // 
            this.IssueType.DataPropertyName = "Type";
            this.IssueType.HeaderText = "Type";
            this.IssueType.Name = "IssueType";
            this.IssueType.ReadOnly = true;
            this.IssueType.Width = 80;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 75;
            // 
            // Severity
            // 
            this.Severity.DataPropertyName = "Severity";
            this.Severity.HeaderText = "Severity";
            this.Severity.Name = "Severity";
            this.Severity.ReadOnly = true;
            this.Severity.Width = 75;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.DefaultCellStyle = dataGridViewCellStyle10;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 450;
            // 
            // Desc
            // 
            this.Desc.DataPropertyName = "Description";
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Visible = false;
            // 
            // LeadFunc
            // 
            this.LeadFunc.DataPropertyName = "Lead function";
            this.LeadFunc.HeaderText = "Lead Function";
            this.LeadFunc.Name = "LeadFunc";
            this.LeadFunc.ReadOnly = true;
            // 
            // Reportable
            // 
            this.Reportable.DataPropertyName = "Reportable";
            this.Reportable.HeaderText = "Reportable";
            this.Reportable.Name = "Reportable";
            this.Reportable.ReadOnly = true;
            this.Reportable.Width = 80;
            // 
            // Dashboard
            // 
            this.Dashboard.DataPropertyName = "Dashboard";
            this.Dashboard.HeaderText = "Dashboard";
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.ReadOnly = true;
            this.Dashboard.Width = 80;
            // 
            // btAddIssue
            // 
            this.btAddIssue.BackColor = System.Drawing.Color.Honeydew;
            this.btAddIssue.Location = new System.Drawing.Point(270, 12);
            this.btAddIssue.Margin = new System.Windows.Forms.Padding(0);
            this.btAddIssue.Name = "btAddIssue";
            this.btAddIssue.Size = new System.Drawing.Size(111, 23);
            this.btAddIssue.TabIndex = 1;
            this.btAddIssue.Text = "Create Issue";
            this.btAddIssue.UseVisualStyleBackColor = true;
            this.btAddIssue.Click += new System.EventHandler(this.AddIssue_Click);
            // 
            // btAddLog
            // 
            this.btAddLog.Location = new System.Drawing.Point(386, 12);
            this.btAddLog.Name = "btAddLog";
            this.btAddLog.Size = new System.Drawing.Size(111, 23);
            this.btAddLog.TabIndex = 2;
            this.btAddLog.Text = "Create Log";
            this.btAddLog.UseVisualStyleBackColor = true;
            this.btAddLog.Click += new System.EventHandler(this.AddLog_Click);
            // 
            // tbIssueID
            // 
            this.tbIssueID.Location = new System.Drawing.Point(969, 14);
            this.tbIssueID.Name = "tbIssueID";
            this.tbIssueID.Size = new System.Drawing.Size(117, 20);
            this.tbIssueID.TabIndex = 3;
            // 
            // btOpenIssue
            // 
            this.btOpenIssue.Location = new System.Drawing.Point(1092, 12);
            this.btOpenIssue.Name = "btOpenIssue";
            this.btOpenIssue.Size = new System.Drawing.Size(58, 23);
            this.btOpenIssue.TabIndex = 4;
            this.btOpenIssue.Text = "Open";
            this.btOpenIssue.UseVisualStyleBackColor = true;
            this.btOpenIssue.Click += new System.EventHandler(this.btOpenIssue_Click);
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(621, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 23);
            this.btExport.TabIndex = 17;
            this.btExport.Text = "Export to Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // btRefresh
            // 
            this.btRefresh.Location = new System.Drawing.Point(503, 12);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(112, 23);
            this.btRefresh.TabIndex = 23;
            this.btRefresh.Text = "Refresh the list";
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.LightYellow;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(264, 701);
            this.splitter1.TabIndex = 26;
            this.splitter1.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox8.Controls.Add(this.btClearFilter);
            this.groupBox8.Controls.Add(this.groupBox5);
            this.groupBox8.Controls.Add(this.btApplyFilter);
            this.groupBox8.Controls.Add(this.groupBox3);
            this.groupBox8.Controls.Add(this.groupBox1);
            this.groupBox8.Controls.Add(this.groupBox2);
            this.groupBox8.Controls.Add(this.groupBox4);
            this.groupBox8.Controls.Add(this.groupBox7);
            this.groupBox8.Controls.Add(this.groupBox6);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(11, 7);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(243, 681);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Filter";
            // 
            // btClearFilter
            // 
            this.btClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClearFilter.Location = new System.Drawing.Point(6, 654);
            this.btClearFilter.Name = "btClearFilter";
            this.btClearFilter.Size = new System.Drawing.Size(111, 21);
            this.btClearFilter.TabIndex = 25;
            this.btClearFilter.Text = "Clear filter";
            this.btClearFilter.UseVisualStyleBackColor = true;
            this.btClearFilter.Click += new System.EventHandler(this.btClearFilter_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chMyList);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(111, 51);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Creator";
            // 
            // chMyList
            // 
            this.chMyList.AutoSize = true;
            this.chMyList.Location = new System.Drawing.Point(13, 21);
            this.chMyList.Name = "chMyList";
            this.chMyList.Size = new System.Drawing.Size(90, 17);
            this.chMyList.TabIndex = 5;
            this.chMyList.Text = "Raised by me";
            this.chMyList.UseVisualStyleBackColor = true;
            // 
            // btApplyFilter
            // 
            this.btApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btApplyFilter.Location = new System.Drawing.Point(123, 654);
            this.btApplyFilter.Name = "btApplyFilter";
            this.btApplyFilter.Size = new System.Drawing.Size(111, 21);
            this.btApplyFilter.TabIndex = 24;
            this.btApplyFilter.Text = "Apply filter";
            this.btApplyFilter.UseVisualStyleBackColor = true;
            this.btApplyFilter.Click += new System.EventHandler(this.btApplyFilter_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chIssue);
            this.groupBox3.Controls.Add(this.chLog);
            this.groupBox3.Location = new System.Drawing.Point(6, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 51);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chLow);
            this.groupBox1.Controls.Add(this.chMedium);
            this.groupBox1.Controls.Add(this.chHigh);
            this.groupBox1.Location = new System.Drawing.Point(6, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 51);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Severity";
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chNew);
            this.groupBox2.Controls.Add(this.chInprogress);
            this.groupBox2.Controls.Add(this.chClosed);
            this.groupBox2.Location = new System.Drawing.Point(6, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 51);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
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
            // 
            // chClosed
            // 
            this.chClosed.AutoSize = true;
            this.chClosed.Location = new System.Drawing.Point(153, 21);
            this.chClosed.Name = "chClosed";
            this.chClosed.Size = new System.Drawing.Size(58, 17);
            this.chClosed.TabIndex = 12;
            this.chClosed.Text = "Closed";
            this.chClosed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chDashboard);
            this.groupBox4.Controls.Add(this.chReportable);
            this.groupBox4.Location = new System.Drawing.Point(6, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 51);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Flagged issues";
            // 
            // chDashboard
            // 
            this.chDashboard.AutoSize = true;
            this.chDashboard.Location = new System.Drawing.Point(17, 21);
            this.chDashboard.Name = "chDashboard";
            this.chDashboard.Size = new System.Drawing.Size(78, 17);
            this.chDashboard.TabIndex = 5;
            this.chDashboard.Text = "Dashboard";
            this.chDashboard.UseVisualStyleBackColor = true;
            // 
            // chReportable
            // 
            this.chReportable.AutoSize = true;
            this.chReportable.Location = new System.Drawing.Point(101, 21);
            this.chReportable.Name = "chReportable";
            this.chReportable.Size = new System.Drawing.Size(78, 17);
            this.chReportable.TabIndex = 6;
            this.chReportable.Text = "Reportable";
            this.chReportable.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbLead);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Location = new System.Drawing.Point(123, 19);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(111, 51);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Lead";
            // 
            // cbLead
            // 
            this.cbLead.FormattingEnabled = true;
            this.cbLead.Location = new System.Drawing.Point(54, 17);
            this.cbLead.Name = "cbLead";
            this.cbLead.Size = new System.Drawing.Size(51, 21);
            this.cbLead.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Function";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.clbImpactedVenues);
            this.groupBox6.Controls.Add(this.clbImpactedFuncs);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(6, 305);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(228, 343);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Impacted";
            // 
            // clbImpactedVenues
            // 
            this.clbImpactedVenues.CheckOnClick = true;
            this.clbImpactedVenues.FormattingEnabled = true;
            this.clbImpactedVenues.Location = new System.Drawing.Point(126, 37);
            this.clbImpactedVenues.Name = "clbImpactedVenues";
            this.clbImpactedVenues.Size = new System.Drawing.Size(92, 289);
            this.clbImpactedVenues.TabIndex = 26;
            // 
            // clbImpactedFuncs
            // 
            this.clbImpactedFuncs.CheckOnClick = true;
            this.clbImpactedFuncs.FormattingEnabled = true;
            this.clbImpactedFuncs.Location = new System.Drawing.Point(11, 37);
            this.clbImpactedFuncs.Name = "clbImpactedFuncs";
            this.clbImpactedFuncs.Size = new System.Drawing.Size(92, 289);
            this.clbImpactedFuncs.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Venues";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Functions";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1231, 7);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbDailyReport
            // 
            this.lbDailyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDailyReport.AutoSize = true;
            this.lbDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDailyReport.Location = new System.Drawing.Point(1266, 26);
            this.lbDailyReport.Name = "lbDailyReport";
            this.lbDailyReport.Size = new System.Drawing.Size(72, 13);
            this.lbDailyReport.TabIndex = 29;
            this.lbDailyReport.TabStop = true;
            this.lbDailyReport.Text = "Daily report";
            this.lbDailyReport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbDailyReport_LinkClicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1350, 701);
            this.Controls.Add(this.lbDailyReport);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btAddIssue);
            this.Controls.Add(this.btAddLog);
            this.Controls.Add(this.btRefresh);
            this.Controls.Add(this.btExport);
            this.Controls.Add(this.btOpenIssue);
            this.Controls.Add(this.tbIssueID);
            this.Controls.Add(this.gvIssues);
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Games Issue Management System - Main window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvIssues)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvIssues;
        private System.Windows.Forms.Button btAddIssue;
        private System.Windows.Forms.Button btAddLog;
        private System.Windows.Forms.TextBox tbIssueID;
        private System.Windows.Forms.Button btOpenIssue;
        private System.Windows.Forms.Button btExport;
        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chMyList;
        private System.Windows.Forms.Button btApplyFilter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chIssue;
        private System.Windows.Forms.CheckBox chLog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chLow;
        private System.Windows.Forms.CheckBox chMedium;
        private System.Windows.Forms.CheckBox chHigh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chNew;
        private System.Windows.Forms.CheckBox chInprogress;
        private System.Windows.Forms.CheckBox chClosed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chDashboard;
        private System.Windows.Forms.CheckBox chReportable;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbLead;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckedListBox clbImpactedVenues;
        private System.Windows.Forms.CheckedListBox clbImpactedFuncs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel lbDailyReport;
        private System.Windows.Forms.Button btClearFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeadFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reportable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dashboard;
    }
}

