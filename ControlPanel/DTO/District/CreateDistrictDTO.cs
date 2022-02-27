using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.District
{
    public class CreateDistrictDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string DistrictCode { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public long CountryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
