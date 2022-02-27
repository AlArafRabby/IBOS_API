using System;
using System.Collections.Generic;

namespace Identity.Models.DB_Security
{
    public partial class TblUserTokenDetalis
    {
        public int IntId { get; set; }
        public int? IntRefTokenId { get; set; }
        public string StrUid { get; set; }
        public string StrToken { get; set; }
        public string StrRefreshToken { get; set; }
        public string StrStatus { get; set; }
        public DateTime? DteAction { get; set; }
    }
}
