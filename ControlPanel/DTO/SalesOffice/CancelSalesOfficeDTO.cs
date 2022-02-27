using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOffice
{
    public class CancelSalesOfficeDTO
    {
        [Required]
        public long SalesOfficeId { get; set; }
        public long ActionBy { get; set; }
    }
}
