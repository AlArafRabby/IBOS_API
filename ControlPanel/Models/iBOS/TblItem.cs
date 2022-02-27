using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblItem
    {
        public long IntItemId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntItemMasterId { get; set; }
        public string StrItemCode { get; set; }
        public string StrItemName { get; set; }
        public long IntItemTypeId { get; set; }
        public string StrItemTypeName { get; set; }
        public long IntItemCategoryId { get; set; }
        public string StrItemCategoryName { get; set; }
        public long IntItemSubCategoryId { get; set; }
        public string StrItemSubCategoryName { get; set; }
        public long IntUomid { get; set; }
        public string StrUomname { get; set; }
        public decimal NumGrossWeightKg { get; set; }
        public decimal NumNetWeightKg { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
