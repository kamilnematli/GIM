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
        
        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void AddLog_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            DataSet dsFunc = dba.GetTable("GIMFunc");
            //DataRow rCT = dsSeverity.Tables[0].NewRow();
            //rCT["ID"] = 0;
            //rCT["SeverityName"] = "";
            //dsSeverity.Tables[0].Rows.Add(rCT);
            DataView dv = new DataView(dsFunc.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbFunctions.DataSource = dv;
            cbFunctions.DisplayMember = "FuncCode";
            cbFunctions.ValueMember = "ID";

            DataSet dsFuncs = dba.GetTable("GIMfunc");
            DataView dvFuncs = new DataView(dsFuncs.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            clbImpFunctions.DataSource = dvFuncs;
            clbImpFunctions.DisplayMember = "FuncCode";
            clbImpFunctions.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMvenue");
            DataView dvLead = new DataView(dsLead.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            clbImpVenues.DataSource = dvLead;
            clbImpVenues.DisplayMember = "VenueCode";
            clbImpVenues.ValueMember = "ID";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
