using System;
using System.Collections.Generic;

namespace Identity.Models.DB_Security
{
    public partial class TblUserToken
    {
        public int IntId { get; set; }
        public Guid? StrUid { get; set; }
        public string StrEmail { get; set; }
        public string StrDomain { get; set; }
        public string StrToken { get; set; }
        public string StrRefreshToken { get; set; }
        public bool? YsnEnable { get; set; }
        public DateTime? DteAction { get; set; }
        public DateTime? DteLastActionTime { get; set; }
        public bool? YsnUsed { get; set; }
        public string StrPassword { get; set; }
    }
}
