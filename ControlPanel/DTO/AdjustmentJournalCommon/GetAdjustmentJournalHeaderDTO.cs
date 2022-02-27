using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class GetAdjustmentJournalHeaderDTO
    {
        [Required]
        public long AdjustmentJournalId { get; set; }
        [Required]
        public string AdjustmentJournalCode { get; set; }
        public DateTime DteJournalDate { get; set; }
        public long ClientId { get; set; }
        public long BusinessUnitId { get; set; }
        public long BusinessAreaId { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public string Narration { get; set; }
        public bool IsPosted { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public bool IsDirectPosting { get; set; }
        public long ActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
