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
        private int UserID;

        public EditIssue(int _issueId, int _userId)
        {
            InitializeComponent();
            IssueID = _issueId;
            UserID = _userId;
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

            LoadEditIssue();    
        }

        private void LoadEditIssue()
        {
            DBlayer dba = new DBlayer();
            DataSet dsIssue = dba.GetTable("GIMissue", IssueID);
            tbTitle.Text = dsIssue.Tables[0].Rows[0]["Title"].ToString();
            tbDesc.Text = dsIssue.Tables[0].Rows[0]["Description"].ToString();
            cbLocation.SelectedValue = dsIssue.Tables[0].Rows[0]["Location"];
            cbStatus.SelectedValue = dsIssue.Tables[0].Rows[0]["IssueStatus"];
            cbSeverity.SelectedValue = dsIssue.Tables[0].Rows[0]["IssueSeverity"];
            tbLocationDesc.Text = dsIssue.Tables[0].Rows[0]["LocationDesc"].ToString();
            cbLeadFunc.SelectedValue = dsIssue.Tables[0].Rows[0]["LeadFunction"];
            lblDoc.Text = dsIssue.Tables[0].Rows[0]["Attachment"].ToString();

            DataSet dsUsers = dba.GetTable("GIMusers", Convert.ToInt32(dsIssue.Tables[0].Rows[0]["RaisedBy"]));
            lblRaisedBy.Text = "Raised by: " + dsUsers.Tables[0].Rows[0]["Ucode"].ToString() + " (" + dsIssue.Tables[0].Rows[0]["Creator"].ToString() + ")";

            DateTime dtOcc = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateOccurence"].ToString());
            tbDoccur.Text = dtOcc.Date.ToShortDateString();
            tbHour.Text = dtOcc.Hour.ToString();
            tbMin.Text = dtOcc.Minute.ToString();

            DateTime dtUpd = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateUpdated"].ToString());
            tbDupdate.Text = dtUpd.Date.ToShortDateString();
            tbHour2.Text = dtUpd.Hour.ToString();
            tbMin2.Text = dtUpd.Minute.ToString();

            if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["IssueStatus"]) == 4)
            {
                if (dsIssue.Tables[0].Rows[0]["DateActualEnd"].ToString() != "")
                {
                    DateTime dtActEnd = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateActualEnd"].ToString());
                    tbDactual.Text = dtActEnd.Date.ToShortDateString();
                    tbHour3.Text = dtActEnd.Hour.ToString();
                    tbMin3.Text = dtActEnd.Minute.ToString();
                }
            }

            if (UserID != 1)
            {
                if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["RaisedBy"]) != UserID)
                {
                    btEdit.Enabled = false;
                    btCloseIssue.Visible = false;
                }
            }

            if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Dashboard"]) == 1)
                chDashboard.Checked = true;
            else
                chDashboard.Checked = false;

            if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Reportable"]) == 1)
                chReportable.Checked = true;
            else
                chReportable.Checked = false;

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

            DataSet dsUpdates = dba.GetUpdates(IssueID);
            DataView dvUpdates = dsUpdates.Tables[0].DefaultView;
            gvUpdates.DataSource = dvUpdates;
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

        private void btSubmitUpdate_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();
            dba.InsertUpdate(IssueID, UserID, Environment.UserName, tbUpdate.Text.Replace("'", "''"), "", tbAttachment.Text);
            tbUpdate.Text = "";
            tbAttachment.Text = "";

            DataSet dsUpdates = dba.GetUpdates(IssueID);
            DataView dvUpdates = dsUpdates.Tables[0].DefaultView;
            gvUpdates.DataSource = dvUpdates;
        }

        private void gvUpdates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueUpdate frm = new IssueUpdate(UserID, Convert.ToInt32(gvUpdates.SelectedRows[0].Cells[0].Value), gvUpdates.SelectedRows[0].Cells["UpdatedBy"].Value.ToString(), 
                gvUpdates.SelectedRows[0].Cells[4].Value.ToString(), gvUpdates.SelectedRows[0].Cells[2].Value.ToString(), gvUpdates.SelectedRows[0].Cells["FileUploaded"].Value.ToString());
            frm.ShowDialog();

            DBlayer dba = new GIM.DBlayer();
            DataSet dsUpdates = dba.GetUpdates(IssueID);
            DataView dvUpdates = dsUpdates.Tables[0].DefaultView;
            gvUpdates.DataSource = dvUpdates;
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            AddIssue frm = new GIM.AddIssue(IssueID, UserID);
            frm.ShowDialog();
            LoadEditIssue();
        }

        private void btCloseIssue_Click(object sender, EventArgs e)
        {
            CloseIssue fci = new GIM.CloseIssue(IssueID, UserID);
            fci.ShowDialog();
            LoadEditIssue();
        }
    }
}
