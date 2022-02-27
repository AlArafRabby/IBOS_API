using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.UnitOfMeasurement
{
    public class GetUnitOfMeasurementDTO
    {
        public long Uomid { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public string Uomname { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
