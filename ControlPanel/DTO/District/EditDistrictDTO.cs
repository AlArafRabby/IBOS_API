using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.District
{
    public class EditDistrictDTO
    {
        [Required]
        public long DistrictId { get; set; }
        [Required]
        public string DistrictName { get; set; }
        [Required]
        public long CountryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
