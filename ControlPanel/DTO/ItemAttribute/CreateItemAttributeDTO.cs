using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO
{
    public class CreateItemAttributeDTO
    {
        [Required]
        public string ItemAttributeName { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long ItemAttributeUom { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ItemCategoryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
