using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PurchaseOrganization
{
    public class GetPurchaseOrganizationDTO
    {   
        [Required]
        public long PurchaseOrganizationid { get; set; }
        public string PurchaseOrganization { get; set; }
        public long ClientId { get; set; }
        public string ClinetName { get; set; }
        public bool? IsActive { get; set; }
    }
}
