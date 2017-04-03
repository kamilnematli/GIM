namespace GIM
{
    partial class IssueUpdate
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
            this.btSave = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btAttachment = new System.Windows.Forms.Button();
            this.tbAttachment = new System.Windows.Forms.TextBox();
            this.lbUpdateDate = new System.Windows.Forms.Label();
            this.tbUpdate = new System.Windows.Forms.TextBox();
            this.lbUpdatedBy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(12, 274);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(109, 23);
            this.btSave.TabIndex = 62;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(126, 274);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 23);
            this.btDelete.TabIndex = 63;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(241, 274);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(109, 23);
            this.btCancel.TabIndex = 65;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 16);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 13);
            this.label17.TabIndex = 54;
            this.label17.Text = "Update text";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 61;
            this.label18.Text = "Attachment";
            // 
            // btAttachment
            // 
            this.btAttachment.Location = new System.Drawing.Point(486, 209);
            this.btAttachment.Name = "btAttachment";
            this.btAttachment.Size = new System.Drawing.Size(109, 23);
            this.btAttachment.TabIndex = 57;
            this.btAttachment.Text = "Open";
            this.btAttachment.UseVisualStyleBackColor = true;
            this.btAttachment.Click += new System.EventHandler(this.btAttachment_Click);
            // 
            // tbAttachment
            // 
            this.tbAttachment.Location = new System.Drawing.Point(17, 211);
            this.tbAttachment.Name = "tbAttachment";
            this.tbAttachment.Size = new System.Drawing.Size(463, 20);
            this.tbAttachment.TabIndex = 60;
            // 
            // lbUpdateDate
            // 
            this.lbUpdateDate.AutoSize = true;
            this.lbUpdateDate.Location = new System.Drawing.Point(426, 9);
            this.lbUpdateDate.Name = "lbUpdateDate";
            this.lbUpdateDate.Size = new System.Drawing.Size(75, 13);
            this.lbUpdateDate.TabIndex = 59;
            this.lbUpdateDate.Text = "Updated date:";
            // 
            // tbUpdate
            // 
            this.tbUpdate.Location = new System.Drawing.Point(17, 32);
            this.tbUpdate.Multiline = true;
            this.tbUpdate.Name = "tbUpdate";
            this.tbUpdate.Size = new System.Drawing.Size(578, 153);
            this.tbUpdate.TabIndex = 53;
            // 
            // lbUpdatedBy
            // 
            this.lbUpdatedBy.AutoSize = true;
            this.lbUpdatedBy.Location = new System.Drawing.Point(9, 9);
            this.lbUpdatedBy.Name = "lbUpdatedBy";
            this.lbUpdatedBy.Size = new System.Drawing.Size(65, 13);
            this.lbUpdatedBy.TabIndex = 58;
            this.lbUpdatedBy.Text = "Updated by:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbUpdate);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.btAttachment);
            this.groupBox1.Controls.Add(this.tbAttachment);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 243);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            // 
            // IssueUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 305);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbUpdatedBy);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.lbUpdateDate);
            this.Controls.Add(this.btSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Details";
            this.Load += new System.EventHandler(this.IssueUpdate_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btAttachment;
        private System.Windows.Forms.TextBox tbAttachment;
        private System.Windows.Forms.Label lbUpdateDate;
        private System.Windows.Forms.TextBox tbUpdate;
        private System.Windows.Forms.Label lbUpdatedBy;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}