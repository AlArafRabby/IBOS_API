using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblItemAttribute
    {
        public long IntItemAttributeId { get; set; }
        public long IntClientId { get; set; }
        public string StrItemAttributeName { get; set; }
        public long IntItemAttributeUom { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntItemCategoryId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
