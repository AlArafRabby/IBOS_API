using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountClass
{
    public class GetAccountClassDTO
    {
        [Required]
        public long AccountClassId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long AccountGroupId { get; set; }
        public string AccountGroupName { get; set; }
        public string AccountClassCode { get; set; }
        public string AccountClassName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
