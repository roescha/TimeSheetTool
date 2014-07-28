
namespace TimeSheetTool.model
{
    public class CostCentreInfo
    {
        public string Company { get; set; }
        public string Entity { get; set; }
        public string CostCentre { get; set; }

        public CostCentreInfo(string company, string entity, string costCentre){
        this.Company = company;
        this.Entity = entity;
        this.CostCentre = costCentre;
    }

    }
}
