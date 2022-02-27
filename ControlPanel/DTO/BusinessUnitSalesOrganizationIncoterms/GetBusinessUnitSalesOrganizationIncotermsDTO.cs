using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessUnitSalesOrganizationIncoterms
{
    public class GetBusinessUnitSalesOrganizationIncotermsDTO
    {   
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUintId { get; set; }
        public string BusinessUnitName { get; set; }
        public long IncotermsId { get; set; }
        public string IncotermsName { get; set; }
        public long SalesOrganizationId { get; set; }
        public string SalesOrganizationName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
