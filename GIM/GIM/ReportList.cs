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
    public partial class ReportList : Form
    {
        public ReportList()
        {
            InitializeComponent();
        }

        private void ReportList_Load(object sender, EventArgs e)
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

            try
            {
                DateMonth = cbDate.Text.Split(' ')[1].ToString();
                int DateDay = Convert.ToInt32(cbDate.Text.Split(' ')[0]);
                DBlayer dba = new DBlayer();
                DataSet dsReport = dba.GetDailyReport(0, DateMonth, DateDay);
                DataView dvReport = dsReport.Tables[0].DefaultView;
                gvReports.DataSource = dvReport;
            }
            catch
            {

            }
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string DateMonth = cbDate.Text.Split(' ')[1].ToString();
                int DateDay = Convert.ToInt32(cbDate.Text.Split(' ')[0]);
                DBlayer dba = new GIM.DBlayer();
                DataSet dsReport = dba.GetDailyReport(0, DateMonth, DateDay);
                DataView dvReport = dsReport.Tables[0].DefaultView;
                gvReports.DataSource = dvReport;
            }
            catch
            {

            }
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
                worksheet.Name = "ReportList";

                for (int i = 1; i < gvReports.Columns.Count - 2; i++)
                {
                    worksheet.Cells[1, i] = gvReports.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < gvReports.Rows.Count; i++)
                {
                    for (int j = 0; j < gvReports.Columns.Count-3; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = gvReports.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            catch
            {

            }
        }
    }
}
