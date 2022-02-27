using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesOrganization
{
    public class GetSalesOrganizationDTO
    {
        [Required]
        public long SalesOrganizationId { get; set; }
        public string SalesOrganizationCode { get; set; }
        public string SalesOrganizationName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessAreaId { get; set; }
        public string BusinessAreaName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
