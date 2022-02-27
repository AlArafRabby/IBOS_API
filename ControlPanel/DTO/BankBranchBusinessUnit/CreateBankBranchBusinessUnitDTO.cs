using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankBranchBusinessUnit
{
    public class CreateBankBranchBusinessUnitDTO
    {
        [Required]
        public long Clientid { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public string BusinessName { get; set; }
        [Required]
        public long BankId { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public long BankBranchId { get; set; }
        [Required]
        public string BankBranchName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
