using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemCategory
{
    public class EditItemCategoryDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string ItemCategoryName { get; set; }
        [Required]
        public long ItemTypeId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
