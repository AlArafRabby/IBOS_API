using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.CashJournalHeader
{
    public class GetCashJournalHeaderDTO
    {
        [Required]
        public long CashJournalId { get; set; }
        public string CashJournalCode { get; set; }
        public DateTime JournalDate { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessAreaId { get; set; }
        public string BusinessAreaName { get; set; }
        public long GeneralLedgerId { get; set; }
        public decimal Amount { get; set; }
        public string Narration { get; set; }
        public bool Posted { get; set; }
        public bool BusinessPartnerId { get; set; }
        public string BusinessPartnerName { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public long ActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }

    }
}
