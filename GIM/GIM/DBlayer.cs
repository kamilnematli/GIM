using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIM
{
    class DBlayer
    {
        string connectionString = "server=pmsasql01.database.windows.net;database=GamesModelDB02;uid=SQLAdmin01;pwd=UD6JvqIY9iLlX57PT3U1";

        public bool CheckPassword(int FuncID, string pass)
        {
            if (FuncID < 1) return false;

            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "select UserPass from GIMfunc where ID = " + FuncID;

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();

            if(ds.Tables[0].Rows[0]["UserPass"].ToString() == pass)
            {
                return true;
            }

            return false;
        }

        public bool IsServerConnected()
        {
            using (var l_oConnection = new SqlConnection(connectionString))
            {
                try
                {
                    l_oConnection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        #region Get data

        public DataSet GetIssues(bool _Issues, bool _Logs, bool _Low, bool _Medium, bool _High, bool _New, bool _InProgress, bool _OnHold, bool _Closed, bool _Dashboard, bool _Reportable)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = " Select dbo.GIMissue.[ID], [DateUpdated], case when [Type] = 1 then 'Issue' when [Type] = 2 then 'Log' end as [Type], dbo.GIMStatus.StatusName as [Status], " +
                   " dbo.GIMseverity.SeverityName as [Severity], [Title], dbo.GIMfunc.FuncCode as [Lead function], case when [Reportable] = 1 then 'Yes' else 'No' end as [Reportable], " +
                   " case when [Dashboard] = 1 then 'Yes' else 'No' end as [Dashboard] " +
                    " FROM dbo.GIMissue LEFT OUTER JOIN " +
                    " dbo.GIMseverity ON dbo.GIMissue.IssueSeverity = dbo.GIMseverity.ID LEFT OUTER JOIN " +
                    " dbo.GIMStatus ON dbo.GIMissue.IssueStatus = dbo.GIMstatus.ID LEFT OUTER JOIN " +
                    " dbo.GIMfunc ON dbo.GIMissue.LeadFunction = dbo.GIMfunc.ID";

            string filt = "";

            if (_Issues == true && _Logs == false) filt += "Type = 1 ";
            if (_Issues == false && _Logs == true) filt += "Type = 2 ";

            if (_Dashboard == true) filt += "and Dashboard = 1 ";
            if (_Reportable == true) filt += "and Reportable = 1 ";

            string FiltSev = "";
            if (_Low == true) FiltSev += "IssueSeverity = 1 ";
            if (_Medium == true) FiltSev += "or IssueSeverity = 2 ";
            if (_High == true) FiltSev += "or IssueSeverity = 3 ";

            if (FiltSev != "" && FiltSev.Substring(0, 2) == "or") FiltSev = FiltSev.Substring(2);
            FiltSev = "(" + FiltSev + ")";

            string FiltStatus = "";
            if (_New == true) FiltStatus += "IssueStatus = 1 ";
            if (_InProgress == true) FiltStatus += "or IssueStatus = 2 ";
            if (_OnHold == true) FiltStatus += "or IssueStatus = 3 ";
            if (_Closed == true) FiltStatus += "or IssueStatus = 4 ";

            if (FiltStatus != "" && FiltStatus.Substring(0, 2) == "or") FiltStatus = FiltStatus.Substring(2);
            FiltStatus = "(" + FiltStatus + ")";

            if (FiltSev != "()") filt += filt + "and " + FiltSev;
            if (FiltStatus != "()") filt += filt + "and " + FiltStatus;

            if (filt != "" && filt.Substring(0, 4).Contains("and")) filt = filt.Substring(4);

            if (filt != "") _sql += " where " + filt;

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetTable(string TableName)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "Select * from " + TableName;

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        #endregion

        #region Insert data

        public void InsertIssue(int Type, string Title, int IssueStatus, int IssueSeverity, int RaisedBy, string Desc, int LeadFunction, string ImpactedFuncs, int Location,
            string ImpactedVenues, string DateOccurence, string DateActualEnd, string DateUpdated, int Reportable, int Dashboard, string Creator, string Attch, string LocDesc)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " INSERT INTO [dbo].[GIMissue] " +
                          " ([Type]" +
                          " ,[Title]" +
                          " ,[IssueStatus]" +
                          " ,[IssueSeverity]" +
                          " ,[RaisedBy]" +
                          " ,[Description]" +
                          " ,[LeadFunction]" +
                          " ,[Location]" +
                          " ,[DateOccurence]" +
                          " ,[DateActualEnd]" +
                          " ,[DateUpdated]" +
                          " ,[Reportable]" +
                          " ,[Dashboard]" +
                          " ,[Creator]" + 
                          " ,[Attachment]" +
                          " ,[LocationDesc])" +
                          "  VALUES " +
                          " (" + Type +
                          ",'" + Title +
                          "'," + IssueStatus +
                          " ," + IssueSeverity +
                          " ," + RaisedBy +
                          ",'" + Desc +
                          "'," + LeadFunction +
                          "," + Location +
                          ",CONVERT(datetime,'" + DateOccurence +
                          "'), null" +
                          ",'" + DateTime.Now +
                          "'," + Reportable +
                          " ," + Dashboard +
                          " ,'" + Creator + 
                          "','" + Attch + 
                          "','" + LocDesc + "')";

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();

            string[] funcs = ImpactedFuncs.Split(',');
            string[] venues = ImpactedVenues.Split(',');

            _sql = " Declare @lRow as int; " +
                   " set @lRow = dbo.GetIssueLastRow(); ";

            int i = 0;
            for ( ; i < funcs.Length - 1; i++)
            {
                _sql += " INSERT INTO [dbo].[GIMimpactedFuncs] ([Issue], [Func]) VALUES (@lRow, " + funcs[i] + "); ";
            }

            for (i = 0; i < venues.Length - 1; i++)
            {
                _sql += " INSERT INTO [dbo].[GIMimpactedVenues] ([Issue], [Venue]) VALUES (@lRow, " + venues[i] + "); ";
            }

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void InsertUpdate(int UpdatedBy, string Creator, string UpdateText, string UpdateType, string DateUpdate, string FileUploaded)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = "INSERT INTO [dbo].[GIMupdateLog] " +
                          " ([UpdatedBy]" +
                          " ,[Creator]" +
                          " ,[UpdateContext]" +
                          " ,[UpdateType]" +
                          " ,[DateUpdate]" +
                          " ,[FileUploaded])" +
                          " VALUES" +
                          " (" + UpdatedBy +
                          ",'" + Creator +
                          "','" + UpdateText +
                          "','" + UpdateType +
                          "','" + DateUpdate + 
                          "','" + FileUploaded + "')";

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        #endregion

        #region Update data

        #endregion

        #region Delete data

        #endregion
    }
}
