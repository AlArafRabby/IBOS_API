using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.GeneralLedger
{
    public class CreateGeneralLedgerDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long AccountGroupId { get; set; }
        [Required]
        public long AccountClassId { get; set; }
        [Required]
        public long AccountCategoryId { get; set; }
        [Required]
        public string GeneralLedgerCode { get; set; }
        [Required]
        public string GeneralLedgerName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; } 
        [Required]
        public bool? IsActive { get; set; }

    }
}
