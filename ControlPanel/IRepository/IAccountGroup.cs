using ControlPanel.DTO.AccountGroup;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IAccountGroup
    {
        Task<Message> GetAccountGroupAll();
        Task<Message> GetAccountGroupById(long Id);
        Task<Message> GetAccountGroupByClientId(long CId);
        Task<object> CreateAccountGroup(CreateAccountGroupDTO postAccountGroup);
        Task<object> EditAccountGroup(EditAccountGroupDTO AccountGroup);
        Task<object> CancelAccountGroup(CancelAccountGroupDTO AccountGroup);
    }
}
