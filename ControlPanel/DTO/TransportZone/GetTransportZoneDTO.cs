using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TransportZone
{
    public class GetTransportZoneDTO
    {
        public long TransportZoneId { get; set; }
        public string TransportZoneName { get; set; }
        public long BusinessUintid { get; set; }
        public string BusinessUintName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
