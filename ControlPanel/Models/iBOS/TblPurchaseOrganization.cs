using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblPurchaseOrganization
    {
        public long IntPurchaseOrganizationid { get; set; }
        public long IntClientId { get; set; }
        public string StrPurchaseOrganization { get; set; }
        public bool? IsActive { get; set; }
    }
}
