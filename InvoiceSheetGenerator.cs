using System;
using System.Collections.Generic;
using TimeSheetTool.helpers;
using TimeSheetTool.model;

namespace TimeSheetTool
{
    /* 
     * Adds a new sheet containing the daily break down data for the selected projects in the specified date range.
     * The data is extracted from timesheets database (name, task, hours, rate) and linked to cost centre/company data in the provided spreadsheet
     */ 
    public class InvoiceSheetGenerator
    {
        private readonly DatabaseManager databaseUtil = new DatabaseManager();

        public void GenerateInvoiceSheet(DateTime from, DateTime to, string fileName, List<string> projectList, string costCentreSheetName, string targetSheetName)
        {
            // this util will be used to retrieve the company and cost centre and to create and populate the new sheet in the provideed spreadsheet
            SpreadSheetUtil spreadSheetUtil = new SpreadSheetUtil(fileName, costCentreSheetName, targetSheetName);

            // reads daily time sheet data from time sheet database
            List<TimeSheetEntry> timeSheetEntries = databaseUtil.RetrieveDailyDataForUsers(from, to, projectList);

            // prepares break down data by linking time sheet data with spread sheet data
            List<SpreadSheetEntry> spreadSheetEntries = GenerateBreakDownDataForProjectParticipants(timeSheetEntries, spreadSheetUtil);

            // populates and saves new sheet
            spreadSheetUtil.AddSheet(spreadSheetEntries);
        }

        /// <summary>
        /// Generates a list of entries that will be used to populate the new sheet in the spreadsheet
        /// </summary>
        /// <param name="timeSheetEntries">the entries retrieved from the time sheet database</param>
        /// <param name="spreadSheetUtil">utility to manage reads and writes to spreadsheet</param>
        /// <param name="sourceSheet">sheet name that contains the company and cost centre info</param>
        /// <returns></returns>
        private List<SpreadSheetEntry> GenerateBreakDownDataForProjectParticipants(List<TimeSheetEntry> timeSheetEntries, SpreadSheetUtil spreadSheetUtil)
        {
            List<SpreadSheetEntry> spreadSheetEntries = new List<SpreadSheetEntry>();

            foreach (TimeSheetEntry timeSheetEntry in timeSheetEntries)
            {
                SpreadSheetEntry spreadSheetEntry = new SpreadSheetEntry();

                CostCentreInfo centreValues = spreadSheetUtil.GetCostCentreDetailsFromSheet(timeSheetEntry);

                spreadSheetEntry.Date = timeSheetEntry.Date;
                spreadSheetEntry.Name = timeSheetEntry.Name;
                spreadSheetEntry.Description = timeSheetEntry.Task;
                spreadSheetEntry.Quantity = timeSheetEntry.Hours;
                spreadSheetEntry.UnitAmount = timeSheetEntry.Rate;
                spreadSheetEntry.CostType = timeSheetEntry.Task.Equals("Developmnet", StringComparison.CurrentCultureIgnoreCase) ||
                    timeSheetEntry.Task.Equals("Analysis", StringComparison.CurrentCultureIgnoreCase) ?
                    "APP_DEVELOPMENT(PROJECTS)" : "PROJECT MANAGEMENT";
                spreadSheetEntry.CostCentre = centreValues.CostCentre;
                spreadSheetEntry.Company = centreValues.Company;
                spreadSheetEntry.Entity = centreValues.Entity;

                spreadSheetEntries.Add(spreadSheetEntry);
            }

            return spreadSheetEntries;
        }
    }

}
