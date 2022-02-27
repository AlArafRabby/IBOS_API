using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountGroup
{
    public class GetAccountGroupDTO
    {
        [Required]
        public long AccountGroupId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public string AccountGroupCode { get; set; }
        public string AccountGroupName { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
