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
    public partial class EditIssue : Form
    {
        private int IssueID;
        private int FuncID;

        public EditIssue(int _issueId, int _funcId)
        {
            InitializeComponent();
            IssueID = _issueId;
            FuncID = _funcId;
        }

        private void EditIssue_Load(object sender, EventArgs e)
        {
            DBlayer dba = new DBlayer();

            DataSet dsSeverity = dba.GetTable("GIMSeverity", 0);
            DataView dvSeverity = new DataView(dsSeverity.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbSeverity.DataSource = dvSeverity;
            cbSeverity.DisplayMember = "SeverityName";
            cbSeverity.ValueMember = "ID";

            DataSet dsStatus = dba.GetTable("GIMStatus", 0);
            DataView dvStatus = new DataView(dsStatus.Tables[0], "", "ID", DataViewRowState.CurrentRows);
            cbStatus.DataSource = dvStatus;
            cbStatus.DisplayMember = "StatusName";
            cbStatus.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMfunc", 0);
            DataView dvLead = new DataView(dsLead.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            cbLeadFunc.DataSource = dvLead;
            cbLeadFunc.DisplayMember = "FuncCode";
            cbLeadFunc.ValueMember = "ID";

            DataSet dsLocation = dba.GetTable("GIMvenue", 0);
            DataRow rCT = dsLocation.Tables[0].NewRow();
            rCT["ID"] = 0;
            rCT["VenueCode"] = "";
            dsLocation.Tables[0].Rows.Add(rCT);
            DataView dvLocation = new DataView(dsLocation.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            cbLocation.DataSource = dvLocation;
            cbLocation.DisplayMember = "VenueCode";
            cbLocation.ValueMember = "ID";

            DataSet dsIssue = dba.GetTable("GIMissue", IssueID);
            tbTitle.Text = dsIssue.Tables[0].Rows[0]["Title"].ToString();
            tbDesc.Text = dsIssue.Tables[0].Rows[0]["Description"].ToString();
            cbLocation.SelectedValue = dsIssue.Tables[0].Rows[0]["Location"];
            cbSeverity.SelectedValue = dsIssue.Tables[0].Rows[0]["IssueSeverity"];
            tbLocationDesc.Text = dsIssue.Tables[0].Rows[0]["LocationDesc"].ToString();
            cbLeadFunc.SelectedValue = dsIssue.Tables[0].Rows[0]["LeadFunction"];
            lblDoc.Text = dsIssue.Tables[0].Rows[0]["Attachment"].ToString();

            DateTime dtOcc = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateOccurence"].ToString());
            dtOccurence.Value = dtOcc.Date;
            cbHour.Text = dtOcc.Hour.ToString();
            cbMins.Text = dtOcc.Minute.ToString();

            DateTime dtUpd = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateUpdated"].ToString());
            dtUpdated.Value = dtUpd.Date;
            cbHour2.Text = dtUpd.Hour.ToString();
            cbMin2.Text = dtUpd.Minute.ToString();

            DataSet impFuncs = dba.GetIssueImpcFuncs(IssueID);
            string impactedFuncs = "";
            for (int i = 0; i < impFuncs.Tables[0].Rows.Count; i++)
            {
                impactedFuncs += impFuncs.Tables[0].Rows[i]["FuncCode"].ToString() + ", ";
            }
            if (impactedFuncs != "")
            {
                impactedFuncs = impactedFuncs.Substring(0, impactedFuncs.Length - 2);
            }
            tbImpactedFuncs.Text = impactedFuncs;

            DataSet impVenues = dba.GetIssueImpcVenues(IssueID);
            string impactedVenues = "";
            for (int i = 0; i < impVenues.Tables[0].Rows.Count; i++)
            {
                impactedVenues += impVenues.Tables[0].Rows[i]["VenueCode"].ToString() + ", ";
            }
            if (impactedVenues != "")
            {
                impactedVenues = impactedVenues.Substring(0, impactedVenues.Length - 2);
            }
            tbImpactedVenues.Text = impactedVenues;
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblDoc.Text != "")
                {
                    System.Diagnostics.Process.Start(lblDoc.Text);
                }
                else
                {
                    MessageBox.Show("No attachment has been found", "No attachment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Could not open the document. Possible reasons are: 1- the attachment has been removed after uploading, 2- the current user doesn't have access to the attachment. Please contact with RDY team to resolve the issue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbEdit_Click(object sender, EventArgs e)
        {
            AddIssue frm = new GIM.AddIssue(IssueID, FuncID);
            frm.Show();
        }
    }
}
