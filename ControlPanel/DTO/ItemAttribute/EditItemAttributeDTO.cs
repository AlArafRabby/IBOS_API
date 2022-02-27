using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemAttribute
{
    public class EditItemAttributeDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string ItemAttributeName { get; set; }
        [Required]
        public long ItemAttributeUom { get; set; }
        [Required]
        public long ItemCategoryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
