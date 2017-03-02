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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadIssueList();
        }

        private void LoadIssueList()
        {
            DBlayer dba = new DBlayer();
            DataSet dsIssues = dba.GetIssues();
            DataView dvIssues = dsIssues.Tables[0].DefaultView;
            gvIssues.DataSource = dvIssues;
        }

        private void AddIssue_Click(object sender, EventArgs e)
        {
            AddIssue frm = new AddIssue();
            frm.ShowDialog();
        }

        private void AddLog_Click(object sender, EventArgs e)
        {
            AddLog frm = new GIM.AddLog();
            frm.ShowDialog();
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
    }
}
