using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeSheetTool.helpers;
using TimeSheetTool.model;

namespace TimeSheetTool
{
    public class InvoiceSheetGenerator
    {
        private readonly DatabaseManager databaseUtil = new DatabaseManager();

        public void GenerateInvoiceSheet(DateTime from, DateTime to, string fileName, List<string> projectList, string sourceSheet, string targetSheet)
        {
            SpreadSheetUtil spreadSheetUtil = new SpreadSheetUtil(fileName);

            List<TimeSheetEntry> timeSheetEntries = databaseUtil.RetrieveDailyDataForUsers(from, to, projectList);
            List<SpreadSheetEntry> spreadSheetEntries = GenerateBreakDownDataForUsers(timeSheetEntries, spreadSheetUtil, sourceSheet);

            spreadSheetUtil.AddSheet(spreadSheetEntries, targetSheet);
        }


        private List<SpreadSheetEntry> GenerateBreakDownDataForUsers(List<TimeSheetEntry> timeSheetEntries, SpreadSheetUtil spreadSheetUtil, string sourceSheet)
        {
            List<SpreadSheetEntry> spreadSheetEntries = new List<SpreadSheetEntry>();

            foreach (TimeSheetEntry timeSheetEntry in timeSheetEntries)
            {
                SpreadSheetEntry spreadSheetEntry = new SpreadSheetEntry();

                Dictionary<int, object> centreValues = spreadSheetUtil.GetCostCentreDetailsFromSheet(timeSheetEntry, sourceSheet);

                spreadSheetEntry.Date = timeSheetEntry.Date;
                spreadSheetEntry.Name = timeSheetEntry.Name;
                spreadSheetEntry.Description = timeSheetEntry.Task;
                spreadSheetEntry.Quantity = timeSheetEntry.Hours;
                spreadSheetEntry.UnitAmount = timeSheetEntry.Rate;
                spreadSheetEntry.CostType = timeSheetEntry.Task.Equals("Developmnet", StringComparison.CurrentCultureIgnoreCase) ||
                    timeSheetEntry.Task.Equals("Analysis", StringComparison.CurrentCultureIgnoreCase) ?
                    "APP_DEVELOPMENT(PROJECTS)" : "PROJECT MANAGEMENT";
                spreadSheetEntry.CostCentre = (string)centreValues[1];
                spreadSheetEntry.Company = (string)centreValues[5];
                spreadSheetEntry.Entity = (string)centreValues[6];

                spreadSheetEntries.Add(spreadSheetEntry);
            }

            return spreadSheetEntries;
        }
    }

}
