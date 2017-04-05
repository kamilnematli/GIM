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

            DateTime dtOcc = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateOccurence"].ToString());
            dtOccurence.Value = dtOcc.Date;
            cbHour.Text = dtOcc.Hour.ToString();
            cbMins.Text = dtOcc.Minute.ToString();

            DateTime dtUpd = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateUpdated"].ToString());
            dtUpdated.Value = dtUpd.Date;
            cbHour2.Text = dtUpd.Hour.ToString();
            cbMin2.Text = dtUpd.Minute.ToString();

            if (dsIssue.Tables[0].Rows[0]["DateActualEnd"].ToString() != "")
            {
                DateTime dtActEnd = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateActualEnd"].ToString());
                dtActualEnd.Value = dtActEnd.Date;
                cbHour3.Text = dtActEnd.Hour.ToString();
                cbMin3.Text = dtActEnd.Minute.ToString();
            }

            if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Dashboard"]) == 1) chDashboard.Checked = true;
            if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Reportable"]) == 1) chReportable.Checked = true;

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

        private void tbEdit_Click(object sender, EventArgs e)
        {
            AddIssue frm = new GIM.AddIssue(IssueID, FuncID);
            frm.ShowDialog();
            LoadEditIssue();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DBlayer dba = new DBlayer();
            string DateActualEnd = "";
            DateActualEnd = dtActualEnd.Value.ToString("yyyy-MM-dd");

            if(cbHour3.Text == "" || cbMin3.Text == "")
            {
                DateActualEnd = DateActualEnd + " 00:01";
            }
            else
            {
                DateActualEnd = DateActualEnd + " " + cbHour3.Text + ":" + cbMin3.Text;
            }
            
            int Dashboard = 0;
            int Reportable = 0;
            if (chReportable.Checked) Reportable = 1;
            if (chDashboard.Checked) Dashboard = 1;

            try
            {
                dba.UpdateIssue(IssueID, Convert.ToInt32(cbStatus.SelectedValue), Dashboard, Reportable, DateActualEnd);

                MessageBox.Show("You have successfully updated the issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Something went wrong. Please check the data that you have inserted, if everything seems ok please check your network connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSubmitUpdate_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();
            dba.InsertUpdate(IssueID, FuncID, Environment.UserName, tbUpdate.Text, "", tbAttachment.Text);
            tbUpdate.Text = "";
            tbAttachment.Text = "";

            DataSet dsUpdates = dba.GetUpdates(IssueID);
            DataView dvUpdates = dsUpdates.Tables[0].DefaultView;
            gvUpdates.DataSource = dvUpdates;
        }

        private void gvUpdates_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IssueUpdate frm = new IssueUpdate(FuncID, Convert.ToInt32(gvUpdates.SelectedRows[0].Cells[0].Value), gvUpdates.SelectedRows[0].Cells["UpdatedBy"].Value.ToString(), 
                gvUpdates.SelectedRows[0].Cells[4].Value.ToString(), gvUpdates.SelectedRows[0].Cells[2].Value.ToString(), gvUpdates.SelectedRows[0].Cells["FileUploaded"].Value.ToString());
            frm.ShowDialog();

            DBlayer dba = new GIM.DBlayer();
            DataSet dsUpdates = dba.GetUpdates(IssueID);
            DataView dvUpdates = dsUpdates.Tables[0].DefaultView;
            gvUpdates.DataSource = dvUpdates;
        }
    }
}
