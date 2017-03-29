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
        private int IssueID;
        private int UserID;

        public IssueUpdate(int _issueid, int _userid)
        {
            InitializeComponent();
            IssueID = _issueid;
            UserID = _userid;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();
            dba.InsertUpdate(UserID, Environment.UserName, tbUpdate.Text, "", tbAttachment.Text);
            this.Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tbAttachment.Text = ofd.FileName;
        }
    }
}
