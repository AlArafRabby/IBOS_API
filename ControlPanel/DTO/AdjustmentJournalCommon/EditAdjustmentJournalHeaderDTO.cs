using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class EditAdjustmentJournalHeaderDTO
    {
        [Required]
        public long AdjustmentJournalId { get; set; }
        [Required]
        public string AdjustmentJournalCode { get; set; }
        [Required]
        public DateTime JournalDate { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public decimal DebitAmount { get; set; }
        [Required]
        public decimal CreditAmount { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public bool IsPosted { get; set; }
        [Required]
        public long AccountingJournalTypeId { get; set; }
        [Required]
        public bool IsDirectPosting { get; set; }
        [Required]
        public long ActionBy { get; set; }        
        public DateTime LastActionDateTime { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
