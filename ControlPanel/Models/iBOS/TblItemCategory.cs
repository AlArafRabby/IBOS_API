using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblItemCategory
    {
        public long IntItemCategoryId { get; set; }
        public long IntClientId { get; set; }
        public string StrItemCategoryCode { get; set; }
        public string StrItemCategoryName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntItemTypeId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
