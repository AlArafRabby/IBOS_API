using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ProductDivision
{
    public class CancelProductDivisionDTO
    {
        [Required]
        public long ProductDivisionId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
