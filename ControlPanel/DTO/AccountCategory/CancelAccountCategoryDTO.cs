using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountCategory
{
    public class CancelAccountCategoryDTO
    {
        [Required]
        public long AccountCategoryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        //private long accountCategoryId;
        //private long actionBy;
        //public long AccountCategoryId { get => accountCategoryId; set => accountCategoryId = value; }
        //public long ActionBy { get => actionBy; set => actionBy = value; }
    }
}
