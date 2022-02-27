using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblThana
    {
        public long IntThanaId { get; set; }
        public string StrThanaName { get; set; }
        public long IntDistrictId { get; set; }
        public string StrThanaBanglaName { get; set; }
        public long IntGeocode { get; set; }
        public bool? IsActive { get; set; }
    }
}
