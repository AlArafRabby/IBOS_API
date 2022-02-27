using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ItemSales
{
    public class GetItemSalesDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long SalesOrganizationId { get; set; }
        public string SalesOrganizationName { get; set; }
        public long ProductDivisionId { get; set; }
        public string ProductDivisionName { get; set; }
        public long ItemId { get; set; }
        public string ItemName { get; set; }
        public string SalesDescription { get; set; }
        public decimal MinOrderQuantity { get; set; }
        public decimal LotSize { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }

    }
}
