using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PaymentTerms
{
    public class GetPaymentTermsDTO
    {
        public long PaymentTerms { get; set; }
        public string PaymentTermsName { get; set; }
        public string PaymentTermsCode { get; set; }
        public bool? IsActive { get; set; }
    }
}
