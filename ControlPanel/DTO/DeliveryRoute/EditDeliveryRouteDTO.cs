using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.DeliveryRoute
{
    public class EditDeliveryRouteDTO
    {
        [Required]
        public long DeliveryRouteId { get; set; }
        [Required]
        public string DeliverRouteName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
