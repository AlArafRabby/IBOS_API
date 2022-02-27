using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AdjustmentJournalCommon
{
    public class CreateAdjustmentJournalCommonDTO
    {
        public List<CreateAdjustmentJournalRowDTO> AdjustmentJournalRowList { get; set; }
        public CreateAdjustmentJournalHeaderDTO AdjustmentJournalHeader { get; set; }
    }
}
