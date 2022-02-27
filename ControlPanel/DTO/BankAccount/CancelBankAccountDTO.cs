using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankAccount
{
    public class CancelBankAccountDTO
    {
        [Required]
        public long BankAccountId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
