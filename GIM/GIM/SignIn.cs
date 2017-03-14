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
            DataSet dsFunc = dba.GetTable("GIMfunc", 0);

            DataRow rCT = dsFunc.Tables[0].NewRow();
            rCT["ID"] = 0;
            rCT["FuncName"] = "Select";
            dsFunc.Tables[0].Rows.Add(rCT);
            DataView dvFunc = new DataView(dsFunc.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbFuncs.DataSource = dvFunc;
            cbFuncs.DisplayMember = "FuncCode";
            cbFuncs.ValueMember = "ID";
        }

        private void tbEnter_Click(object sender, EventArgs e)
        {
            DBlayer dba = new DBlayer();
            if (dba.IsServerConnected() == false)
            {
                MessageBox.Show("Please check your connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dba.CheckPassword(Convert.ToInt32(cbFuncs.SelectedIndex), tbPass.Text))
            {
                MainWindow frm = new MainWindow(Convert.ToInt32(cbFuncs.SelectedIndex));
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("The inputed information is not correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
