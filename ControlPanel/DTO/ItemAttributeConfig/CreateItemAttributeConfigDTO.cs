using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemAttributeConfig
{
    public class CreateItemAttributeConfigDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ItemMasterId { get; set; }
        [Required]
        public long AttributeId { get; set; }
        [Required]
        public string AttributeName { get; set; }
        [Required]
        public string AttributeUom { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public DateTime ServerDateTime { get; set; }
    }
}
