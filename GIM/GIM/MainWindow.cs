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
    public partial class MainWindow : Form
    {
        private int UserID;
        private int UserType;

        public MainWindow(int _id, int _usertype)
        {
            InitializeComponent();
            UserID = _id;
            UserType = _usertype;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            lbUsername.Text = Environment.UserName;
            DBlayer dba = new DBlayer();

            DataSet dsFunc = dba.GetTable("GIMfunc", 0);
            DataRow rFunc = dsFunc.Tables[0].NewRow();
            rFunc["ID"] = 0;
            rFunc["FuncCode"] = "";
            dsFunc.Tables[0].Rows.Add(rFunc);
            DataView dvFunc = new DataView(dsFunc.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            cbFunc.DataSource = dvFunc;
            cbFunc.DisplayMember = "FuncCode";
            cbFunc.ValueMember = "ID";
            //cbFunc.SelectedValue = 0;

            DataSet dsLead = dba.GetTable("GIMfunc", 0);
            DataRow rLead = dsLead.Tables[0].NewRow();
            rLead["ID"] = 0;
            rLead["FuncCode"] = "";
            dsLead.Tables[0].Rows.Add(rLead);
            DataView dvLead = new DataView(dsLead.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
            cbLead.DataSource = dvLead;
            cbLead.DisplayMember = "FuncCode";
            cbLead.ValueMember = "ID";

            DataSet dsVenues = dba.GetTable("GIMvenue", 0);
            DataRow rVenue = dsVenues.Tables[0].NewRow();
            rVenue["ID"] = 0;
            rVenue["VenueCode"] = "";
            dsVenues.Tables[0].Rows.Add(rVenue);
            DataView dvVenues = new DataView(dsVenues.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
            cbVenue.DataSource = dvVenues;
            cbVenue.DisplayMember = "VenueCode";
            cbVenue.ValueMember = "ID";
            //cbVenue.SelectedValue = 0;

            LoadIssueList();
        }

        private void LoadIssueList()
        {
            DBlayer dba = new DBlayer();
            DataSet dsIssues = new DataSet();

            try
            {
                dsIssues = dba.GetIssues(UserID, UserType, chIssue.Checked, chLog.Checked, chLow.Checked, chMedium.Checked, chHigh.Checked, chNew.Checked, chInprogress.Checked, chClosed.Checked, 
                    chDashboard.Checked, chReportable.Checked, chMyList.Checked, chAll.Checked, Convert.ToInt32(cbFunc.SelectedValue), Convert.ToInt32(cbVenue.SelectedValue), Convert.ToInt32(cbLead.SelectedValue));
            }
            catch
            {
                dsIssues = dba.GetIssues(UserID, UserType, chIssue.Checked, chLog.Checked, chLow.Checked, chMedium.Checked, chHigh.Checked, chNew.Checked, chInprogress.Checked, chClosed.Checked, 
                    chDashboard.Checked, chReportable.Checked, chMyList.Checked, chAll.Checked, -1, -1, -1);
            }

            DataView dvIssues = dsIssues.Tables[0].DefaultView;
            gvIssues.DataSource = dvIssues;
        }

        private void AddIssue_Click(object sender, EventArgs e)
        {
            AddIssue frm = new AddIssue(0, UserID);
            frm.ShowDialog();
            LoadIssueList();
        }

        private void AddLog_Click(object sender, EventArgs e)
        {
            AddLog frm = new GIM.AddLog(0, UserID);
            frm.ShowDialog();
            LoadIssueList();
        }

        private void btExport_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Issues";

                for (int i = 1; i < gvIssues.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = gvIssues.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < gvIssues.Rows.Count; i++)
                {
                    for (int j = 0; j < gvIssues.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = gvIssues.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch
            {

            }
        }

        private void chIssue_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chLog_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chLow_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chMedium_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chHigh_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chNew_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chInprogress_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chClosed_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chDashboard_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chReportable_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void gvIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvIssues.SelectedRows[0].Cells[2].Value == "Issue")
            {
                EditIssue frm = new GIM.EditIssue(Convert.ToInt32(gvIssues.SelectedRows[0].Cells[0].Value), UserID);
                frm.Show();
            }
            else
            {
                AddLog lfrm = new AddLog(Convert.ToInt32(gvIssues.SelectedRows[0].Cells[0].Value), UserID);
                lfrm.ShowDialog();
            }
        }

        private void chMyList_CheckedChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void chAll_CheckedChanged(object sender, EventArgs e)
        {
            if(chAll.Checked)
            {
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
            }
            else
            {
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
            }

            LoadIssueList();
        }

        private void cbFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void cbVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void cbLead_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void btOpenIssue_Click(object sender, EventArgs e)
        {
            EditIssue frm = new GIM.EditIssue(Convert.ToInt32(tbIssueID.Text), UserID);
            frm.Show();
        }

        private void gvIssues_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.gvIssues.Columns[e.ColumnIndex].Name == "Severity")
            {
                if (e.Value.ToString() == "High")
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (e.Value.ToString() == "Medium")
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                else if (e.Value.ToString() == "Low")
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadIssueList();
        }
    }
}
