using ControlPanel.DTO.BusinessUnitCurrency;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBusinessUnitCurrency
    {
        Task<Message> GetBusinessUnitCurrencyAll();
        Task<Message> GetBusinessUnitCurrencyById(long Id);
        Task<Message> GetBusinessUnitCurrencyByUnitId(long UId);
        Task<object> CreateBusinessUnitCurrency(CreateBusinessUnitCurrencyDTO postBusinessUnitCurrency);
        Task<object> EditBusinessUnitCurrency(EditBusinessUnitCurrencyDTO BusinessUnitCurrency);
        Task<object> CancelBusinessUnitCurrency(CancelBusinessUnitCurrencyDTO BusinessUnitCurrency);
    }
}
