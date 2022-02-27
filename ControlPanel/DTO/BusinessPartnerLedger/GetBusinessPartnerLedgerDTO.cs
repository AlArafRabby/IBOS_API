using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerLedger
{
    public class GetBusinessPartnerLedgerDTO
    {
        [Required]
        public long TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public long ClientId { get; set; }
        public string ClientName{ get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessAreaId { get; set; }
        public string BusinessAreaName { get; set; }
        public long IntBusinessPartnerId { get; set; }
        public string BusinessPartnerName { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public string AccountingJournalTypeName { get; set; }
        public decimal Amount { get; set; }
        public decimal RunningAmount { get; set; }
        public string Narration { get; set; }
        public long AccountingJournalId { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
