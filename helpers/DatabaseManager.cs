using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TimeSheetTool.model;

namespace TimeSheetTool.helpers
{
    public class DatabaseManager
    {
        private readonly string connectionString = "";

        private readonly string Sq_TimeSheet_Entries_Breakdown =
            "SELECT UserName, Day, ProjectName, Task, Hours, Rate " +
            "FROM Socket_Timesheet_Detail_Report WITH (NOLOCK) " +
            "WHERE projectName IN (@Projects) " +
            "AND Day BETWEEN @From AND @To";


        public List<TimeSheetEntry> RetrieveDailyDataForUsers(DateTime from, DateTime to, List<string> projects)
        {

            List<TimeSheetEntry> entries = new List<TimeSheetEntry>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(Sq_TimeSheet_Entries_Breakdown, connection))
                {
                    command.CommandText = command.CommandText.Replace("@Projects", string.Join(",", projects.Select(b => b)));
                    command.Parameters.AddWithValue("@From", from);
                    command.Parameters.AddWithValue("@To", to);

                    command.CommandTimeout = 0;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                TimeSheetEntry entry = new TimeSheetEntry();

                                entry.Name = reader.GetString(0);
                                entry.Date = reader.GetDateTime(1);
                                entry.ProjectName = reader.GetString(2);
                                entry.Task = reader.GetString(3);
                                entry.Hours = reader.GetDouble(4);
                                entry.Rate = reader.GetDouble(5);
                                entries.Add(entry);
                            }
                        }
                    } 
                } 
            } 

            return entries;
        }
    }
}
