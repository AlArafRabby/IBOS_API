using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblDivision
    {
        public long IntDivisionId { get; set; }
        public string StrDivition { get; set; }
        public long IntCountryId { get; set; }
        public string StrCountryName { get; set; }
        public bool IsActive { get; set; }
        public string StrDivitionBanglaName { get; set; }
    }
}
