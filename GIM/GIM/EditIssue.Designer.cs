namespace GIM
{
    partial class EditIssue
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
            this.btDoc = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.cbLeadFunc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSeverity = new System.Windows.Forms.ComboBox();
            this.cbLocation = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbLocationDesc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbImpactedFuncs = new System.Windows.Forms.TextBox();
            this.tbImpactedVenues = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chDashboard = new System.Windows.Forms.CheckBox();
            this.chReportable = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gvUpdates = new System.Windows.Forms.DataGridView();
            this.UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileUploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbAttachment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDactual = new System.Windows.Forms.TextBox();
            this.tbDupdate = new System.Windows.Forms.TextBox();
            this.tbDoccur = new System.Windows.Forms.TextBox();
            this.tbMin3 = new System.Windows.Forms.TextBox();
            this.tbMin2 = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbHour3 = new System.Windows.Forms.TextBox();
            this.tbHour2 = new System.Windows.Forms.TextBox();
            this.tbHour = new System.Windows.Forms.TextBox();
            this.btSubmitUpdate = new System.Windows.Forms.Button();
            this.lblRaisedBy = new System.Windows.Forms.Label();
            this.btCloseIssue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdates)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDoc
            // 
            this.btDoc.Location = new System.Drawing.Point(12, 12);
            this.btDoc.Name = "btDoc";
            this.btDoc.Size = new System.Drawing.Size(136, 23);
            this.btDoc.TabIndex = 46;
            this.btDoc.Text = "Open attachment";
            this.btDoc.UseVisualStyleBackColor = true;
            this.btDoc.Click += new System.EventHandler(this.btDoc_Click);
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(153, 12);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(136, 23);
            this.btEdit.TabIndex = 32;
            this.btEdit.Text = "Edit issue";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // cbLeadFunc
            // 
            this.cbLeadFunc.Enabled = false;
            this.cbLeadFunc.FormattingEnabled = true;
            this.cbLeadFunc.Location = new System.Drawing.Point(19, 310);
            this.cbLeadFunc.Name = "cbLeadFunc";
            this.cbLeadFunc.Size = new System.Drawing.Size(197, 21);
            this.cbLeadFunc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Impacted functions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 471);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Date/time of occurence";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Impacted venues";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lead function";
            // 
            // tbDesc
            // 
            this.tbDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDesc.Location = new System.Drawing.Point(19, 121);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.ReadOnly = true;
            this.tbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDesc.Size = new System.Drawing.Size(409, 79);
            this.tbDesc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // tbTitle
            // 
            this.tbTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbTitle.Location = new System.Drawing.Point(19, 38);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ReadOnly = true;
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTitle.Size = new System.Drawing.Size(409, 63);
            this.tbTitle.TabIndex = 1;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(219, 490);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Status";
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(231, 310);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 518);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Date/time of update";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Severity";
            // 
            // cbSeverity
            // 
            this.cbSeverity.Enabled = false;
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(231, 223);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(197, 21);
            this.cbSeverity.TabIndex = 3;
            // 
            // cbLocation
            // 
            this.cbLocation.Enabled = false;
            this.cbLocation.FormattingEnabled = true;
            this.cbLocation.Location = new System.Drawing.Point(19, 223);
            this.cbLocation.Name = "cbLocation";
            this.cbLocation.Size = new System.Drawing.Size(197, 21);
            this.cbLocation.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Location";
            // 
            // tbLocationDesc
            // 
            this.tbLocationDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbLocationDesc.Enabled = false;
            this.tbLocationDesc.Location = new System.Drawing.Point(19, 267);
            this.tbLocationDesc.Name = "tbLocationDesc";
            this.tbLocationDesc.ReadOnly = true;
            this.tbLocationDesc.Size = new System.Drawing.Size(409, 20);
            this.tbLocationDesc.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Location description";
            // 
            // tbImpactedFuncs
            // 
            this.tbImpactedFuncs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbImpactedFuncs.Location = new System.Drawing.Point(19, 352);
            this.tbImpactedFuncs.Multiline = true;
            this.tbImpactedFuncs.Name = "tbImpactedFuncs";
            this.tbImpactedFuncs.ReadOnly = true;
            this.tbImpactedFuncs.Size = new System.Drawing.Size(409, 46);
            this.tbImpactedFuncs.TabIndex = 34;
            // 
            // tbImpactedVenues
            // 
            this.tbImpactedVenues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbImpactedVenues.Location = new System.Drawing.Point(19, 419);
            this.tbImpactedVenues.Multiline = true;
            this.tbImpactedVenues.Name = "tbImpactedVenues";
            this.tbImpactedVenues.ReadOnly = true;
            this.tbImpactedVenues.Size = new System.Drawing.Size(409, 46);
            this.tbImpactedVenues.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 561);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Actual end date/time";
            // 
            // chDashboard
            // 
            this.chDashboard.AutoSize = true;
            this.chDashboard.Enabled = false;
            this.chDashboard.Location = new System.Drawing.Point(350, 491);
            this.chDashboard.Name = "chDashboard";
            this.chDashboard.Size = new System.Drawing.Size(78, 17);
            this.chDashboard.TabIndex = 20;
            this.chDashboard.Text = "Dashboard";
            this.chDashboard.UseVisualStyleBackColor = true;
            // 
            // chReportable
            // 
            this.chReportable.AutoSize = true;
            this.chReportable.Enabled = false;
            this.chReportable.Location = new System.Drawing.Point(350, 534);
            this.chReportable.Name = "chReportable";
            this.chReportable.Size = new System.Drawing.Size(78, 17);
            this.chReportable.TabIndex = 21;
            this.chReportable.Text = "Reportable";
            this.chReportable.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 535);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(10, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = ":";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 580);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 13);
            this.label15.TabIndex = 44;
            this.label15.Text = ":";
            // 
            // gvUpdates
            // 
            this.gvUpdates.AllowUserToAddRows = false;
            this.gvUpdates.AllowUserToDeleteRows = false;
            this.gvUpdates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gvUpdates.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gvUpdates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUpdates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpdateDate,
            this.updateId,
            this.UpdateType,
            this.FileUploaded,
            this.UpdatedBy,
            this.UpdateText});
            this.gvUpdates.Location = new System.Drawing.Point(460, 38);
            this.gvUpdates.MultiSelect = false;
            this.gvUpdates.Name = "gvUpdates";
            this.gvUpdates.RowHeadersVisible = false;
            this.gvUpdates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvUpdates.Size = new System.Drawing.Size(784, 413);
            this.gvUpdates.TabIndex = 40;
            this.gvUpdates.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUpdates_CellDoubleClick);
            // 
            // UpdateDate
            // 
            this.UpdateDate.DataPropertyName = "DateUpdate";
            dataGridViewCellStyle1.Format = "d MMMM H:mm";
            dataGridViewCellStyle1.NullValue = null;
            this.UpdateDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.UpdateDate.HeaderText = "Update date";
            this.UpdateDate.Name = "UpdateDate";
            this.UpdateDate.Width = 90;
            // 
            // updateId
            // 
            this.updateId.DataPropertyName = "ID";
            this.updateId.HeaderText = "ID";
            this.updateId.Name = "updateId";
            this.updateId.Visible = false;
            // 
            // UpdateType
            // 
            this.UpdateType.DataPropertyName = "UpdateType";
            this.UpdateType.HeaderText = "UpdateType";
            this.UpdateType.Name = "UpdateType";
            this.UpdateType.Visible = false;
            // 
            // FileUploaded
            // 
            this.FileUploaded.DataPropertyName = "FileUploaded";
            this.FileUploaded.HeaderText = "FileUploaded";
            this.FileUploaded.Name = "FileUploaded";
            this.FileUploaded.Visible = false;
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.DataPropertyName = "UpdatedBy";
            this.UpdatedBy.HeaderText = "Updated by";
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.Width = 120;
            // 
            // UpdateText
            // 
            this.UpdateText.DataPropertyName = "UpdateContext";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UpdateText.DefaultCellStyle = dataGridViewCellStyle2;
            this.UpdateText.HeaderText = "Update description";
            this.UpdateText.Name = "UpdateText";
            this.UpdateText.Width = 550;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(457, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Updates/Comments";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(175, 571);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(0, 13);
            this.lblDoc.TabIndex = 47;
            this.lblDoc.Visible = false;
            // 
            // tbUpdate
            // 
            this.tbUpdate.Location = new System.Drawing.Point(460, 478);
            this.tbUpdate.Multiline = true;
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUpdate.Size = new System.Drawing.Size(784, 80);
            this.tbUpdate.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(457, 462);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Update field";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(457, 564);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "Attachment";
            // 
            // tbAttachment
            // 
            this.tbAttachment.Location = new System.Drawing.Point(460, 578);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.Size = new System.Drawing.Size(662, 20);
            this.tbAttachment.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDactual);
            this.groupBox1.Controls.Add(this.tbDupdate);
            this.groupBox1.Controls.Add(this.tbDoccur);
            this.groupBox1.Controls.Add(this.tbMin3);
            this.groupBox1.Controls.Add(this.tbMin2);
            this.groupBox1.Controls.Add(this.tbMin);
            this.groupBox1.Controls.Add(this.tbHour3);
            this.groupBox1.Controls.Add(this.tbHour2);
            this.groupBox1.Controls.Add(this.tbHour);
            this.groupBox1.Controls.Add(this.btSubmitUpdate);
            this.groupBox1.Controls.Add(this.tbAttachment);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbUpdate);
            this.groupBox1.Controls.Add(this.lblDoc);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.gvUpdates);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.chReportable);
            this.groupBox1.Controls.Add(this.chDashboard);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbImpactedVenues);
            this.groupBox1.Controls.Add(this.tbImpactedFuncs);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tbLocationDesc);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbLocation);
            this.groupBox1.Controls.Add(this.cbSeverity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbLeadFunc);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 608);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // tbDactual
            // 
            this.tbDactual.AccessibleName = "";
            this.tbDactual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDactual.Location = new System.Drawing.Point(19, 577);
            this.tbDactual.Name = "tbDactual";
            this.tbDactual.ReadOnly = true;
            this.tbDactual.Size = new System.Drawing.Size(136, 20);
            this.tbDactual.TabIndex = 61;
            // 
            // tbDupdate
            // 
            this.tbDupdate.AccessibleName = "";
            this.tbDupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDupdate.Location = new System.Drawing.Point(19, 532);
            this.tbDupdate.Name = "tbDupdate";
            this.tbDupdate.ReadOnly = true;
            this.tbDupdate.Size = new System.Drawing.Size(136, 20);
            this.tbDupdate.TabIndex = 60;
            // 
            // tbDoccur
            // 
            this.tbDoccur.AccessibleName = "";
            this.tbDoccur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbDoccur.Location = new System.Drawing.Point(19, 487);
            this.tbDoccur.Name = "tbDoccur";
            this.tbDoccur.ReadOnly = true;
            this.tbDoccur.Size = new System.Drawing.Size(136, 20);
            this.tbDoccur.TabIndex = 59;
            // 
            // tbMin3
            // 
            this.tbMin3.AccessibleName = "";
            this.tbMin3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMin3.Location = new System.Drawing.Point(231, 577);
            this.tbMin3.Name = "tbMin3";
            this.tbMin3.ReadOnly = true;
            this.tbMin3.Size = new System.Drawing.Size(46, 20);
            this.tbMin3.TabIndex = 58;
            // 
            // tbMin2
            // 
            this.tbMin2.AccessibleName = "";
            this.tbMin2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMin2.Location = new System.Drawing.Point(231, 532);
            this.tbMin2.Name = "tbMin2";
            this.tbMin2.ReadOnly = true;
            this.tbMin2.Size = new System.Drawing.Size(46, 20);
            this.tbMin2.TabIndex = 57;
            // 
            // tbMin
            // 
            this.tbMin.AccessibleName = "";
            this.tbMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMin.Location = new System.Drawing.Point(231, 487);
            this.tbMin.Name = "tbMin";
            this.tbMin.ReadOnly = true;
            this.tbMin.Size = new System.Drawing.Size(46, 20);
            this.tbMin.TabIndex = 56;
            // 
            // tbHour3
            // 
            this.tbHour3.AccessibleName = "";
            this.tbHour3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbHour3.Location = new System.Drawing.Point(170, 577);
            this.tbHour3.Name = "tbHour3";
            this.tbHour3.ReadOnly = true;
            this.tbHour3.Size = new System.Drawing.Size(46, 20);
            this.tbHour3.TabIndex = 55;
            // 
            // tbHour2
            // 
            this.tbHour2.AccessibleName = "";
            this.tbHour2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbHour2.Location = new System.Drawing.Point(170, 532);
            this.tbHour2.Name = "tbHour2";
            this.tbHour2.ReadOnly = true;
            this.tbHour2.Size = new System.Drawing.Size(46, 20);
            this.tbHour2.TabIndex = 54;
            // 
            // tbHour
            // 
            this.tbHour.AccessibleName = "";
            this.tbHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbHour.Location = new System.Drawing.Point(170, 487);
            this.tbHour.Name = "tbHour";
            this.tbHour.ReadOnly = true;
            this.tbHour.Size = new System.Drawing.Size(46, 20);
            this.tbHour.TabIndex = 53;
            // 
            // btSubmitUpdate
            // 
            this.btSubmitUpdate.Location = new System.Drawing.Point(1135, 576);
            this.btSubmitUpdate.Name = "btSubmitUpdate";
            this.btSubmitUpdate.Size = new System.Drawing.Size(109, 23);
            this.btSubmitUpdate.TabIndex = 52;
            this.btSubmitUpdate.Text = "Submit";
            this.btSubmitUpdate.UseVisualStyleBackColor = true;
            this.btSubmitUpdate.Click += new System.EventHandler(this.btSubmitUpdate_Click);
            // 
            // lblRaisedBy
            // 
            this.lblRaisedBy.AutoSize = true;
            this.lblRaisedBy.Location = new System.Drawing.Point(1042, 22);
            this.lblRaisedBy.Name = "lblRaisedBy";
            this.lblRaisedBy.Size = new System.Drawing.Size(0, 13);
            this.lblRaisedBy.TabIndex = 47;
            // 
            // btCloseIssue
            // 
            this.btCloseIssue.Location = new System.Drawing.Point(295, 12);
            this.btCloseIssue.Name = "btCloseIssue";
            this.btCloseIssue.Size = new System.Drawing.Size(136, 23);
            this.btCloseIssue.TabIndex = 48;
            this.btCloseIssue.Text = "Close issue";
            this.btCloseIssue.UseVisualStyleBackColor = true;
            this.btCloseIssue.Click += new System.EventHandler(this.btCloseIssue_Click);
            // 
            // EditIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.btCloseIssue);
            this.Controls.Add(this.lblRaisedBy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btDoc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditIssue";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue details";
            this.Load += new System.EventHandler(this.EditIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.Button btDoc;
        private System.Windows.Forms.ComboBox cbLeadFunc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSeverity;
        private System.Windows.Forms.ComboBox cbLocation;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbLocationDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbImpactedFuncs;
        private System.Windows.Forms.TextBox tbImpactedVenues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chDashboard;
        private System.Windows.Forms.CheckBox chReportable;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView gvUpdates;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbAttachment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSubmitUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateType;
        private System.Windows.Forms.DataGridViewTextBoxColumn FileUploaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateText;
        private System.Windows.Forms.TextBox tbMin3;
        private System.Windows.Forms.TextBox tbMin2;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbHour3;
        private System.Windows.Forms.TextBox tbHour2;
        private System.Windows.Forms.TextBox tbHour;
        private System.Windows.Forms.TextBox tbDoccur;
        private System.Windows.Forms.TextBox tbDactual;
        private System.Windows.Forms.TextBox tbDupdate;
        private System.Windows.Forms.Label lblRaisedBy;
        private System.Windows.Forms.Button btCloseIssue;
    }
}