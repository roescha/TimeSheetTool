using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSheetTool.model
{
    public class SpreadSheetEntry
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CostType { get; set; }
        public string CostCentre { get; set; }
        public string Company { get; set; }
        public string Entity { get; set; }
        public Double Quantity { get; set; }
        public Double UnitAmount { get; set; }


    }
}
