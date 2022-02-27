using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Outlet
{
    public class GetOutletDTO
    {
        [Required]
        public long OutletId { get; set; }
        public string OutletCode { get; set; }
        public string OutletName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
