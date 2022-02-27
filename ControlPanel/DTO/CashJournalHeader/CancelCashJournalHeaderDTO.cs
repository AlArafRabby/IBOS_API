using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.CashJournalHeader
{
    public class CancelCashJournalHeaderDTO
    {
        [Required]
        public long IntCashJournalId { get; set; }
        [Required]
        public long IntActionBy { get; set; }
    }
}
