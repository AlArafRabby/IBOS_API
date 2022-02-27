using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.District
{
    public class GetDistrictDTO
    {
        [Required]
        public long DistrictId { get; set; }
        public string DistrictCode { get; set; }
        public string DistrictName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
