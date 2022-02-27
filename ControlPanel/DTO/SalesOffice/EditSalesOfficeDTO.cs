using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOffice
{
    public class EditSalesOfficeDTO
    {
        [Required]
        public long SalesOfficeId { get; set; }
        [Required]
        public string SalesOfficeName { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
