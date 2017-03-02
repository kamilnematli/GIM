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
    public partial class AddLog : Form
    {
        public AddLog()
        {
            InitializeComponent();
        }

        private void addLog_load(object sender, EventArgs e)

        {
            DBlayer dba = new GIM.DBlayer();

            DataSet dsFunc = dba.GetTable("GIMFunc");
            //DataRow rCT = dsSeverity.Tables[0].NewRow();
            //rCT["ID"] = 0;
            //rCT["SeverityName"] = "";
            //dsSeverity.Tables[0].Rows.Add(rCT);
            DataView dv = new DataView(dsFunc.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbFunctions.DataSource = dv;
            cbFunctions.DisplayMember = "FuncName";
            cbFunctions.ValueMember = "ID";

        }
        
        private void btSave_Click(object sender, EventArgs e)
        {

        }
    }
}
