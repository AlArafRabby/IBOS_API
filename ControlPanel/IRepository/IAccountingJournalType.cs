using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IAccountingJournalType
    {
        Task<Message> GetAccountingJournalTypeAll();
        Task<Message> GetAccountingJournalTypeById(long Id);
    }
}
