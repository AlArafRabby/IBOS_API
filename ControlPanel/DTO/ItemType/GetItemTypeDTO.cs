using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemType
{
    public class GetItemTypeDTO
    {
        [Required]
        public long Id { get; set; }
        public string ItemTypeName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public long ActionBy { get; set; }
    }
}
