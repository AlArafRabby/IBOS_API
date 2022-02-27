using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartner
{
    public class GetBusinessPartnerDTO
    {
        [Required]
        public long BusinessPartnerId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public string BusinessPartnerCode { get; set; }
        public string BusinessPartnerName { get; set; }
        public string BusinessPartnerAddress { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
