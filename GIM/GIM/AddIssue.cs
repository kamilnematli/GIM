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
        public int FuncID;

        public AddIssue(int _id)
        {
            InitializeComponent();
            FuncID = _id;
        }

        private void AddIssue_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            DataSet dsSeverity = dba.GetTable("GIMSeverity");
            //DataRow rCT = dsSeverity.Tables[0].NewRow();
            //rCT["ID"] = 0;
            //rCT["SeverityName"] = "";
            //dsSeverity.Tables[0].Rows.Add(rCT);
            DataView dvSeverity = new DataView(dsSeverity.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbSeverity.DataSource = dvSeverity;
            cbSeverity.DisplayMember = "SeverityName";
            cbSeverity.ValueMember = "ID";

            DataSet dsFuncs = dba.GetTable("GIMfunc");
            DataView dvFuncs = new DataView(dsFuncs.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            clbImpactedFuncs.DataSource = dvFuncs;
            clbImpactedFuncs.DisplayMember = "FuncCode";
            clbImpactedFuncs.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMfunc");
            DataView dvLead = new DataView(dsLead.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            cbLeadFunc.DataSource = dvLead;
            cbLeadFunc.DisplayMember = "FuncCode";
            cbLeadFunc.ValueMember = "ID";

            DataSet dsVenues = dba.GetTable("GIMvenue");
            DataView dvVenues = new DataView(dsVenues.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            clbImpactedVenues.DataSource = dvVenues;
            clbImpactedVenues.DisplayMember = "VenueCode";
            clbImpactedVenues.ValueMember = "ID";
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            string ImpactedFuncs = "";
            string ImpactedVenues = "";

            try
            {
                dba.InsertIssue(1, tbTitle.Text, Convert.ToInt32(cbStatus.SelectedIndex), Convert.ToInt32(cbSeverity.SelectedIndex), FuncID, tbDesc.Text, Convert.ToInt32(cbLeadFunc.SelectedIndex),
                    ImpactedFuncs, Convert.ToInt32(cbLocation.SelectedIndex), ImpactedVenues, dtOccurence.Text, "", "", 0, 0, Environment.UserName, tbAttachment.Text);
            }
            catch
            {

            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tbAttachment.Text = ofd.FileName;
        }
    }
}
