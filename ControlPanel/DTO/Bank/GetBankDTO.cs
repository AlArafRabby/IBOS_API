using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Bank
{
    public class GetBankDTO
    {
        [Required]
        public long BankId { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
