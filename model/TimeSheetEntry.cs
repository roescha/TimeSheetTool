using System;

namespace TimeSheetTool.model
{
    public class TimeSheetEntry
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Task { get; set; }
        public Double Hours { get; set; }
        public Double Rate { get; set; }
        public string ProjectName { get; set; }
    }
}
