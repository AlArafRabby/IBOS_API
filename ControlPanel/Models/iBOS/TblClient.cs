using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblClient
    {
        public long IntClientId { get; set; }
        public string StrClientCode { get; set; }
        public string StrClientName { get; set; }
        public string StrClientAddress { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
