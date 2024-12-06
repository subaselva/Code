using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    // Domain/Entities/UnitCost.cs
    public class UnitCost
    {
        public int Id { get; set; }
        public string UnitCodeArea { get; set; }
        public string MaterialName { get; set; }
        public string BrandName { get; set; }
        public string SupplierDetails { get; set; }
        public string MaterialNeededIn { get; set; }
        public decimal UnitPrice { get; set; }
        public int NumberOfUnits { get; set; }
        public decimal TotalMaterialCost => UnitPrice * NumberOfUnits;
        public string LabourArea { get; set; }
        public decimal LabourCostPerUnit { get; set; }
        public decimal TotalLabourCost => CalculateLabourCost();
        public int ManHours { get; set; }
        public decimal TotalCostOfUnit => TotalMaterialCost + TotalLabourCost;

        private decimal CalculateLabourCost()
        {
            if (LabourArea.EndsWith("sqft"))
            {
                var area = decimal.Parse(LabourArea.Replace("sqft", "").Trim());
                return area * LabourCostPerUnit;
            }
            return NumberOfUnits * LabourCostPerUnit;
        }
    }

}
