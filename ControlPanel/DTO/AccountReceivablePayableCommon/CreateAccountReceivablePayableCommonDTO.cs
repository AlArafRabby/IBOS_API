using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class CreateAccountReceivablePayableCommonDTO
    {
        public List<CreateAccountPayableRowDTO> AccountPayableRowList { get; set; }
        public List<CreateAccountReceivableRowDTO> AccountReceivableRowList { get; set; }
        public CreateAccountReceivablePayableHeaderDTO AccountReceivablePayableHeader { get; set; }
    }
}
