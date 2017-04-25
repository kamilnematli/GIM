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
            //lbUsername.Text = Environment.UserName;

            DBlayer dba = new DBlayer();
            try
            {
                DataSet dsFunc = dba.GetTable("GIMfunc", 0);
                DataView dvFunc = new DataView(dsFunc.Tables[0], "", "FuncCode", DataViewRowState.CurrentRows);
                clbImpactedFuncs.DataSource = dvFunc;
                clbImpactedFuncs.DisplayMember = "FuncCode";
                clbImpactedFuncs.ValueMember = "ID";

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
                DataView dvVenues = new DataView(dsVenues.Tables[0], "", "VenueCode", DataViewRowState.CurrentRows);
                clbImpactedVenues.DataSource = dvVenues;
                clbImpactedVenues.DisplayMember = "VenueCode";
                clbImpactedVenues.ValueMember = "ID";
            }
            catch
            {

            }

            LoadIssueList();

            Timer timer = new Timer();
            timer.Interval = (120 * 1000); // 120 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void LoadIssueList()
        {
            try
            {
                DBlayer dba = new DBlayer();
                DataSet dsIssues = new DataSet();
                string ImpactedFuncs = "";
                string ImpactedVenues = "";

                foreach (object itemChecked in clbImpactedFuncs.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    ImpactedFuncs += castedItem["ID"].ToString() + ",";
                }
                if (ImpactedFuncs != "") ImpactedFuncs = ImpactedFuncs.Substring(0, ImpactedFuncs.Length - 1);

                foreach (object itemChecked in clbImpactedVenues.CheckedItems)
                {
                    DataRowView castedItem = itemChecked as DataRowView;
                    ImpactedVenues += castedItem["ID"].ToString() + ",";
                }
                if (ImpactedVenues != "") ImpactedVenues = ImpactedVenues.Substring(0, ImpactedVenues.Length - 1);

                try
                {
                    dsIssues = dba.GetIssues(UserID, UserType, chIssue.Checked, chLog.Checked, chLow.Checked, chMedium.Checked, chHigh.Checked, chNew.Checked, chInprogress.Checked, chClosed.Checked,
                        chDashboard.Checked, chReportable.Checked, chMyList.Checked, ImpactedFuncs, ImpactedVenues, Convert.ToInt32(cbLead.SelectedValue));
                }
                catch
                {
                    dsIssues = dba.GetIssues(UserID, UserType, chIssue.Checked, chLog.Checked, chLow.Checked, chMedium.Checked, chHigh.Checked, chNew.Checked, chInprogress.Checked, chClosed.Checked,
                        chDashboard.Checked, chReportable.Checked, chMyList.Checked, "", "", -1);
                }

                DataView dvIssues = dsIssues.Tables[0].DefaultView;
                gvIssues.DataSource = dvIssues;
            }
            catch
            {

            }
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

        private void gvIssues_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvIssues.SelectedRows[0].Cells[2].Value.ToString() == "Issue")
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

        private void btOpenIssue_Click(object sender, EventArgs e)
        {
            DBlayer dba = new DBlayer();          

            try
            {
                DataSet dsIssue = dba.GetTable("GIMissue", Convert.ToInt32(tbIssueID.Text));
                if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Type"]) == 1)
                {
                    EditIssue frm = new GIM.EditIssue(Convert.ToInt32(tbIssueID.Text), UserID);
                    frm.Show();
                }
                else if (Convert.ToInt32(dsIssue.Tables[0].Rows[0]["Type"]) == 2)
                {
                    AddLog fal = new AddLog(Convert.ToInt32(tbIssueID.Text), UserID);
                    fal.ShowDialog();
                }
            }
            catch { }        
        }

        private void gvIssues_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
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
            catch { }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePass fcp = new ChangePass(UserID);
            fcp.ShowDialog();
        }

        private void lbDailyReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(UserID == 1)
            {
                ReportList rList = new GIM.ReportList();
                rList.ShowDialog();
            }
            else
            {
                DailyReport fdr = new GIM.DailyReport(UserID);
                fdr.ShowDialog();
            }        
        }

        private void btApplyFilter_Click_1(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void btClearFilter_Click(object sender, EventArgs e)
        {
            chMyList.Checked = false;
            cbLead.Text = "";
            chIssue.Checked = false;
            chLog.Checked = false;
            chLow.Checked = false;
            chMedium.Checked = false;
            chHigh.Checked = false;
            chNew.Checked = false;
            chInprogress.Checked = false;
            chClosed.Checked = false;
            chDashboard.Checked = false;
            chReportable.Checked = false;

            int i = 0;
            for (i = 0; i < clbImpactedFuncs.Items.Count; i++)
            {
                clbImpactedFuncs.SetItemChecked(i, false);
            }

            for (i = 0; i < clbImpactedVenues.Items.Count; i++)
            {
                clbImpactedVenues.SetItemChecked(i, false);
            }
        }

        private void gvIssues_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (gvIssues.Rows.Count > 0)
            {
                gvIssues.Rows[0].Selected = false;
            }
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form fc = Application.OpenForms["SignIn"];
            fc.Visible = true;
        }
    }
}
