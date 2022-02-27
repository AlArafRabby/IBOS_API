using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class GetBusinessUnitDTO
    {
        [Required]
        public long Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime dteLastActionDateTime { get; set; }
    }
}
