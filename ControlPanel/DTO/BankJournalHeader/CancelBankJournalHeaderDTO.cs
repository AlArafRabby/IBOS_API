using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class CancelBankJournalHeaderDTO
    {
        [Required]
        public long BankJournalId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
