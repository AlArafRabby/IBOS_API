using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBankJournalHeader
    {
        public long IntBankJournalId { get; set; }
        public string StrBankJournalCode { get; set; }
        public DateTime DteVoucherDate { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntBankId { get; set; }
        public string StrBankName { get; set; }
        public long IntBankBranchId { get; set; }
        public string StrBankBranchName { get; set; }
        public long IntBankAccountId { get; set; }
        public string StrBankAccountNumber { get; set; }
        public long IntInstrumentTypeId { get; set; }
        public string StrInstrumentName { get; set; }
        public string StrInstrumentNumber { get; set; }
        public DateTime DteInstrumentDate { get; set; }
        public long IntGeneralLedgerId { get; set; }
        public decimal NumAmount { get; set; }
        public string StrNarration { get; set; }
        public bool IsPosted { get; set; }
        public string StrBusinessPartnerName { get; set; }
        public long IntAccountingJournalTypeId { get; set; }
        public bool IsDirectPosting { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
