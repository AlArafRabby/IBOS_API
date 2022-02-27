using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.BusinessUnitCurrencyConversion;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BusinessUnitCurrencyConversion : IBusinessUnitCurrencyConversion
    {
        public readonly iBOSContext _context;

        public BusinessUnitCurrencyConversion(iBOSContext context)
        {
            _context = context;
        }

        public async Task<object> CancelBusinessUnitCurrencyConversion(CancelBusinessUnitCurrencyConversionDTO BusinessUnitCurrencyConversion)
        {
            try
            {
                TblBusinessUnitCurrencyConversion data = _context.TblBusinessUnitCurrencyConversion.First(x => x.IntConfigId == BusinessUnitCurrencyConversion.ConfigId);

                data.IntActionBy = BusinessUnitCurrencyConversion.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessUnitCurrencyConversion.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from u in _context.TblBusinessUnitCurrencyConversion
                              join Unit in _context.TblBusinessUnit on u.IntBusinessUnitId equals Unit.IntBusinessUnitId
                              where u.IsActive == false && u.IntConfigId == BusinessUnitCurrencyConversion.ConfigId
                              select new GetBusinessUnitCurrencyConversionDTO
                              {
                                  ConfigId = u.IntConfigId,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = Unit.StrBusinessUnitName,
                                  BaseCurrencyId = u.IntBaseCurrencyId,
                                  AlternateCurrencyId = u.IntAlternateCurrencyId,
                                  ConversionRate = u.NumConversionRate,
                                  ActionBy = u.IntActionBy,
                                  LastActionDateTime = u.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Unit Cancelled Successfully.",
                    data = detalis
                };

                return successmsg;
            }
            catch (Exception ex)
            {
                var errormsg = new Message
                {
                    status = false,
                    message = "The given data was invalid.",
                    errors = ex.Message
                };
                return errormsg;
            }
        }

        public Task<object> CreateBusinessUnitCurrencyConversion(CreateBusinessUnitCurrencyConversionDTO postBusinessUnitCurrencyConversion)
        {
            throw new NotImplementedException();
        }

        public Task<object> EditBusinessUnitCurrencyConversion(EditBusinessUnitCurrencyConversionDTO BusinessUnitCurrencyConversion)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetBusinessUnitCurrencyConversionAll()
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetBusinessUnitCurrencyConversionByAlternateCurrencyId(long ACId)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetBusinessUnitCurrencyConversionByBaseCurrencyId(long BCId)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetBusinessUnitCurrencyConversionById(long Id)
        {
            throw new NotImplementedException();
        }

        public Task<Message> GetBusinessUnitCurrencyConversionByUnitId(long UId)
        {
            throw new NotImplementedException();
        }
    }
}
