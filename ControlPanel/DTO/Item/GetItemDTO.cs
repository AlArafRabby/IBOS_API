using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class GetItemDTO
    {
        [Required]
        public long Id { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ItemMasterId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public long ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public long ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        public long ItemSubCategoryId { get; set; }
        public string ItemSubCategoryName { get; set; }
        public long Uomid { get; set; }
        public string Uomname { get; set; }
        public decimal GrossWeightKg { get; set; }
        public decimal NetWeightKg { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
      
    }
}
