using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class CreateBusinessPartnerDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string BusinessPartnerCode { get; set; }
        [Required]
        public string BusinessPartnerName { get; set; }
        [Required]
        public string BusinessPartnerAddress { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string ContactNumber { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
