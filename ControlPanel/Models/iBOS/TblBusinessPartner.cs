using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessPartner
    {
        public long IntBusinessPartnerId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public string StrBusinessPartnerCode { get; set; }
        public string StrBusinessPartnerName { get; set; }
        public string StrBusinessPartnerAddress { get; set; }
        public string StrContactNumber { get; set; }
        public string StrEmail { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
