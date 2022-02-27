using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class CreateItemDTO
    {
        public long Id { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ItemMasterId { get; set; }
        [Required]
        public string ItemCode { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public long ItemTypeId { get; set; }
        [Required]
        public string ItemTypeName { get; set; }
        [Required]
        public long ItemCategoryId { get; set; }
        [Required]
        public string ItemCategoryName { get; set; }
        [Required]
        public long ItemSubCategoryId { get; set; }
        [Required]
        public string ItemSubCategoryName { get; set; }
        [Required]
        public long Uomid { get; set; }
        [Required]
        public string Uomname { get; set; }
        [Required]
        public decimal GrossWeightKg { get; set; }
        [Required]
        public decimal NetWeightKg { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
