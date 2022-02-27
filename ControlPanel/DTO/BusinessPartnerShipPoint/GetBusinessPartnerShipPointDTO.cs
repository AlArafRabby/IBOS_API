using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerShipPoint
{
    public class GetBusinessPartnerShipPointDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessPartnerId { get; set; }
        public string BusinessPartnerName { get; set; }
        public long ShipPointId { get; set; }
        public string ShipPointName { get; set; }
        public decimal DistanceKm { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
