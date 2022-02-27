using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessUnitSalesOrganizationIncoterms
{
    public class EditBusinessUnitSalesOrganizationIncotermsDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string ClientName { get; set; }
        [Required]
        public long BusinessUintId { get; set; }
        [Required]
        public string BusinessUnitName { get; set; }
        [Required]
        public long IncotermsId { get; set; }
        [Required]
        public string IncotermsName { get; set; }
        [Required]
        public long SalesOrganizationId { get; set; }
        [Required]
        public string SalesOrganizationName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
