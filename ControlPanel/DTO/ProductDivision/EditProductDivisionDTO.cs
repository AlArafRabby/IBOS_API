using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ProductDivision
{
    public class EditProductDivisionDTO
    {
        [Required]
        public long ProductDivisionId { get; set; }
        [Required]
        public string ProductDivisionName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
