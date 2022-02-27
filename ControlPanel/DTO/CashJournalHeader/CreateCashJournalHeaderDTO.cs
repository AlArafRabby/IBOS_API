using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.CashJournalHeader
{
    public class CreateCashJournalHeaderDTO
    {
        [Required]
        public string CashJournalCode { get; set; }
        [Required]
        public DateTime JournalDate { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public bool Posted { get; set; }
        [Required]
        public string BusinessPartnerName { get; set; }
        [Required]
        public long AccountingJournalTypeId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime DteLastActionDateTime { get; set; }
    }
}
