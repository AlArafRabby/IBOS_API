using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class CreateBankJournalHeaderDTO
    {
        [Required]
        public string BankJournalCode { get; set; }
        [Required]
        public DateTime VoucherDate { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long BankId { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public long BankBranchId { get; set; }
        [Required]
        public string BankBranchName { get; set; }
        [Required]
        public long BankAccountId { get; set; }
        [Required]
        public string BankAccountNumber { get; set; }
        [Required]
        public long InstrumentTypeId { get; set; }
        [Required]
        public string InstrumentName { get; set; }
        [Required]
        public string InstrumentNumber { get; set; }
        [Required]
        public DateTime InstrumentDate { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public bool IsPosted { get; set; }
        [Required]
        public string BusinessPartnerName { get; set; }
        [Required]
        public long AccountingJournalTypeId { get; set; }
        [Required]
        public bool IsDirectPosting { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
