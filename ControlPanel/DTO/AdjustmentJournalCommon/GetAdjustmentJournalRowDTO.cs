using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class GetAdjustmentJournalRowDTO
    {
        [Required]
        public long RowId { get; set; }
        [Required]
        public long AdjustmentJournalId { get; set; }
        [Required]
        public string AdjustmentJournalCode { get; set; }
        [Required]
        public long GeneralLedgerId { get; set; }
        public string GeneralLedgerName { get; set; }
        public string Narration { get; set; }
        public decimal Amount { get; set; }
    }
}
