using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemAttribute
{
    public class GetItemAttributeDTO
    {
        [Required]
        public long Id { get; set; }
        public string ItemAttributeName { get; set; }
        public string ItemAttributeUoMName { get; set; }
        public long ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public DateTime LastActionDateTime { get; set; } 
    }
}
