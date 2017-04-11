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
        private int IssueID;
        private int FuncID;

        public AddIssue(int _issueid, int _funcid)
        {
            InitializeComponent();
            IssueID = _issueid;
            FuncID = _funcid;
        }

        private void AddIssue_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

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

            DataSet dsFuncs = dba.GetTable("GIMfunc", 0);
            DataView dvFuncs = new DataView(dsFuncs.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            clbImpactedFuncs.DataSource = dvFuncs;
            clbImpactedFuncs.DisplayMember = "FuncCode";
            clbImpactedFuncs.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMfunc", 0);
            DataView dvLead = new DataView(dsLead.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            cbLeadFunc.DataSource = dvLead;
            cbLeadFunc.DisplayMember = "FuncCode";
            cbLeadFunc.ValueMember = "ID";

            DataSet dsVenues = dba.GetTable("GIMvenue", 0);
            DataView dvVenues = new DataView(dsVenues.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            clbImpactedVenues.DataSource = dvVenues;
            clbImpactedVenues.DisplayMember = "VenueCode";
            clbImpactedVenues.ValueMember = "ID";

            DataSet dsLocation = dba.GetTable("GIMvenue", 0);
            DataRow rCT = dsLocation.Tables[0].NewRow();
            rCT["ID"] = 0;
            rCT["VenueCode"] = "";
            dsLocation.Tables[0].Rows.Add(rCT);
            DataView dvLocation = new DataView(dsLocation.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            cbLocation.DataSource = dvLocation;
            cbLocation.DisplayMember = "VenueCode";
            cbLocation.ValueMember = "ID";

            if(IssueID > 0)
            {
                this.Text = "Edit Issue";
                groupBox1.Text = "Edit";

                DataSet dsIssue = dba.GetTable("GIMissue", IssueID);
                tbTitle.Text = dsIssue.Tables[0].Rows[0]["Title"].ToString();
                tbDesc.Text = dsIssue.Tables[0].Rows[0]["Description"].ToString();
                cbLocation.SelectedValue = dsIssue.Tables[0].Rows[0]["Location"];
                cbSeverity.SelectedValue = dsIssue.Tables[0].Rows[0]["IssueSeverity"];
                cbStatus.SelectedValue = dsIssue.Tables[0].Rows[0]["IssueStatus"];
                tbLocationDesc.Text = dsIssue.Tables[0].Rows[0]["LocationDesc"].ToString();
                cbLeadFunc.SelectedValue = dsIssue.Tables[0].Rows[0]["LeadFunction"];
                tbAttachment.Text = dsIssue.Tables[0].Rows[0]["Attachment"].ToString();
                if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Dashboard"]) == 1) chDashboard.Checked = true;
                if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Reportable"]) == 1) chReportable.Checked = true;

                DateTime dtOcc = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateOccurence"].ToString());
                dtOccurence.Value = dtOcc.Date;
                cbHour.Text = dtOcc.Hour.ToString();
                cbMins.Text = dtOcc.Minute.ToString();

                DataSet impFuncs = dba.GetIssueImpcFuncs(IssueID);

                int i = 0, j = 0;

                for ( ; i < clbImpactedFuncs.Items.Count; i++)
                {
                    for (j = 0; j < impFuncs.Tables[0].Rows.Count; j++)
                    {
                        if (((System.Data.DataRowView)(clbImpactedFuncs.Items[i])).Row.ItemArray[0].ToString() == impFuncs.Tables[0].Rows[j]["ID"].ToString())
                        {
                            clbImpactedFuncs.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }

                DataSet impVenues = dba.GetIssueImpcVenues(IssueID);
                for (i = 0; i < clbImpactedVenues.Items.Count; i++)
                {
                    for (j = 0; j < impVenues.Tables[0].Rows.Count; j++)
                    {
                        if (((System.Data.DataRowView)(clbImpactedVenues.Items[i])).Row.ItemArray[0].ToString() == impVenues.Tables[0].Rows[j]["VenueID"].ToString())
                        {
                            clbImpactedVenues.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                }
            }
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
            string DateOccurence = "";

            if (IssueID == 0)
            {
                foreach (object itemChecked in clbImpactedFuncs.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    ImpactedFuncs += castedItem["ID"].ToString() + ",";
                }

                foreach (object itemChecked in clbImpactedVenues.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    ImpactedVenues += castedItem["ID"].ToString() + ",";
                }
                ImpactedVenues += Convert.ToInt32(cbLocation.SelectedValue) + ",";

                DateOccurence = dtOccurence.Value.ToString("yyyy-MM-dd");
                if (cbHour.Text != "" || cbMins.Text != "")
                {
                    DateOccurence = DateOccurence + " " + cbHour.Text + ":" + cbMins.Text;
                }

                int Dashboard = 0;
                int Reportable = 0;
                if (chReportable.Checked) Reportable = 1;
                if (chDashboard.Checked) Dashboard = 1;

                try
                {
                    dba.InsertIssue(1, tbTitle.Text.Replace("'", "''"), Convert.ToInt32(cbStatus.SelectedValue), Convert.ToInt32(cbSeverity.SelectedValue), FuncID, tbDesc.Text.Replace("'", "''"), Convert.ToInt32(cbLeadFunc.SelectedValue),
                        ImpactedFuncs, Convert.ToInt32(cbLocation.SelectedValue), ImpactedVenues, DateOccurence, "", "", Reportable, Dashboard, Environment.UserName.Replace("'", "''"), tbAttachment.Text, tbLocationDesc.Text.Replace("'", "''"));

                    MessageBox.Show("You have successfully created an issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please check the data that you have inserted, if everything seems ok please check your network connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (IssueID > 0)
            {
                foreach (object itemChecked in clbImpactedFuncs.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    ImpactedFuncs += castedItem["ID"].ToString() + ",";
                }

                foreach (object itemChecked in clbImpactedVenues.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    ImpactedVenues += castedItem["ID"].ToString() + ",";
                }
                ImpactedVenues += Convert.ToInt32(cbLocation.SelectedValue) + ",";

                DateOccurence = dtOccurence.Value.ToString("yyyy-MM-dd");
                if (cbHour.Text != "" || cbMins.Text != "")
                {
                    DateOccurence = DateOccurence + " " + cbHour.Text + ":" + cbMins.Text;
                }

                string DateActualEnd = "";
                DateActualEnd = dtActualEnd.Value.ToString("yyyy-MM-dd");

                if (cbHour3.Text != "" || cbMin3.Text != "")
                {
                    DateActualEnd = DateActualEnd + " " + cbHour3.Text + ":" + cbMin3.Text;
                }

                int Dashboard = 0;
                int Reportable = 0;
                if (chReportable.Checked) Reportable = 1;
                if (chDashboard.Checked) Dashboard = 1;

                try
                {
                    dba.UpdateIssueDetails(IssueID, 1, tbTitle.Text.Replace("'", "''"), Convert.ToInt32(cbStatus.SelectedValue), Convert.ToInt32(cbSeverity.SelectedValue), FuncID, tbDesc.Text.Replace("'", "''"), Convert.ToInt32(cbLeadFunc.SelectedValue),
                        ImpactedFuncs, Convert.ToInt32(cbLocation.SelectedValue), ImpactedVenues, DateOccurence, tbAttachment.Text, tbLocationDesc.Text.Replace("'", "''"), Dashboard, Reportable, DateActualEnd);

                    MessageBox.Show("You have successfully updated the issue!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please check the data that you have inserted, if everything seems ok please check your network connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            tbAttachment.Text = ofd.FileName;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStatus.Text == "Closed")
            {
                dtActualEnd.Enabled = true;
                cbHour3.Enabled = true;
                cbMin3.Enabled = true;
            }
            else
            {
                dtActualEnd.Enabled = false;
                cbHour3.Enabled = false;
                cbMin3.Enabled = false;
            }
        }
    }
}
