using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerZone
{
    public class EditBusinessPartnerZoneDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public long TransportZoneId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
