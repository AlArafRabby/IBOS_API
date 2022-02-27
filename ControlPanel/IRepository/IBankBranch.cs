using ControlPanellNew.Helper;
using ControlPanel.DTO.BankBranch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBankBranch
    {
        Task<Message> GetBankBranchAll();
        Task<Message> GetBankBranchById(long Id);
        Task<object> CreateBankBranch(CreateBankBranchDTO postBankBranch);
        Task<object> EditBankBranch(EditBankBranchDTO BankBranch);
        Task<object> CancelBankBranch(CancelBankBranchDTO BankBranch);
    }
}
