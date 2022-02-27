using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountingPostingType
{
    public class GetAccountingPostingTypeDTO
    {
        [Required]
        public long AccountingPostingTypeId { get; set; }
        public string AccountPostingTypeName { get; set; }
    }
}
