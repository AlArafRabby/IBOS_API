using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankAccount
{
    public class CreateBankAccountDTO
    {
        [Required]
        public string BankAccountName { get; set; }
        [Required]
        public string BankAccountNo { get; set; }
        [Required]
        public long BankId { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public long BankBranchId { get; set; }
        [Required]
        public string BankBranchName { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
