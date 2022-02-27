using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.RouteTransportzone
{
    public class GetRouteTransportzoneDTO
    {
        public long ConfigId { get; set; }
        public long TransportZoneId { get; set; }
        public string TransportZoneName { get; set; }
        public long RouteId { get; set; }
        public string RouteName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
