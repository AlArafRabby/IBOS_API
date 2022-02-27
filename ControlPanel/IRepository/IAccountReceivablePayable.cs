using ControlPanel.DTO.AccountReceivablePayable;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
  public  interface IAccountReceivablePayable
    {
        Task<Message> GetAccountReceivablePayablebyClientIdBusinessUnitId(long ClientId, long BusinessUnitId);       
        Task<object> CreateAccountReceivablePayableVoucher(CreateAccountReceivablePayableDTO postCreateAccountReceivablePayable);
       
    }
}
