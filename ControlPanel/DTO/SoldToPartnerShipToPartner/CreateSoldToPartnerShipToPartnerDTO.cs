using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SoldToPartnerShipToPartner
{
    public class CreateSoldToPartnerShipToPartnerDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long SoldToPartnerId { get; set; }
        [Required]
        public string SoldToPartnerName { get; set; }
        [Required]
        public long ShipToPartnerId { get; set; }
        [Required]
        public string ShipToPartnerName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
