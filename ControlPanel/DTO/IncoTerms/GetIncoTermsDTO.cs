using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.IncoTerms
{
    public class GetIncoTermsDTO
    {
        public long IncotermsId { get; set; }
        public string IncotermsName { get; set; }
        public string IncotermsCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
