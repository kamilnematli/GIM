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
                DateOccurence = DateOccurence + " " + cbHour.Text + ":" + cbMins.Text;

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

        }

        private void AddLog_Load(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            DataSet dsFuncs = dba.GetTable("GIMfunc", 0);
            DataView dvFuncs = new DataView(dsFuncs.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            clbImpactedFuncs.DataSource = dvFuncs;
            clbImpactedFuncs.DisplayMember = "FuncCode";
            clbImpactedFuncs.ValueMember = "ID";

            cbLeadFunc.DataSource = dvFuncs;
            cbLeadFunc.DisplayMember = "FuncCode";
            cbLeadFunc.ValueMember = "ID";

            DataSet dsLead = dba.GetTable("GIMvenue", 0);
            DataView dvLead = new DataView(dsLead.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            clbImpactedVenues.DataSource = dvLead;
            clbImpactedVenues.DisplayMember = "VenueCode";
            clbImpactedVenues.ValueMember = "ID";

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
