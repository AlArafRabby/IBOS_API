using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class EditAdjustmentJournalCommonDTO
    {
        public List<EditAdjustmentJournalRowDTO> AdjustmentJournalRowList { get; set; }
        public EditAdjustmentJournalHeaderDTO AdjustmentJournalHeader { get; set; }        
    }
}
