using ControlPanel.DbContexts;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BankJournalRow : IBankJournalRow
    {
        public Task<Message> BankJournalDetailsId(long VoucherId)
        {
            throw new NotImplementedException();
        }

        public Task<object> CreateBankJournalRowVoucher()
        {
            throw new NotImplementedException();
        }

        public Task<object> EditBankJournalRowVoucher()
        {
            throw new NotImplementedException();
        }
    }
}
