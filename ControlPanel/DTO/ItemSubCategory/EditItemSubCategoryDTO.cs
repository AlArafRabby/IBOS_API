using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemSubCategory
{
    public class EditItemSubCategoryDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string ItemSubCategoryName { get; set; }
        [Required]
        public long ItemTypeId { get; set; }
        [Required]
        public long ItemCategoryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
