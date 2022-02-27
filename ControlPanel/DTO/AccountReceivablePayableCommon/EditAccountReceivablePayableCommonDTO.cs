using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountReceivablePayableCommon
{
    public class EditAccountReceivablePayableCommonDTO
    {
        public List<EditAccountPayableRowDTO> AccountPayableRowList { get; set; }
        public List<EditAccountReceivableRowDTO> AccountReceivableRowList { get; set; }
        public EditAccountReceivablePayableHeaderDTO AccountReceivablePayableHeader { get; set; }
    }
}
