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
                    dba.InsertDailyReport(UserID, tbReportText.Text.Replace("'", "''"), tbReportStat.Text.Replace("'", "''"), DateMonth, DateDay);
                }
                else
                {
                    dba.UpdateDailyReport(UserID, tbReportText.Text.Replace("'", "''"), tbReportStat.Text.Replace("'", "''"), DateMonth, DateDay);
                }

                MessageBox.Show("You have successfully submitted a daily report!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            catch
            {

            }
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DateMonth = cbDate.Text.Split(' ')[1].ToString();
            int DateDay = Convert.ToInt32(cbDate.Text.Split(' ')[0]);
            DBlayer dba = new GIM.DBlayer();
            DataSet dsReport = dba.GetDailyReport(UserID, DateMonth, DateDay);

            try
            {
                tbReportText.Text = dsReport.Tables[0].Rows[0]["ReportText"].ToString();
                tbReportStat.Text = dsReport.Tables[0].Rows[0]["ReportStats"].ToString();
            }
            catch
            {
                tbReportText.Text = "";
                tbReportStat.Text = "";
            }
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
    }
}
