﻿using System;
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

        public bool CheckPassword(int UserID, string pass)
        {
            if (UserID < 1) return false;

            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "select UserPass from GIMusers where ID = " + UserID;

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

        public DataSet GetIssues(int UserID, int UserType, bool _Issues, bool _Logs, bool _Low, bool _Medium, bool _High, bool _New, bool _InProgress, bool _Closed, bool _Dashboard, bool _Reportable, 
            bool _MyList, string ImpFunc, string ImpVenue, int LeadFunc)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = " Select dbo.GIMissue.[ID], [DateUpdated], case when [Type] = 1 then 'Issue' when [Type] = 2 then 'Log' end as [Type], dbo.GIMStatus.StatusName as [Status], " +
                   " dbo.GIMseverity.SeverityName as [Severity], [Title], dbo.GIMfunc.FuncCode as [Lead function], case when [Reportable] = 1 then 'Yes' else 'No' end as [Reportable], " +
                   " case when [Dashboard] = 1 then 'Yes' else 'No' end as [Dashboard], dbo.GIMissue.[Description] " +
                    " FROM dbo.GIMissue LEFT OUTER JOIN " +
                    " dbo.GIMseverity ON dbo.GIMissue.IssueSeverity = dbo.GIMseverity.ID LEFT OUTER JOIN " +
                    " dbo.GIMStatus ON dbo.GIMissue.IssueStatus = dbo.GIMstatus.ID LEFT OUTER JOIN " +
                    " dbo.GIMfunc ON dbo.GIMissue.LeadFunction = dbo.GIMfunc.ID";

            string filt = "";

            if (_Issues == true && _Logs == false) filt += "Type = 1 ";
            if (_Issues == false && _Logs == true) filt += "Type = 2 ";

            if (_MyList)
            {
                filt += "and dbo.GIMissue.RaisedBy = " + UserID + " ";
            }
            //else
            //{
            //    if (UserType == 1)
            //    {
            //        filt += "and (dbo.GIMissue.LeadFunction = " + UserID + " OR dbo.GIMissue.[ID] in (SELECT [Issue] FROM [dbo].[GIMimpactedFuncs] where [Func] = " + UserID + ")) ";
            //    }
            //    else if (UserType == 2)
            //    {
            //        filt += "and dbo.GIMissue.[ID] in (SELECT [Issue] FROM [dbo].[GIMimpactedVenues] where [Venue] = " + UserID + ")";
            //    }
            //}

            if (ImpVenue != "")
            {
                filt += "and dbo.GIMissue.[ID] in (SELECT [Issue] FROM [dbo].[GIMimpactedVenues] where [Venue] IN (" + ImpVenue + ")) ";
            }

            if (ImpFunc != "")
            {
                filt += "and dbo.GIMissue.[ID] in (SELECT [Issue] FROM [dbo].[GIMimpactedFuncs] where [Func] IN (" + ImpFunc + ")) ";
            }

            if (LeadFunc > 0)
            {
                filt += "and dbo.GIMissue.LeadFunction = " + LeadFunc + " ";
            }

            if (_Dashboard == true) filt += "and Dashboard = 1 ";
            if (_Reportable == true) filt += "and Reportable = 1 ";

            string FiltSev = "";
            if (_Low == true) FiltSev += "IssueSeverity = 1 ";
            if (_Medium == true) FiltSev += "or IssueSeverity = 2 ";
            if (_High == true) FiltSev += "or IssueSeverity = 3 ";

            if (FiltSev != "" && FiltSev.Substring(0, 2) == "or")
            {
                FiltSev = FiltSev.Substring(2);
                FiltSev = "(" + FiltSev + " or IssueSeverity is null)";
            }
            else if (FiltSev != "" && FiltSev.Substring(0, 2) != "or")
            {
                FiltSev = "(" + FiltSev + " or IssueSeverity is null)";
            }

            string FiltStatus = "";
            if (_New == true) FiltStatus += "IssueStatus = 1 ";
            if (_InProgress == true) FiltStatus += "or IssueStatus = 2 ";
            if (_Closed == true) FiltStatus += "or IssueStatus = 4 ";

            if (FiltStatus != "" && FiltStatus.Substring(0, 2) == "or")
            {
                FiltStatus = FiltStatus.Substring(2);
                FiltStatus = "(" + FiltStatus + " or IssueStatus is null)";
            }
            else if (FiltStatus != "" && FiltStatus.Substring(0, 2) != "or")
            {
                FiltStatus = "(" + FiltStatus + " or IssueStatus is null)";
            }

            if (FiltSev != "") filt += " and " + FiltSev;
            if (FiltStatus != "") filt += " and " + FiltStatus;

            if (filt != "" && filt.Substring(0, 4).Contains("and")) filt = filt.Substring(4);

            if (filt != "") _sql += " where " + filt;

            _sql += " order by DateUpdated desc";

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetTable(string TableName, int _id)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "Select * from " + TableName;

            if (_id > 0)
            {
                _sql += " where [ID] = " + _id; 
            }

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetStatus(int _id)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "Select * from dbo.GIMstatus";

            if (_id > 0)
            {
                _sql += " where [ID] = " + _id;
            }
            else
            {
                _sql += " where [ID] < 4 ";
            }

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetUsers(int _userid)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = " SELECT * FROM [dbo].[GIMusers]";

            if(_userid > 0)
            {
                _sql += " where [dbo].[GIMusers].[ID] = " + _userid;
            }

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetDailyReport(int _userid, string DateMonth, int DateDay)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = " select [dbo].[GIMdailyReport].ID, [dbo].[GIMdailyReport].ReportText, [dbo].[GIMdailyReport].ReportStats, case when UserType = 1 then 'Function' else 'Venue' end as [UserType], " +
                   " Ucode, case when Finished = 1 then 'Yes' else 'No' end as [Finished], UserID, DateMonth, DateDay" +
                   " from gimdailyreport inner join gimusers on gimdailyreport.userid = gimusers.id " +
                   " WHERE [dbo].[GIMdailyReport].[DateMonth] = '" + DateMonth + "' and [dbo].[GIMdailyReport].[DateDay] = " + DateDay;

            if (_userid > 0)
            {
                _sql += " AND [dbo].[GIMdailyReport].[UserID] = " + _userid;
            }

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetIssueImpcFuncs(int _id)
        {
            string _sql = "";
            DataSet ds = new DataSet();
            
            _sql = " SELECT dbo.GIMfunc.[ID], [FuncCode], [FuncName] " +
                   " FROM [dbo].[GIMimpactedFuncs] inner join dbo.GIMfunc ON dbo.GIMimpactedFuncs.Func = dbo.GIMfunc.ID";

            if (_id > 0)
            {
                _sql += " where [dbo].[GIMimpactedFuncs].[Issue] = " + _id;
            }

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetIssueImpcVenues(int _id)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = "SELECT dbo.GIMimpactedVenues.[ID], [Issue], dbo.GIMimpactedVenues.Venue as VenueID, dbo.GIMvenue.VenueCode FROM [dbo].[GIMimpactedVenues] inner join dbo.GIMvenue ON dbo.GIMimpactedVenues.Venue = dbo.GIMvenue.ID";

            if (_id > 0)
            {
                _sql += " where [Issue] = " + _id;
            }

            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(_sql, conn);
            adapter.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet GetUpdates(int IssueID)
        {
            string _sql = "";
            DataSet ds = new DataSet();

            _sql = " SELECT dbo.GIMupdateLog.ID, dbo.GIMusers.Ucode + ' (' + dbo.GIMupdateLog.Creator + ')' as UpdatedBy, " +
                   " UpdateContext, UpdateType, DateUpdate, FileUploaded " +
                   " FROM dbo.GIMupdateLog inner join dbo.GIMissue on dbo.GIMupdateLog.Issue = dbo.GIMissue.ID inner join  " +
                   " [dbo].[GIMusers] on dbo.GIMupdateLog.UpdatedBy = dbo.GIMusers.ID " +
                   " WHERE dbo.GIMupdateLog.Issue = " + IssueID;

            _sql += " order by DateUpdate desc";

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
                          ",'" + Title + "'";

            if ( IssueStatus < 1)
            {
                _sql += ", null";
            }
            else
            {
                _sql += "," + IssueStatus;
            }

            if (IssueSeverity < 1)
            {
                _sql += ", null";
            }
            else
            {
                _sql += "," + IssueSeverity;
            }

            _sql += " ," + RaisedBy +
                    ",'" + Desc +
                    "'," + LeadFunction;

            if (Location < 1)
            {
                _sql += ", null";
            }
            else
            {
                _sql += "," + Location;
            }

            _sql += ",CONVERT(datetime,'" + DateOccurence +
                    "'), null" +
                    ",'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") +
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

        public void InsertUpdate(int IssueID, int UpdatedBy, string Creator, string UpdateText, string UpdateType, string FileUploaded)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = "INSERT INTO [dbo].[GIMupdateLog] " +
                          " ([Issue]" +
                          " ,[UpdatedBy]" +
                          " ,[Creator]" +
                          " ,[UpdateContext]" +
                          " ,[UpdateType]" +
                          " ,[DateUpdate]" +
                          " ,[FileUploaded])" +
                          " VALUES" +
                          " (" + IssueID +
                          "," + UpdatedBy +
                          ",'" + Creator +
                          "','" + UpdateText +
                          "','" + UpdateType +
                          "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + 
                          "','" + FileUploaded + "')";

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void InsertDailyReport(int UserID, string ReportText, string ReportStat, string DateMonth, int DateDay, int Finished)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = "INSERT INTO [dbo].[GIMdailyReport] " +
                          " ([ReportText]" +
                          " ,[ReportStats]" +
                          " ,[UserID]" +
                          " ,[DateMonth]" +
                          " ,[DateDay]" +
                          " ,[Finished])" +
                          " VALUES" +
                          " ('" + ReportText +
                          "','" + ReportStat +
                          "'," + UserID +
                          ",'" + DateMonth +
                          "'," + DateDay +
                          "," + Finished + ")";

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        #endregion

        #region Update data

        public void UpdateIssueDetails(int IssueID, int Type, string Title, int IssueStatus, int IssueSeverity, int RaisedBy, string Desc, int LeadFunction, string ImpactedFuncs, int Location,
            string ImpactedVenues, string DateOccurence, string Attch, string LocDesc, int Dashboard, int Reportable)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " UPDATE [dbo].[GIMissue] SET " +
                          " [Type] = " + Type +
                          ",[Title] = '" + Title + "'";

            if (IssueStatus < 1)
            {
                _sql += ", [IssueStatus] = null";
            }
            else
            {
                _sql += ", [IssueStatus] = " + IssueStatus;
            }

            if (IssueSeverity < 1)
            {
                _sql += ", [IssueSeverity] = null";
            }
            else
            {
                _sql += ", [IssueSeverity] = " + IssueSeverity;
            }


            _sql += " ,[Description] = '" + Desc + "'" +
                    " ,[LeadFunction] = " + LeadFunction;

            if (Location < 1)
            {
                _sql += ", [Location] = null";
            }
            else
            {
                _sql += ", [Location] =" + Location;
            }

            _sql += " ,[DateOccurence] = CONVERT(datetime, '" + DateOccurence + "')" +
                    " ,[DateUpdated] = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "'" +
                    " ,[Attachment] = '" + Attch + "'" +
                    " ,[Reportable] = " + Reportable +
                    " ,[Dashboard] = " + Dashboard +
                    " ,[LocationDesc] = '" + LocDesc + "' where ID = " + IssueID;

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();

            _sql = "delete from dbo.GIMimpactedFuncs where Issue = " + IssueID;
            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();

            _sql = "delete from dbo.GIMimpactedVenues where Issue = " + IssueID;
            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();

            string[] funcs = ImpactedFuncs.Split(',');
            string[] venues = ImpactedVenues.Split(',');

            int i = 0;
            for (; i < funcs.Length - 1; i++)
            {
                _sql += " INSERT INTO [dbo].[GIMimpactedFuncs] ([Issue], [Func]) VALUES (" + IssueID + ", " + funcs[i] + "); ";
            }

            for (i = 0; i < venues.Length - 1; i++)
            {
                _sql += " INSERT INTO [dbo].[GIMimpactedVenues] ([Issue], [Venue]) VALUES (" + IssueID + ", " + venues[i] + "); ";
            }

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void UpdateStatus(int IssueID, string DateActualEnd)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = "";

            if (DateActualEnd != "")
            {
                _sql = " UPDATE [dbo].[GIMissue] SET [IssueStatus] = 4, [DateActualEnd] = CONVERT(datetime, '" + DateActualEnd + "')" + " where ID = " + IssueID;
            }
            else
            {
                _sql = " UPDATE [dbo].[GIMissue] SET [IssueStatus] = 4, [DateActualEnd] = NULL where ID = " + IssueID;
            }

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateIssue(int IssueID, int IssueStatus, int Dashboard, int Reportable, string DateActualEnd)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " UPDATE [dbo].[GIMissue] SET " +
                          " [IssueStatus] = " + IssueStatus +
                          " ,[Reportable] = " + Reportable +
                          " ,[Dashboard] = " + Dashboard + 
                          " ,[DateActualEnd] = CONVERT(datetime, '" + DateActualEnd + "')" + " where ID = " + IssueID;

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateComment(int UpdateID, string UpdateContext, string FileUploaded)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " UPDATE [dbo].[GIMupdateLog] SET " +
                          " [UpdateContext] = '" + UpdateContext + "'" +
                          ",[DateUpdate] = '" + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "'" + 
                          ",[FileUploaded] = '" + FileUploaded + "' where ID = " + UpdateID;

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateUserPassword(int UserID, string newPass)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " UPDATE [dbo].[GIMusers] SET " +
                          " [UserPass] = '" + newPass + "' where ID = " + UserID;

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateDailyReport(int UserID, string ReportText, string ReportStat, string DateMonth, int DateDay, int Finished)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " UPDATE [dbo].[GIMdailyReport] SET " +
                          " [ReportText] = '" + ReportText + "'" +
                          ",[ReportStats] = '" + ReportStat + "'" +
                          ",[Finished] = " + Finished + 
                          " where [dbo].[GIMdailyReport].[UserID] = " + UserID +
                          " and [dbo].[GIMdailyReport].[DateMonth] = '" + DateMonth + "' and [dbo].[GIMdailyReport].[DateDay] = " + DateDay;

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        #endregion

        #region Delete data

        public void DeleteComment(int UpdateID)
        {
            SqlConnection conn = new SqlConnection(@connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();

            string _sql = " DELETE FROM [dbo].[GIMupdateLog] WHERE ID = " + UpdateID;

            cmd.CommandText = _sql;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        

        #endregion
    }
}
