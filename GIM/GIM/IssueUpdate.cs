using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIM
{
    public partial class IssueUpdate : Form
    {
        private int UserID;
        private int UpdateID;

        public IssueUpdate(int _userid, int _updateid)
        {
            InitializeComponent();
            UserID = _userid;
            UpdateID = _updateid;
        }

        private void IssueUpdate_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            try
            {
                DataSet dUpdate = dba.GetTable("GIMupdateLog", UpdateID);
                lbUpdateDate.Text += " " + dUpdate.Tables[0].Rows[0]["DateUpdate"].ToString();
                lbUpdatedBy.Text += " " + dUpdate.Tables[0].Rows[0]["Creator"].ToString();
                tbUpdate.Text = dUpdate.Tables[0].Rows[0]["UpdateContext"].ToString();
                tbAttachment.Text = dUpdate.Tables[0].Rows[0]["FileUploaded"].ToString();
                
                if(UserID == 1 || UserID == Convert.ToInt32(dUpdate.Tables[0].Rows[0]["UpdatedBy"]))
                {
                    btDelete.Enabled = true;
                }
                else
                {
                    btDelete.Enabled = false;
                }  
            }
            catch { }
        }

        private void btAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbAttachment.Text != "")
                {
                    System.Diagnostics.Process.Start(tbAttachment.Text);
                }
                else
                {
                    MessageBox.Show("No attachment has been found", "No attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Could not open the document. Possible reasons are: 1- the attachment has been removed after uploading, 2- the current user doesn't have access to the attachment. Please contact with RDY team to resolve the issue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                DBlayer dba = new GIM.DBlayer();
                dba.UpdateComment(UpdateID, tbUpdate.Text, tbAttachment.Text);
                this.Close();
            }
            catch { }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DBlayer dba = new GIM.DBlayer();
                dba.DeleteComment(UpdateID);
                this.Close();
            }
            catch { }
        }
    }
}
