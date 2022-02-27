using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ProductDivision
{
    public class GetProductDivisionDTO
    {
        [Required]
        public long ProductDivisionId { get; set; }
        public string ProductDivisionCode { get; set; }
        public string ProductDivisionName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BusinessAreaId { get; set; }
        public string BusinessAreaName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
