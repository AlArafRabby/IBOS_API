using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankBranch
{
    public class CancelBankBranchDTO
    {
        [Required]
        public long BankBranchId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
