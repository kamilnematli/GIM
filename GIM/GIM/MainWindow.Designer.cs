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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvIssues)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvIssues
            // 
            this.gvIssues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvIssues.Location = new System.Drawing.Point(12, 109);
            this.gvIssues.Name = "gvIssues";
            this.gvIssues.Size = new System.Drawing.Size(995, 415);
            this.gvIssues.TabIndex = 0;
            // 
            // btAddIssue
            // 
            this.btAddIssue.Location = new System.Drawing.Point(12, 12);
            this.btAddIssue.Name = "btAddIssue";
            this.btAddIssue.Size = new System.Drawing.Size(112, 23);
            this.btAddIssue.TabIndex = 1;
            this.btAddIssue.Text = "Create Issue";
            this.btAddIssue.UseVisualStyleBackColor = true;
            this.btAddIssue.Click += new System.EventHandler(this.AddIssue_Click);
            // 
            // btAddLog
            // 
            this.btAddLog.Location = new System.Drawing.Point(130, 12);
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
            this.textBox1.Location = new System.Drawing.Point(826, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 3;
            // 
            // OpenIssue
            // 
            this.OpenIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenIssue.Location = new System.Drawing.Point(949, 12);
            this.OpenIssue.Name = "OpenIssue";
            this.OpenIssue.Size = new System.Drawing.Size(58, 23);
            this.OpenIssue.TabIndex = 4;
            this.OpenIssue.Text = "Open";
            this.OpenIssue.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Issues";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(75, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(49, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Logs";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(46, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Low";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(63, 21);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(63, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Medium";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(130, 21);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(48, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "High";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(222, 21);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(58, 17);
            this.checkBox6.TabIndex = 12;
            this.checkBox6.Text = "Closed";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(69, 21);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(78, 17);
            this.checkBox7.TabIndex = 11;
            this.checkBox7.Text = "In progress";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(15, 21);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(48, 17);
            this.checkBox8.TabIndex = 10;
            this.checkBox8.Text = "New";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(153, 21);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(63, 17);
            this.checkBox9.TabIndex = 13;
            this.checkBox9.Text = "On hold";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Location = new System.Drawing.Point(160, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Severity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox8);
            this.groupBox2.Controls.Add(this.checkBox7);
            this.groupBox2.Controls.Add(this.checkBox9);
            this.groupBox2.Controls.Add(this.checkBox6);
            this.groupBox2.Location = new System.Drawing.Point(363, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 51);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Location = new System.Drawing.Point(12, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(129, 51);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Type";
            // 
            // btExport
            // 
            this.btExport.Location = new System.Drawing.Point(248, 12);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(112, 23);
            this.btExport.TabIndex = 17;
            this.btExport.Text = "Export to Excel";
            this.btExport.UseVisualStyleBackColor = true;
            this.btExport.Click += new System.EventHandler(this.btExport_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 536);
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
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvIssues)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvIssues;
        private System.Windows.Forms.Button btAddIssue;
        private System.Windows.Forms.Button btAddLog;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button OpenIssue;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btExport;
    }
}

