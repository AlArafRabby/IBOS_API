using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBankJournalRow
    {
        Task<Message> BankJournalDetailsId(long VoucherId);
        Task<object> CreateBankJournalRowVoucher();
        Task<object> EditBankJournalRowVoucher();
    }
}
