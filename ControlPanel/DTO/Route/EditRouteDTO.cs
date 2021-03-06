using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Route
{
    public class EditRouteDTO
    {
        public long RouteId { get; set; }
        public string RouteName { get; set; }
        public string RouteAddress { get; set; }
        public long ClientId { get; set; }
        public long BusinessUnitId { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
