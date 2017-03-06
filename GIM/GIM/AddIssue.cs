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
            DataView dvSeverity = new DataView(dsSeverity.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbSeverity.DataSource = dvSeverity;
            cbSeverity.DisplayMember = "SeverityName";
            cbSeverity.ValueMember = "ID";

            DataSet dsStatus = dba.GetTable("GIMStatus");
            DataView dvStatus = new DataView(dsStatus.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbStatus.DataSource = dvStatus;
            cbStatus.DisplayMember = "StatusName";
            cbStatus.ValueMember = "ID";

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

            DataSet dsLocation = dba.GetTable("GIMvenue");
            DataRow rCT = dsLocation.Tables[0].NewRow();
            rCT["ID"] = 0;
            rCT["VenueCode"] = "";
            dsLocation.Tables[0].Rows.Add(rCT);
            DataView dvLocation = new DataView(dsLocation.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            cbLocation.DataSource = dvLocation;
            cbLocation.DisplayMember = "VenueCode";
            cbLocation.ValueMember = "ID";
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

            foreach (object itemChecked in clbImpactedFuncs.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                ImpactedFuncs += castedItem["FuncCode"].ToString() + ",";
            }

            foreach (object itemChecked in clbImpactedVenues.CheckedItems)
            {
                DataRowView castedItem = itemChecked as DataRowView;
                ImpactedVenues += castedItem["VenueCode"].ToString() + ",";
            }

            string DateOccurence = "";
            DateOccurence = dtOccurence.Value.ToString("yyyy-MM-dd");
            DateOccurence = DateOccurence + " " + cbHour.Text + ":" + cbMins.Text; 

            try
            {
                dba.InsertIssue(1, tbTitle.Text, Convert.ToInt32(cbStatus.SelectedValue), Convert.ToInt32(cbSeverity.SelectedValue), FuncID, tbDesc.Text, Convert.ToInt32(cbLeadFunc.SelectedValue),
                    ImpactedFuncs, Convert.ToInt32(cbLocation.SelectedValue), ImpactedVenues, DateOccurence, "", "", 0, 0, Environment.UserName, tbAttachment.Text);

                MessageBox.Show("You have successfully created an issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please check the data that you have inserted, if everything seems ok please check your network connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
