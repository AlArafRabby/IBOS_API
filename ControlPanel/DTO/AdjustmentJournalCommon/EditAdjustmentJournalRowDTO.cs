using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class EditAdjustmentJournalRowDTO
    {
        [Required]
        public long RowId { get; set; }
        [Required]
        public long AdjustmentJournalId { get; set; }
        [Required]
        public string AdjustmentJournalCode { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public string GeneralLedgerName { get; set; }
        [Required]
        public string Narration { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
