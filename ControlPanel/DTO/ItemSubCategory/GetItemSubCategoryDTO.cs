using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemSubCategory
{
    public class GetItemSubCategoryDTO
    {
        [Required]
        public long Id { get; set; }
        public string Code { get; set; }
        public string ItemSubCategoryName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ItemTypeId { get; set; }
        public string ItemTypeName { get; set; }
        public long ItemCategoryId { get; set; }
        public string ItemCategoryName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
