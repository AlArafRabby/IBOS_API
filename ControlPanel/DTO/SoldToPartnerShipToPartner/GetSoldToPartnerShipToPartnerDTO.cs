using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SoldToPartnerShipToPartner
{
    public class GetSoldToPartnerShipToPartnerDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long SoldToPartnerId { get; set; }
        public string SoldToPartnerName { get; set; }
        public long ShipToPartnerId { get; set; }
        public string ShipToPartnerName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
