using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBankAccount
    {
        public long IntBankAccountId { get; set; }
        public string StrBankAccountName { get; set; }
        public string StrBankAccountNo { get; set; }
        public long IntBankId { get; set; }
        public string StrBankName { get; set; }
        public long IntBankBranchId { get; set; }
        public string StrBankBranchName { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
