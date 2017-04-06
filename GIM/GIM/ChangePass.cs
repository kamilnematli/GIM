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
    public partial class ChangePass : Form
    {
        private int UserID;

        public ChangePass(int _userid)
        {
            InitializeComponent();
            UserID = _userid;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();
            
            if(tbPass.Text == tbPass2.Text)
            {
                dba.UpdateUserPassword(UserID, tbPass.Text);
                MessageBox.Show("You have successfully updated the password!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else
            {
                MessageBox.Show("The passwords are not matching. Please check!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
