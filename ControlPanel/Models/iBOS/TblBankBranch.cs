using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBankBranch
    {
        public long IntBankBranchId { get; set; }
        public string StrBankBranchCode { get; set; }
        public string StrBankBranchName { get; set; }
        public string StrBankBranchAddress { get; set; }
        public long? IntCountryId { get; set; }
        public long? IntBankId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
