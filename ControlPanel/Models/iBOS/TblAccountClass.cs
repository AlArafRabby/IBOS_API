using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountClass
    {
        public long IntAccountClassId { get; set; }
        public long IntClientId { get; set; }
        public long IntAccountGroupId { get; set; }
        public string StrAccountClassCode { get; set; }
        public string StrAccountClassName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
