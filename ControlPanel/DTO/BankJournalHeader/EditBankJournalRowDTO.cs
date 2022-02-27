using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class EditBankJournalRowDTO
    {
        [Required]
        public long RowId { get; set; }
        [Required]
        public decimal Amount { get; set; }
    }
}
