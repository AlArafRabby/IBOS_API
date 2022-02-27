using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Thana
{
    public class GetThanaDTO
    {
        [Required]
        public long ThanaId { get; set; }
        public string ThanaName { get; set; }
        public long DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string ThanaBanglaName { get; set; }
        public long Geocode { get; set; }
        public bool? IsActive { get; set; }

    }
}
