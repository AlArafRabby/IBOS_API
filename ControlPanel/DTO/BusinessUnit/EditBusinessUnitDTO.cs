using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class EditBusinessUnitDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }        
        public string Address { get; set; }
        public long ActionBy { get; set; }
    }
}
