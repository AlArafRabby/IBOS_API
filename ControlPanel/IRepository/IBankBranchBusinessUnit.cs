using ControlPanel.DTO.BankBranchBusinessUnit;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBankBranchBusinessUnit
    {
        Task<Message> GetBankBranchBusinessUnitAll();
        Task<Message> GetBankBranchBusinessUnitById(long Id);
        Task<Message> GetBankBranchBusinessUnitByUnitId(long UId);
        Task<Message> GetBankBranchBusinessUnitByClientId(long CId);
        Task<object> CreateBankBranchBusinessUnit(CreateBankBranchBusinessUnitDTO postBankBranchBusinessUnit);
        Task<object> EditBankBranchBusinessUnit(EditBankBranchBusinessUnitDTO BankBranchBusinessUnit);
        Task<object> CancelBankBranchBusinessUnit(CancelBankBranchBusinessUnitDTO BankBranchBusinessUnit);
    }
}
