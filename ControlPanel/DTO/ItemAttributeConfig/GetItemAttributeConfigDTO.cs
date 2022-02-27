using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemAttributeConfig
{
    public class GetItemAttributeConfigDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long ItemMasterId { get; set; }
        public string ItemMastername { get; set; }
        public long AttributeId { get; set; }
        public string AttributeName { get; set; }
        public string AttributeUom { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
