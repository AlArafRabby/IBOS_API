using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOrganization
{
    public class CreateSalesOrganizationDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string SalesOrganizationCode { get; set; }
        [Required]
        public string SalesOrganizationName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BusinessAreaId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
