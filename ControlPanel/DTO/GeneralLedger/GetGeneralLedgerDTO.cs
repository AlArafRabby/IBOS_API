using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.GeneralLedger
{
    public class GetGeneralLedgerDTO
    {
        [Required]
        public long GeneralLedgerId { get; set; }
        [Required]
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        [Required]
        public long AccountGroupId { get; set; }
        public string AccountGroupName { get; set; }
        [Required]
        public long AccountClassId { get; set; }
        public string AccountClassName { get; set; }
        [Required]
        public long AccountCategoryId { get; set; }
        public string AccountCategoryName { get; set; }
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
