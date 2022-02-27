using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblIncoTerms
    {
        public long IntIncotermsId { get; set; }
        public string StrIncotermsName { get; set; }
        public string StrIncotermsCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
