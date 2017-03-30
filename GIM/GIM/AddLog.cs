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
        private int IssueID;
        private int FuncID;

        public AddLog(int _logid, int _funcid)
        {
            InitializeComponent();
            IssueID = _logid;
            FuncID = _funcid;
        }
        
        private void btSave_Click(object sender, EventArgs e)
        {
            
        }

        private void AddLog_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            DataSet dsFuncs = dba.GetTable("GIMfunc", 0);
            DataView dvFuncs = new DataView(dsFuncs.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            clbImpFunctions.DataSource = dvFuncs;
            clbImpFunctions.DisplayMember = "FuncCode";
            clbImpFunctions.ValueMember = "ID";

            cbLeadFunc.DataSource = dvFuncs;
            cbLeadFunc.DisplayMember = "FuncCode";
            cbLeadFunc.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMvenue", 0);
            DataView dvLead = new DataView(dsLead.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            clbImpVenues.DataSource = dvLead;
            clbImpVenues.DisplayMember = "VenueCode";
            clbImpVenues.ValueMember = "ID";

            cbLocation.DataSource = dvLead;
            cbLocation.DisplayMember = "VenueCode";
            cbLocation.ValueMember = "ID";

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
