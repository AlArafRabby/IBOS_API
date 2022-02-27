using ControlPanel.DTO.BankAccount;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBankAccount
    {
        Task<Message> GetBankAccountAll();
        Task<Message> GetBankAccountById(long Id);
        Task<Message> GetBankAccountByClientId(long CId);
        Task<Message> GetBankAccountByUnitId(long UId);
        Task<object> CreateBankAccount(CreateBankAccountDTO postBankAccount);
        Task<object> EditBankAccount(EditBankAccountDTO BankAccount);
        Task<object> CancelBankAccount(CancelBankAccountDTO BankAccount);
    }
}
