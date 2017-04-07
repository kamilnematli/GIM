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
            this.tbEdit = new System.Windows.Forms.Button();
            this.cbLeadFunc = new System.Windows.Forms.ComboBox();
            this.dtOccurence = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbMins = new System.Windows.Forms.ComboBox();
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
            this.dtUpdated = new System.Windows.Forms.DateTimePicker();
            this.dtActualEnd = new System.Windows.Forms.DateTimePicker();
            this.chDashboard = new System.Windows.Forms.CheckBox();
            this.chReportable = new System.Windows.Forms.CheckBox();
            this.cbHour3 = new System.Windows.Forms.ComboBox();
            this.cbHour2 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbMin2 = new System.Windows.Forms.ComboBox();
            this.gvUpdates = new System.Windows.Forms.DataGridView();
            this.UpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FileUploaded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMin3 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblDoc = new System.Windows.Forms.Label();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbAttachment = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSubmitUpdate = new System.Windows.Forms.Button();
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
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(153, 12);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(136, 23);
            this.tbEdit.TabIndex = 32;
            this.tbEdit.Text = "Edit issue";
            this.tbEdit.UseVisualStyleBackColor = true;
            this.tbEdit.Click += new System.EventHandler(this.tbEdit_Click);
            // 
            // cbLeadFunc
            // 
            this.cbLeadFunc.FormattingEnabled = true;
            this.cbLeadFunc.Location = new System.Drawing.Point(19, 310);
            this.cbLeadFunc.Name = "cbLeadFunc";
            this.cbLeadFunc.Size = new System.Drawing.Size(197, 21);
            this.cbLeadFunc.TabIndex = 4;
            // 
            // dtOccurence
            // 
            this.dtOccurence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtOccurence.Location = new System.Drawing.Point(19, 487);
            this.dtOccurence.Name = "dtOccurence";
            this.dtOccurence.Size = new System.Drawing.Size(136, 20);
            this.dtOccurence.TabIndex = 8;
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
            this.tbDesc.Location = new System.Drawing.Point(19, 121);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
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
            this.tbTitle.Location = new System.Drawing.Point(19, 38);
            this.tbTitle.Multiline = true;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbTitle.Size = new System.Drawing.Size(409, 63);
            this.tbTitle.TabIndex = 1;
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(170, 487);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(46, 21);
            this.cbHour.TabIndex = 9;
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
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(231, 310);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(197, 21);
            this.cbStatus.TabIndex = 5;
            // 
            // cbMins
            // 
            this.cbMins.FormattingEnabled = true;
            this.cbMins.Location = new System.Drawing.Point(231, 487);
            this.cbMins.Name = "cbMins";
            this.cbMins.Size = new System.Drawing.Size(46, 21);
            this.cbMins.TabIndex = 10;
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
            this.cbSeverity.FormattingEnabled = true;
            this.cbSeverity.Location = new System.Drawing.Point(231, 223);
            this.cbSeverity.Name = "cbSeverity";
            this.cbSeverity.Size = new System.Drawing.Size(197, 21);
            this.cbSeverity.TabIndex = 3;
            // 
            // cbLocation
            // 
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
            this.tbLocationDesc.Location = new System.Drawing.Point(19, 267);
            this.tbLocationDesc.Name = "tbLocationDesc";
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
            this.tbImpactedFuncs.Location = new System.Drawing.Point(19, 352);
            this.tbImpactedFuncs.Multiline = true;
            this.tbImpactedFuncs.Name = "tbImpactedFuncs";
            this.tbImpactedFuncs.Size = new System.Drawing.Size(409, 46);
            this.tbImpactedFuncs.TabIndex = 34;
            // 
            // tbImpactedVenues
            // 
            this.tbImpactedVenues.Location = new System.Drawing.Point(19, 419);
            this.tbImpactedVenues.Multiline = true;
            this.tbImpactedVenues.Name = "tbImpactedVenues";
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
            // dtUpdated
            // 
            this.dtUpdated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUpdated.Location = new System.Drawing.Point(19, 532);
            this.dtUpdated.Name = "dtUpdated";
            this.dtUpdated.Size = new System.Drawing.Size(136, 20);
            this.dtUpdated.TabIndex = 36;
            // 
            // dtActualEnd
            // 
            this.dtActualEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtActualEnd.Location = new System.Drawing.Point(19, 577);
            this.dtActualEnd.Name = "dtActualEnd";
            this.dtActualEnd.Size = new System.Drawing.Size(136, 20);
            this.dtActualEnd.TabIndex = 41;
            // 
            // chDashboard
            // 
            this.chDashboard.AutoSize = true;
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
            this.chReportable.Location = new System.Drawing.Point(350, 534);
            this.chReportable.Name = "chReportable";
            this.chReportable.Size = new System.Drawing.Size(78, 17);
            this.chReportable.TabIndex = 21;
            this.chReportable.Text = "Reportable";
            this.chReportable.UseVisualStyleBackColor = true;
            // 
            // cbHour3
            // 
            this.cbHour3.FormattingEnabled = true;
            this.cbHour3.Location = new System.Drawing.Point(170, 577);
            this.cbHour3.Name = "cbHour3";
            this.cbHour3.Size = new System.Drawing.Size(46, 21);
            this.cbHour3.TabIndex = 42;
            // 
            // cbHour2
            // 
            this.cbHour2.FormattingEnabled = true;
            this.cbHour2.Location = new System.Drawing.Point(170, 532);
            this.cbHour2.Name = "cbHour2";
            this.cbHour2.Size = new System.Drawing.Size(46, 21);
            this.cbHour2.TabIndex = 37;
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
            // cbMin2
            // 
            this.cbMin2.FormattingEnabled = true;
            this.cbMin2.Location = new System.Drawing.Point(231, 532);
            this.cbMin2.Name = "cbMin2";
            this.cbMin2.Size = new System.Drawing.Size(46, 21);
            this.cbMin2.TabIndex = 38;
            // 
            // gvUpdates
            // 
            this.gvUpdates.AllowUserToAddRows = false;
            this.gvUpdates.AllowUserToDeleteRows = false;
            this.gvUpdates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            // cbMin3
            // 
            this.cbMin3.FormattingEnabled = true;
            this.cbMin3.Location = new System.Drawing.Point(231, 577);
            this.cbMin3.Name = "cbMin3";
            this.cbMin3.Size = new System.Drawing.Size(46, 21);
            this.cbMin3.TabIndex = 43;
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
            this.groupBox1.Controls.Add(this.btSubmitUpdate);
            this.groupBox1.Controls.Add(this.tbAttachment);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tbUpdate);
            this.groupBox1.Controls.Add(this.lblDoc);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.cbMin3);
            this.groupBox1.Controls.Add(this.gvUpdates);
            this.groupBox1.Controls.Add(this.cbMin2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbHour2);
            this.groupBox1.Controls.Add(this.cbHour3);
            this.groupBox1.Controls.Add(this.chReportable);
            this.groupBox1.Controls.Add(this.chDashboard);
            this.groupBox1.Controls.Add(this.dtActualEnd);
            this.groupBox1.Controls.Add(this.dtUpdated);
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
            this.groupBox1.Controls.Add(this.cbMins);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbHour);
            this.groupBox1.Controls.Add(this.tbTitle);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbDesc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtOccurence);
            this.groupBox1.Controls.Add(this.cbLeadFunc);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1260, 608);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
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
            // EditIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbEdit);
            this.Controls.Add(this.btDoc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditIssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue details";
            this.Load += new System.EventHandler(this.EditIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUpdates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button tbEdit;
        private System.Windows.Forms.Button btDoc;
        private System.Windows.Forms.ComboBox cbLeadFunc;
        private System.Windows.Forms.DateTimePicker dtOccurence;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbMins;
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
        private System.Windows.Forms.DateTimePicker dtUpdated;
        private System.Windows.Forms.DateTimePicker dtActualEnd;
        private System.Windows.Forms.CheckBox chDashboard;
        private System.Windows.Forms.CheckBox chReportable;
        private System.Windows.Forms.ComboBox cbHour3;
        private System.Windows.Forms.ComboBox cbHour2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbMin2;
        private System.Windows.Forms.DataGridView gvUpdates;
        private System.Windows.Forms.ComboBox cbMin3;
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
    }
}