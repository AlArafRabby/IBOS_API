using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblCountry
    {
        public long IntCountryId { get; set; }
        public long IntClientId { get; set; }
        public string StrCountryCode { get; set; }
        public string StrCountryName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
