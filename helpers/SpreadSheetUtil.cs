
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TimeSheetTool.model;


namespace TimeSheetTool.helpers
{
    public class SpreadSheetUtil
    {
        private readonly FileInfo spreadSheetFile;
        private readonly Dictionary<string, CostCentreInfo> costCentreCache; 

        public SpreadSheetUtil(string fileName)
        {
            spreadSheetFile = new FileInfo(fileName);
            
            // put in the cache the info for the given cost centre, as there will be dozens of reads for the same project
            costCentreCache = new Dictionary<string, CostCentreInfo>();
        }

        public void AddSheet(List<model.SpreadSheetEntry> entries, string sheetName)
        {
            AddSheeet(sheetName, entries);
        }


        public CostCentreInfo GetCostCentreDetailsFromSheet(TimeSheetEntry timeSheetEntry, string companyCostCentreSheetName)
        {
            var projectName = timeSheetEntry.ProjectName;
            var projectId = projectName.Substring(projectName.LastIndexOf(" ") + 1);

            if (costCentreCache.ContainsKey(projectId))
            {
                return costCentreCache[projectId];
            }

            var costCentreInfo = GetCostCentreInfo(companyCostCentreSheetName, projectId);
            costCentreCache.Add(projectId,costCentreInfo);
        
            return costCentreInfo;
        }


        private CostCentreInfo GetCostCentreInfo(string sheetName, string projectId)
        {

            using (ExcelPackage xlPackage = new ExcelPackage(spreadSheetFile))
            {
                ExcelWorksheet worksheet;
                var sheetId = 1;
                
                while (true)
                {
                    worksheet = xlPackage.Workbook.Worksheets[sheetId++];

                    if (worksheet == null) throw new Exception("Sheet name does not exist in excel document: " + sheetName);

                    if (worksheet.Name.Trim().Equals(sheetName, StringComparison.CurrentCultureIgnoreCase)) break;                 
                }

                var rownum = 0;
                while (worksheet.GetValue(++rownum, 1) != null)
                {
                    string cell = (string)worksheet.GetValue(rownum, 1);
                    cell = cell.Trim();
                    //assumes the cost centre column includes the numeric project somewhere in the text
                    if (cell.Contains(projectId)) break;
                }

                if (worksheet.GetValue(rownum, 1) == null)
                {
                    throw new Exception("Project Id in spreadsheet could not be found: " + projectId);
                }

                return new CostCentreInfo((string) worksheet.GetValue(rownum, 1), (string) worksheet.GetValue(rownum, 5), (string) worksheet.GetValue(rownum, 6));
            }

        }

        private void AddSheeet(String name, List<SpreadSheetEntry> entries)
        {

            using (ExcelPackage xlPackage = new ExcelPackage(spreadSheetFile))
            {
                ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add(name);

                //Add the headers 
                worksheet.Cells[1, 1].Value = "WORKED DATE";
                worksheet.Cells[1, 2].Value = "RESOURCE NAME";
                worksheet.Cells[1, 3].Value = "DESCRIPTION";
                worksheet.Cells[1, 4].Value = "ACTIVITY";
                worksheet.Cells[1, 5].Value = "REFERENCE";
                worksheet.Cells[1, 6].Value = "QUANTITY";
                worksheet.Cells[1, 7].Value = "UNIT OF MEASURE";
                worksheet.Cells[1, 8].Value = "UNIT AMOUNT";
                worksheet.Cells[1, 9].Value = "TOTAL AMOUNT";
                worksheet.Cells[1, 10].Value = "COST TYPE";
                worksheet.Cells[1, 11].Value = "COST CENTRE";
                worksheet.Cells[1, 12].Value = "INVOICE";
                worksheet.Cells[1, 13].Value = "INVOICE DATE";
                worksheet.Cells[1, 14].Value = "BILLED COMPANY";
                worksheet.Cells[1, 15].Value = "ENTITY";

                // sets the column format to the required date format
                worksheet.Column(1).Style.Numberformat.Format = "dd/mm/yyyy";
               
                // order in ascending date
                var orderedList = entries.OrderBy(o => o.Date).ToList();
                var row = 2;
                
                // populate the entries
                foreach (SpreadSheetEntry entry in orderedList)
                {
                    worksheet.Cells[row, 1].Value = entry.Date;
                    worksheet.Cells[row, 2].Value = entry.Name;
                    worksheet.Cells[row, 3].Value = entry.Description;
                    worksheet.Cells[row, 4].Value = "--";
                    worksheet.Cells[row, 5].Value = "--";
                    worksheet.Cells[row, 6].Value = entry.Quantity;
                    worksheet.Cells[row, 7].Value = "HOURS";
                    worksheet.Cells[row, 8].Value = entry.UnitAmount;
                    worksheet.Cells[row, 9].Value = entry.Quantity * entry.UnitAmount ;
                    worksheet.Cells[row, 10].Value = entry.CostType;
                    worksheet.Cells[row, 11].Value = entry.CostCentre;
                    worksheet.Cells[row, 12].Value = "--";
                    worksheet.Cells[row, 13].Value = "--";
                    worksheet.Cells[row, 14].Value = entry.Company;
                    worksheet.Cells[row, 15].Value = entry.Entity;
                    ++row;
                }

                xlPackage.Save();
            }
        }
    }
}
