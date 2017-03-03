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

        public DataSet GetIssues()
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "";

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
            string ImpactedVenues, string DateOccurence, string DateActualEnd, string DateUpdated, int Reportable, int Dashboard, string Creator)
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
                          " ,[ImpactedFunctions]" +
                          " ,[Location]" +
                          " ,[ImpactedVenues]" +
                          " ,[DateOccurence]" +
                          " ,[DateActualEnd]" +
                          " ,[DateUpdated]" +
                          " ,[Reportable]" +
                          " ,[Dashboard]" +
                          " ,[Creator])" +
                          "  VALUES " +
                          " (" + Type +
                          ",'" + Title +
                          "'," + IssueStatus +
                          " ," + IssueSeverity +
                          " ," + RaisedBy +
                          ",'" + Desc +
                          "'," + LeadFunction +
                          ",'" + ImpactedFuncs +
                          "'," + Location +
                          ",'" + ImpactedVenues +
                          "','" + DateOccurence +
                          "','" + DateActualEnd +
                          "','" + DateUpdated +
                          "'," + Reportable +
                          " ," + Dashboard +
                          " ," + Creator + ")";

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
