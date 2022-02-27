using ControlPanel.DTO.AccountClass;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
  public  interface IAccountClass
    {
        Task<Message> GetAccountClassAll();
        Task<Message> GetAccountClassById(long Id);
        Task<Message> GetAccountClassByClientId(long CId);
        Task<object> CreateAccountClass(CreateAccountClassDTO postAccountClass);
        Task<object> EditAccountClass(EditAccountClassDTO AccountClass);
        Task<object> CancelAccountClass(CancelAccountClassDTO AccountClass);
    }
}
