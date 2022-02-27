using ControlPanel.DTO.BankJournalHeader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class CreateBankJournalHeaderCommonDTO
    {
        public List<CreateBankJournalRowDTO> bankJournalRow { get; set; }

        public CreateBankJournalHeaderDTO bankJournalHeader { get; set; }
    }
}
