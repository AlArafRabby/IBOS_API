using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.RoundingType
{
    public class GetRoundingTypeDTO
    {
        [Required]
        public long RoundingTypeId { get; set; }
        public string RoundingTypeName { get; set; }
    }
}
