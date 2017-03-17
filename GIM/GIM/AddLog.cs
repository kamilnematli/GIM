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

            DataSet dsFuncs = dba.GetTable("GIMfunc", 0);
            DataView dvFuncs = new DataView(dsFuncs.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            clbImpFunctions.DataSource = dvFuncs;
            clbImpFunctions.DisplayMember = "FuncCode";
            clbImpFunctions.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMvenue", 0);
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
