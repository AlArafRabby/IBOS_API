using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSoldToPartnerShipToPartner
    {
        public long IntConfigId { get; set; }
        public long IntClientId { get; set; }
        public long IntSoldToPartnerId { get; set; }
        public string StrSoldToPartnerName { get; set; }
        public long IntShipToPartnerId { get; set; }
        public string StrShipToPartnerName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
