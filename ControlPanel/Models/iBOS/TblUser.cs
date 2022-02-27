using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblUser
    {
        public long IntUserId { get; set; }
        public long IntClientId { get; set; }
        public string StrUserName { get; set; }
        public string StrLoginId { get; set; }
        public string StrPassword { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
