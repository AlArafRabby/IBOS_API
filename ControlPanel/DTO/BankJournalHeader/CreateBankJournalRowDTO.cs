using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class CreateBankJournalRowDTO
    {
        [Required]
        public long BankJournalId { get; set; }
        [Required]
        public string BankJournalCode { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public string GeneralLedgerCode { get; set; }
        [Required]
        public string GeneralLedgerName { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
