using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.Helper
{
    public class RenewToken
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public string UID { get; set; }
    }
}
