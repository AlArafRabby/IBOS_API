using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class CreateBusinessUnitDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long ClientId { get; set; }
        public long ActionBy { get; set; }
        public DateTime dteLastActionDateTime { get; set; }
    }
}
