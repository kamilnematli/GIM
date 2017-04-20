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
    public partial class CloseIssue : Form
    {
        private int IssueID;
        private int UserID;

        public CloseIssue(int _issueid, int _userid)
        {
            InitializeComponent();
            IssueID = _issueid;
            UserID = _userid;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                string DateActualEnd = dtActualEnd.Value.ToString("yyyy-MM-dd");
                if (cbH.Text != "" && cbM.Text != "")
                {
                    DateActualEnd = DateActualEnd + " " + cbH.Text + ":" + cbM.Text;
                }

                DBlayer dba = new GIM.DBlayer();
                dba.UpdateStatus(IssueID, DateActualEnd);
                dba.InsertUpdate(IssueID, UserID, Environment.UserName, "The issue is now CLOSED -- " + tbCloseText.Text, "", "");

                MessageBox.Show("You have successfully closed the issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch
            {

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseIssue_Load(object sender, EventArgs e)
        {
            DateTime dActual = DateTime.Now;
            cbH.Text = dActual.Hour.ToString();
            cbM.Text = dActual.Minute.ToString();
        }
    }
}
