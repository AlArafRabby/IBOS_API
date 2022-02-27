using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblItemPurchase
    {
        public long IntConfigId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntPlantId { get; set; }
        public long IntPurchaseOrganizationId { get; set; }
        public long IntItemId { get; set; }
        public string StrPurchaseDescription { get; set; }
        public string StrHscode { get; set; }
        public decimal NumMaxLeadDays { get; set; }
        public decimal NumMinLeadDays { get; set; }
        public decimal NumMinOrderQuantity { get; set; }
        public decimal NumLotSize { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
