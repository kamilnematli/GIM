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

                DateOccurence = dtOccurence.Value.ToString("yyyy-MM-dd");
                if (cbHour.Text != "" && cbMins.Text != "")
                {
                    DateOccurence = DateOccurence + " " + cbHour.Text + ":" + cbMins.Text;
                }

                try
                {
                    dba.InsertIssue(2, tbTitle.Text, -1, -1, FuncID, tbDesc.Text, Convert.ToInt32(cbLeadFunc.SelectedValue),
                        ImpactedFuncs, Convert.ToInt32(cbLocation.SelectedValue), ImpactedVenues, DateOccurence, "", "", 0, 0, Environment.UserName, " ", tbLocationDesc.Text);

                    MessageBox.Show("You have successfully created a log!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                DateOccurence = dtOccurence.Value.ToString("yyyy-MM-dd");
                if (cbHour.Text != "" && cbMins.Text != "")
                {
                    DateOccurence = DateOccurence + " " + cbHour.Text + ":" + cbMins.Text;
                }

                int Reportable = 0;
                if (chReportable.Checked) Reportable = 1;

                try
                {
                    dba.UpdateIssueDetails(IssueID, 2, tbTitle.Text.Replace("'", "''"), -1, -1, FuncID, tbDesc.Text.Replace("'", "''"), Convert.ToInt32(cbLeadFunc.SelectedValue),
                        ImpactedFuncs, Convert.ToInt32(cbLocation.SelectedValue), ImpactedVenues, DateOccurence, "", tbLocationDesc.Text.Replace("'", "''"), 0, Reportable, "");

                    MessageBox.Show("You have successfully updated the log!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Something went wrong. Please check the data that you have inserted, if everything seems ok please check your network connection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AddLog_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

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

            if (FuncID != 1)
            {
                chReportable.Visible = false;
            }

            if (IssueID > 0)
            {
                this.Text = "Edit Log";
                groupBox1.Text = "Edit";

                DataSet dsIssue = dba.GetTable("GIMissue", IssueID);
                tbTitle.Text = dsIssue.Tables[0].Rows[0]["Title"].ToString();
                tbDesc.Text = dsIssue.Tables[0].Rows[0]["Description"].ToString();
                cbLocation.SelectedValue = dsIssue.Tables[0].Rows[0]["Location"];
                tbLocationDesc.Text = dsIssue.Tables[0].Rows[0]["LocationDesc"].ToString();
                cbLeadFunc.SelectedValue = dsIssue.Tables[0].Rows[0]["LeadFunction"];
                if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Reportable"]) == 1) chReportable.Checked = true;

                DateTime dtOcc = Convert.ToDateTime(dsIssue.Tables[0].Rows[0]["DateOccurence"].ToString());
                dtOccurence.Value = dtOcc.Date;
                cbHour.Text = dtOcc.Hour.ToString();
                cbMins.Text = dtOcc.Minute.ToString();

                DataSet impFuncs = dba.GetIssueImpcFuncs(IssueID);

                if (FuncID != 1)
                    if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["RaisedBy"]) != FuncID)
                        btSave.Enabled = false;

                int i = 0, j = 0;

                for (; i < clbImpactedFuncs.Items.Count; i++)
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

        private void chAllFuncs_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (chAllFuncs.Checked == true)
            {
                for (i = 0; i < clbImpactedFuncs.Items.Count; i++)
                {
                    clbImpactedFuncs.SetItemChecked(i, true);
                }
            }
            else
            {
                for (i = 0; i < clbImpactedFuncs.Items.Count; i++)
                {
                    clbImpactedFuncs.SetItemChecked(i, false);
                }
            }
        }

        private void chAllVenues_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
            if (chAllVenues.Checked == true)
            {
                for (i = 0; i < clbImpactedVenues.Items.Count; i++)
                {
                    clbImpactedVenues.SetItemChecked(i, true);
                }
            }
            else
            {
                for (i = 0; i < clbImpactedVenues.Items.Count; i++)
                {
                    clbImpactedVenues.SetItemChecked(i, false);
                }
            }
        }
    }
}
