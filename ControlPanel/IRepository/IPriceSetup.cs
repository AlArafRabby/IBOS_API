using ControlPanel.DTO.PriceSetup;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
  public  interface IPriceSetup
    {
        Task<Message> GetPriceSetupById(long Id);
        Task<Message> GetPriceSetupByUnitId(long UId, DateTime fromDate, DateTime Todate);
        Task<Message> GetPriceSetupClientId(long CId, DateTime fromDate, DateTime Todate);
        Task<object> CreatePriceSetup(CreatePriceSetupDTO postPriceSetup);
        Task<object> CancelPriceSetup(CancelPriceSetupDTO PriceSetup);
    }
}
