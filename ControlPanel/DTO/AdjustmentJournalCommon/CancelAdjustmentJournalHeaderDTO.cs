using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class CancelAdjustmentJournalHeaderDTO
    {
        [Required]
        public long AdjustmentJournalId { get; set; }
        [Required]
        public string AdjustmentJournalCode { get; set; }      
        [Required]
        public long ActionBy { get; set; }       
    }
}
