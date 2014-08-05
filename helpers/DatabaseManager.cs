using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using TimeSheetTool.model;

namespace TimeSheetTool.helpers
{
    public class DatabaseManager
    {
        private readonly string ConnectionString;
        

        private readonly string Sql_TimeSheet_Entries_Breakdown =
            "SELECT UserName, Day, ProjectName, Task, Hours, Rate " +
            "FROM Socket_Timesheet_Detail_Report WITH (NOLOCK) " +
            "WHERE projectName IN (@Projects) " +
            "AND Day BETWEEN @From AND @To";

        public DatabaseManager()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["TimesheetReportsDb"].ConnectionString;
        }

        public List<TimeSheetEntry> RetrieveDailyDataForUsers(DateTime from, DateTime to, List<string> projects)
        {

            List<TimeSheetEntry> entries = new List<TimeSheetEntry>();

            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (var command = new SqlCommand(Sql_TimeSheet_Entries_Breakdown, connection))
                {
                    command.CommandText = command.CommandText.Replace("@Projects", string.Join(",", projects));
                    command.Parameters.AddWithValue("@From", from);
                    command.Parameters.AddWithValue("@To", to);

                    command.CommandTimeout = 0;

                    using (var reader = command.ExecuteReader())
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
