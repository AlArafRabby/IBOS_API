using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemCategory
{
    public class CreateItemCategoryDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string ItemCategoryName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ItemTypeId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }    
    }
}
