using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
