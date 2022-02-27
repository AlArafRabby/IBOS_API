using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessArea
{
    public class CancelBusinessAreaDTO
    {
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
