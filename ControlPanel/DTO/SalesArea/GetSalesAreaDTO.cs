using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SalesArea
{
    public class GetSalesAreaDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long DistributionChannelId { get; set; }
        public string DistributionChannelName { get; set; }
        public long ProductDivisionId { get; set; }
        public string ProductDivisionName { get; set; }
        public long SalesOrganizationId{ get; set; }
        public string SalesOrganizationname { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
