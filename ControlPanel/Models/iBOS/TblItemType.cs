using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblItemType
    {
        public long IntItemTypeId { get; set; }
        public long IntClientId { get; set; }
        public string StrItemTypeName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
