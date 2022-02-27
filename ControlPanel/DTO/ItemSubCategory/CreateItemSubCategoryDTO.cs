using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemSubCategory
{
    public class CreateItemSubCategoryDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string ItemSubCategoryName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ItemTypeId { get; set; }
        [Required]
        public long ItemCategoryId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
