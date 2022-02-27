using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankBranch
{
    public class GetBankBranchDTO
    {
        [Required]
        public long BankBranchId { get; set; }
        [Required]
        public string BankBranchCode { get; set; }
        [Required]
        public string BankBranchName { get; set; }
        [Required]
        public string BankBranchAddress { get; set; }
        public long CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
        public long BankId { get; set; }
        [Required]
        public string BankName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }

    }
}
