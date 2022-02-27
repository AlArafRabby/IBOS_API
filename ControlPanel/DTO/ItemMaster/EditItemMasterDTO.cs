using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemMaster
{
    public class EditItemMasterDTO
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string ItemMasterName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
 
    }
}
