using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemSales
{
    public class CreateItemSalesDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long SalesOrganizationId { get; set; }
        [Required]
        public long ProfitCenterId { get; set; }
        [Required]
        public long ProductDivisionId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public string SalesDescription { get; set; }
        [Required]
        public decimal MinOrderQuantity { get; set; }
        [Required]
        public decimal LotSize { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
