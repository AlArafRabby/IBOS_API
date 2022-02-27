using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.RouteTransportzone
{
    public class EditRouteTransportzoneDTO
    {
        public long ConfigId { get; set; }
        public long TransportZoneId { get; set; }
        public long RouteId { get; set; }
        public long BusinessUnitId { get; set; }
        public long ClientId { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
