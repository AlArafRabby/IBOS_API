using ControlPanel.DTO.BusinessUnitCurrencyConversion;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessUnitCurrencyConversion
    {
        Task<Message> GetBusinessUnitCurrencyConversionAll();
        Task<Message> GetBusinessUnitCurrencyConversionById(long Id);
        Task<Message> GetBusinessUnitCurrencyConversionByUnitId(long UId);
        Task<Message> GetBusinessUnitCurrencyConversionByBaseCurrencyId(long BCId);
        Task<Message> GetBusinessUnitCurrencyConversionByAlternateCurrencyId(long ACId);
        Task<object> CreateBusinessUnitCurrencyConversion(CreateBusinessUnitCurrencyConversionDTO postBusinessUnitCurrencyConversion);
        Task<object> EditBusinessUnitCurrencyConversion(EditBusinessUnitCurrencyConversionDTO BusinessUnitCurrencyConversion);
        Task<object> CancelBusinessUnitCurrencyConversion(CancelBusinessUnitCurrencyConversionDTO BusinessUnitCurrencyConversion);
    }
}
