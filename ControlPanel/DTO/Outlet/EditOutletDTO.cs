using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Outlet
{
    public class EditOutletDTO
    {
        [Required]
        public long OutletId { get; set; }
        [Required]
        public string OutletName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
