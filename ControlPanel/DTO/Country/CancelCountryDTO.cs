using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Country
{
    public class CancelCountryDTO
    {
        [Required]
        public long CountryId { get; set; }
        [Required]
        public long ActionBy { get; set; }

    }
}
