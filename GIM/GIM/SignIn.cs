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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();
            if (dba.IsServerConnected() == false)
            {
                MessageBox.Show("Please check your connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            DataSet dsUser = dba.GetUsers(0);
            DataRow rCT = dsUser.Tables[0].NewRow();
            rCT["ID"] = 0;
            rCT["Ucode"] = "Select";
            dsUser.Tables[0].Rows.Add(rCT);
            DataView dvFunc = new DataView(dsUser.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbUsers.DataSource = dvFunc;
            cbUsers.DisplayMember = "Ucode";
            cbUsers.ValueMember = "ID";
        }

        private void tbEnter_Click(object sender, EventArgs e)
        {
            DBlayer dba = new DBlayer();
            if (dba.IsServerConnected() == false)
            {
                MessageBox.Show("Please check your connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dba.CheckPassword(Convert.ToInt32(cbUsers.SelectedValue), tbPass.Text))
            {
                DataSet userDetails = dba.GetUsers(Convert.ToInt32(cbUsers.SelectedValue));
                MainWindow frm = new MainWindow(Convert.ToInt32(cbUsers.SelectedValue), Convert.ToInt32(userDetails.Tables[0].Rows[0]["UserType"]));
                this.Visible = false;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The inputed information is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
