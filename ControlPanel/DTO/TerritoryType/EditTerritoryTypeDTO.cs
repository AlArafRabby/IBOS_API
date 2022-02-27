using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.TerritoryType
{
    public class EditTerritoryTypeDTO
    {
        [Required]
        public long TerritoryTypeId { get; set; }
        [Required]
        public string TerritoryTypeName { get; set; }
        [Required]
        public long levelPosition { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
