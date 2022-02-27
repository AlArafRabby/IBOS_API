using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartnerShipPoint
{
    public class EditBusinessPartnerShipPointDTO
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
        public long ShipPointId { get; set; }
        [Required]
        public decimal DistanceKm { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
