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
    public partial class DailyReport : Form
    {
        private int UserID;

        public DailyReport(int _userid)
        {
            InitializeComponent();
            UserID = _userid;
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            string DateMonth = "";
            switch (DateTime.Now.Month)
            {
                case 4:
                    DateMonth = "April";
                    break;
                case 5:
                    DateMonth = "May";
                    break;
                default:
                    break;
            }
            cbDate.Text = DateTime.Now.Day + " " + DateMonth;
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DateMonth = cbDate.Text.Split(' ')[1].ToString();
            int DateDay = Convert.ToInt32(cbDate.Text.Split(' ')[0]);
            DBlayer dba = new GIM.DBlayer();
            
            try
            {
                DataSet dsReport = dba.GetDailyReport(UserID, DateMonth, DateDay);
                tbReportText.Text = dsReport.Tables[0].Rows[0]["ReportText"].ToString();
                tbReportStat.Text = dsReport.Tables[0].Rows[0]["ReportStats"].ToString();

                if (Convert.ToInt32(dsReport.Tables[0].Rows[0]["Finished"]) == 1)
                {
                    tbReportStat.ReadOnly = true;
                    tbReportText.ReadOnly = true;
                }
                else
                {
                    tbReportStat.ReadOnly = false;
                    tbReportText.ReadOnly = false;
                }
            }
            catch
            {
                tbReportText.Text = "";
                tbReportStat.Text = "";
                tbReportStat.ReadOnly = false;
                tbReportText.ReadOnly = false;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            string DateMonth = cbDate.Text.Split(' ')[1].ToString();
            int DateDay = Convert.ToInt32(cbDate.Text.Split(' ')[0]);
            DataSet dsReport = dba.GetDailyReport(UserID, DateMonth, DateDay);
            try
            {
                if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
                {
                    dba.InsertDailyReport(UserID, tbReportText.Text.Replace("'", "''"), tbReportStat.Text.Replace("'", "''"), DateMonth, DateDay, 0);
                }
                else
                {
                    dba.UpdateDailyReport(UserID, tbReportText.Text.Replace("'", "''"), tbReportStat.Text.Replace("'", "''"), DateMonth, DateDay, 0);
                }
            }
            catch
            {

            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            DBlayer dba = new GIM.DBlayer();

            string DateMonth = cbDate.Text.Split(' ')[1].ToString();
            int DateDay = Convert.ToInt32(cbDate.Text.Split(' ')[0]);
            DataSet dsReport = dba.GetDailyReport(UserID, DateMonth, DateDay);
            try
            {
                DialogResult dResult = MessageBox.Show("Daily report is complete and I want to submit it!", "Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dResult == DialogResult.Yes)
                {
                    if (dsReport.Tables.Count == 0 || dsReport.Tables[0].Rows.Count == 0)
                    {
                        dba.InsertDailyReport(UserID, tbReportText.Text.Replace("'", "''"), tbReportStat.Text.Replace("'", "''"), DateMonth, DateDay, 1);
                    }
                    else
                    {
                        dba.UpdateDailyReport(UserID, tbReportText.Text.Replace("'", "''"), tbReportStat.Text.Replace("'", "''"), DateMonth, DateDay, 1);
                    }

                    this.Close();
                }
            }
            catch
            {

            }
        }
    }
}
