using ControlPanel.DTO.CashJournalHeader;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ICashJournalHeader
    {
        Task<Message> GetCashJournalHeaderAll();
        Task<Message> GetCashJournalHeaderById(long Id);
        Task<Message> GetCashJournalHeaderByClientId(long CId);
        Task<object> CreateCashJournalHeader(CreateCashJournalHeaderDTO postCashJournalHeader);
        Task<object> EditCashJournalHeader(EditCashJournalHeaderDTO CashJournalHeader);
        Task<object> CancelCashJournalHeader(CancelCashJournalHeaderDTO CashJournalHeader); 
    }
}
