using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountGroup
    {
        public long IntAccountGroupId { get; set; }
        public long IntClientId { get; set; }
        public string StrAccountGroupCode { get; set; }
        public string StrAccountGroupName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
