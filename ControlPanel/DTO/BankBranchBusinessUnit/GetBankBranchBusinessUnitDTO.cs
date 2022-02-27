using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankBranchBusinessUnit
{
    public class GetBankBranchBusinessUnitDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public string BusinessUnitName { get; set; }
        public string BusinessName { get; set; }
        public long  BankId { get; set; }
        public string BankName { get; set; }
        public long BankBranchId { get; set; }
        public string BankBranchName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
