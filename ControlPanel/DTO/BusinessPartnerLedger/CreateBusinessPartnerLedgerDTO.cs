using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerLedger
{
    public class CreateBusinessPartnerLedgerDTO
    {
        [Required]
        public DateTime TransactionDate { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public long AccountingJournalTypeId { get; set; }
        [Required]
        public string AccountingJournalTypeName { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [Required]
        public decimal RunningAmount { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public long AccountingJournalId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
