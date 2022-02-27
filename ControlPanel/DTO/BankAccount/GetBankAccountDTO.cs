using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankAccount
{
    public class GetBankAccountDTO
    {
        [Required]
        public long BankAccountId { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }
        public long BankId { get; set; }
        public string BankName { get; set; }
        public long BankBranchId { get; set; }
        public string BankBranchName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
