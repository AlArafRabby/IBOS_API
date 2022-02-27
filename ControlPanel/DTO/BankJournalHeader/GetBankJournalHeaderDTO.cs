using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class GetBankJournalHeaderDTO
    {
        [Required]
        public long BankJournalId { get; set; }
        public string BankJournalCode { get; set; }
        public DateTime VoucherDate { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessAreaId { get; set; }
        public string BusinessAreaName { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }
        public long BankBranchId { get; set; }
        public string BankBranchName { get; set; }
        public long BankAccountId { get; set; }
        public string BankAccountNumber { get; set; }
        public long InstrumentTypeId { get; set; }
        public string InstrumentName { get; set; }
        public string InstrumentNumber { get; set; }
        public DateTime InstrumentDate { get; set; }
        public long GeneralLedgerId { get; set; }
        public string GeneralLedgerName { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public bool IsPosted { get; set; }
        public string BusinessPartnerName { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public string AccountingJournalTypeName { get; set; }
        public bool IsDirectPosting { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
