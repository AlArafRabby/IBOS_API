using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblDistrict
    {
        public long IntDistrictId { get; set; }
        public long IntClientId { get; set; }
        public string StrDistrictCode { get; set; }
        public string StrDistrictName { get; set; }
        public long IntCountryId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
