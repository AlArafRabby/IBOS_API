using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBankBranchBusinessUnit
    {
        public long IntConfigId { get; set; }
        public long IntClientid { get; set; }
        public long IntBusinessUnitId { get; set; }
        public string StrBusinessName { get; set; }
        public long IntBankId { get; set; }
        public string StrBankName { get; set; }
        public long IntBankBranchId { get; set; }
        public string StrBankBranchName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
