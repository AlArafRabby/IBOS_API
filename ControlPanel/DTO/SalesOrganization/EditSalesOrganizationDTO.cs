using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOrganization
{
    public class EditSalesOrganizationDTO
    {
        [Required]
        public long SalesOrganizationId { get; set; }
        [Required]
        public string SalesOrganizationName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
