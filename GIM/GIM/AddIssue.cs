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
    public partial class AddIssue : Form
    {
        public AddIssue()
        {
            InitializeComponent();
        }

        private void AddIssue_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            DataSet dsSeverity = dba.GetTable("GIMSeverity");
            //DataRow rCT = dsSeverity.Tables[0].NewRow();
            //rCT["ID"] = 0;
            //rCT["SeverityName"] = "";
            //dsSeverity.Tables[0].Rows.Add(rCT);
            DataView dv = new DataView(dsSeverity.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbSeverity.DataSource = dv;
            cbSeverity.DisplayMember = "SeverityName";
            cbSeverity.ValueMember = "ID";
        }
    }
}
