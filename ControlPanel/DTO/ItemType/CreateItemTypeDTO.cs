using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace ControlPanel.DTO.ItemType
{
    public class CreateItemTypeDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public string ItemTypeName { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
