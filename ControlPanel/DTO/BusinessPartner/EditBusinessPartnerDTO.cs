using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessPartner
{
    public class EditBusinessPartnerDTO
    {
        [Required]
        public long BusinessPartnerId { get; set; }
        [Required]
        public string BusinessPartnerName { get; set; }
        [Required]
        public string BusinessPartnerAddress { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
