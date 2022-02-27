using ControlPanel.DTO.BankJournalHeader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankJournalHeader
{
    public class EditBankJournalHeaderCommonDTO
    {
        public List<EditBankJournalRowDTO> bankJournalRow { get; set; }
        public EditBankJournalHeaderDTO bankJournalHeader { get; set; }
    }
}
