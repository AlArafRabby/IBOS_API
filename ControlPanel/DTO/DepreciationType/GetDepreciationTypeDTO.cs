using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.DepreciationType
{
    public class GetDepreciationTypeDTO
    {   
        [Required]
        public long DepreciationId { get; set; }
        public string DepreciationName { get; set; }
    }
}
