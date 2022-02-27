using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblTransportZone
    {
        public long IntTransportZoneId { get; set; }
        public string StrTransportZoneName { get; set; }
        public long IntBusinessUintid { get; set; }
        public long IntClientId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
