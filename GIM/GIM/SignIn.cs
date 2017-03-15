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
            DataSet dsUser = dba.GetUsers();
            DataRow rCT = dsUser.Tables[0].NewRow();
            rCT["ID"] = 0;
            rCT["UserName"] = "Select";
            dsUser.Tables[0].Rows.Add(rCT);
            DataView dvFunc = new DataView(dsUser.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbUsers.DataSource = dvFunc;
            cbUsers.DisplayMember = "UserName";
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

            if (dba.CheckPassword(Convert.ToInt32(cbUsers.SelectedIndex), tbPass.Text))
            {
                MainWindow frm = new MainWindow(Convert.ToInt32(cbUsers.SelectedIndex));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The inputed information is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
