using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PriceConditionTypeOrganization
{
    public class GetPriceConditionTypeOrganizationDTO
    {
        [Required]
        public long PriceConditionTypeId { get; set; }
        public string PriceConditionTypeName { get; set; }
        public string PriceConditionTypeCode { get; set; }
        public long? AccessSequence { get; set; }
    }
}
