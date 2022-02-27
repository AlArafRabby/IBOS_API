using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblTransportMode
    {
        public long IntTransportModeId { get; set; }
        public string StrTransportModeName { get; set; }
        public bool? IsActive { get; set; }
    }
}
