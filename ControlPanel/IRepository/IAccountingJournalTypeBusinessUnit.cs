using ControlPanel.DTO.AccountingJournalTypeBusinessUnit;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IAccountingJournalTypeBusinessUnit
    {
        Task<Message> GetAccountingJournalTypeBusinessUnitAll();
        Task<Message> GetAccountingJournalTypeBusinessUnitById(long Id);
        Task<Message> GetAccountingJournalTypeBusinessUnitByClientId(long CId);
        Task<Message> GetAccountingJournalTypeBusinessUnitByUnitId(long UId);
        Task<object> CreateAccountingJournalTypeBusinessUnit(CreateAccountingJournalTypeBusinessUnitDTO postAccountingJournalTypeBusinessUnit);
        Task<object> EditAccountingJournalTypeBusinessUnit(EditAccountingJournalTypeBusinessUnitDTO AccountingJournalTypeBusinessUnit);
        Task<object> CancelAccountingJournalTypeBusinessUnit(CancelAccountingJournalTypeBusinessUnitDTO AccountingJournalTypeBusinessUnit);
    }
}
