using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessUnitCurrency;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BusinessUnitCurrency : IBusinessUnitCurrency
    {
        public readonly iBOSContext _context;
        public BusinessUnitCurrency(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessUnitCurrencyAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Currency List ",
                    data = await Task.FromResult((from buc in _context.TblBusinessUnitCurrency
                                                  join bu in _context.TblBusinessUnit on buc.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join c in _context.TblCurrency on buc.IntCurrencyId equals c.IntCurrencyId
                                                  where buc.IsActive == true
                                                  select new GetBusinessUnitCurrencyDTO()
                                                  {
                                                      ConfigId = buc.IntConfigId,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      CurrencyId = c.IntCurrencyId,
                                                      CurrencyName = c.StrCurrencyName,
                                                      BaseCurrency = buc.IsBaseCurrency,
                                                      ActionBy = buc.IntActionBy,
                                                      LastActionDateTime = buc.DteLastActionDateTime

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetBusinessUnitCurrencyById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Unit Currency List By Id ",
                    data = await Task.FromResult((from buc in _context.TblBusinessUnitCurrency
                                                  join bu in _context.TblBusinessUnit on buc.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join c in _context.TblCurrency on buc.IntCurrencyId equals c.IntCurrencyId
                                                  where buc.IsActive == true && buc.IntConfigId ==Id
                                                  select new GetBusinessUnitCurrencyDTO()
                                                  {
                                                      ConfigId = buc.IntConfigId,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      CurrencyId = c.IntCurrencyId,
                                                      CurrencyName = c.StrCurrencyName,
                                                      BaseCurrency = buc.IsBaseCurrency,
                                                      ActionBy = buc.IntActionBy,
                                                      LastActionDateTime = buc.DteLastActionDateTime

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<Message> GetBusinessUnitCurrencyByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All  Business Unit Currency List By Unit Id ",
                    data = await Task.FromResult((from buc in _context.TblBusinessUnitCurrency
                                                  join bu in _context.TblBusinessUnit on buc.IntBusinessUnitId equals bu.IntBusinessUnitId
                                                  join c in _context.TblCurrency on buc.IntCurrencyId equals c.IntCurrencyId
                                                  where buc.IsActive == true && buc.IntBusinessUnitId == UId
                                                  select new GetBusinessUnitCurrencyDTO()
                                                  {
                                                      ConfigId = buc.IntConfigId,
                                                      BusinessUnitId = bu.IntBusinessUnitId,
                                                      BusinessUnitName = bu.StrBusinessUnitName,
                                                      CurrencyId = c.IntCurrencyId,
                                                      CurrencyName = c.StrCurrencyName,
                                                      BaseCurrency = buc.IsBaseCurrency,
                                                      ActionBy = buc.IntActionBy,
                                                      LastActionDateTime = buc.DteLastActionDateTime

                                                  }).ToList())
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    status = false,
                    message = "Error Data.",
                    errors = ex.Message
                };
            }
        }
        public async Task<object> CreateBusinessUnitCurrency(CreateBusinessUnitCurrencyDTO postBusinessUnitCurrency)
        {
            try
            {
                var detalis = new TblBusinessUnitCurrency
                {
                    IntBusinessUnitId = postBusinessUnitCurrency.BusinessUnitId,
                    IntCurrencyId = postBusinessUnitCurrency.CurrencyId,
                    IsBaseCurrency = postBusinessUnitCurrency.BaseCurrency,
                    IntActionBy = postBusinessUnitCurrency.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblBusinessUnitCurrency.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from buc in _context.TblBusinessUnitCurrency
                                  join bu in _context.TblBusinessUnit on buc.IntBusinessUnitId equals bu.IntBusinessUnitId
                                  join c in _context.TblCurrency on buc.IntCurrencyId equals c.IntCurrencyId
                                  where buc.IsActive == true && buc.IntConfigId == detalis.IntConfigId
                                  select new GetBusinessUnitCurrencyDTO()
                                  {
                                        ConfigId = buc.IntConfigId,
                                        BusinessUnitId = bu.IntBusinessUnitId,
                                        BusinessUnitName = bu.StrBusinessUnitName,
                                        CurrencyId = c.IntCurrencyId,
                                      CurrencyName = c.StrCurrencyName,
                                      BaseCurrency = buc.IsBaseCurrency,
                                        ActionBy = buc.IntActionBy,
                                        LastActionDateTime = buc.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = " Business Unit Currency Created Successfully.",
                    data = detalisView
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
        public async Task<object> EditBusinessUnitCurrency(EditBusinessUnitCurrencyDTO BusinessUnitCurrency)
        {
            try
            {
                TblBusinessUnitCurrency data = _context.TblBusinessUnitCurrency.First(x => x.IntConfigId == BusinessUnitCurrency.ConfigId);

                data.IntConfigId = BusinessUnitCurrency.ConfigId;
                data.IntBusinessUnitId = BusinessUnitCurrency.BusinessUnitId;
                data.IntCurrencyId = BusinessUnitCurrency.CurrencyId;
                data.IsBaseCurrency = BusinessUnitCurrency.BaseCurrency;
                data.IntActionBy = BusinessUnitCurrency.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBusinessUnitCurrency.Update(data);
                await _context.SaveChangesAsync();
                var detalis = from buc in _context.TblBusinessUnitCurrency
                              join bu in _context.TblBusinessUnit on buc.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join c in _context.TblCurrency on buc.IntCurrencyId equals c.IntCurrencyId
                              where buc.IsActive == true && buc.IntConfigId == BusinessUnitCurrency.ConfigId
                              select new GetBusinessUnitCurrencyDTO()
                              {
                                  ConfigId = buc.IntConfigId,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  CurrencyId = c.IntCurrencyId,
                                  CurrencyName = c.StrCurrencyName,
                                  BaseCurrency = buc.IsBaseCurrency,
                                  ActionBy = buc.IntActionBy,
                                  LastActionDateTime = buc.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = " Business Unit Currency Edited Successfully.",
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
        public async Task<object> CancelBusinessUnitCurrency(CancelBusinessUnitCurrencyDTO BusinessUnitCurrency)
        {
            try
            {
                TblBusinessUnitCurrency data = _context.TblBusinessUnitCurrency.First(x => x.IntConfigId == BusinessUnitCurrency.ConfigId);

                data.IntConfigId = BusinessUnitCurrency.ConfigId;
                data.IntActionBy = BusinessUnitCurrency.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblBusinessUnitCurrency.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from buc in _context.TblBusinessUnitCurrency
                              join bu in _context.TblBusinessUnit on buc.IntBusinessUnitId equals bu.IntBusinessUnitId
                              join c in _context.TblCurrency on buc.IntCurrencyId equals c.IntCurrencyId
                              where buc.IsActive == false && buc.IntConfigId == BusinessUnitCurrency.ConfigId
                              select new GetBusinessUnitCurrencyDTO()
                              {
                                  ConfigId = buc.IntConfigId,
                                  BusinessUnitId = bu.IntBusinessUnitId,
                                  BusinessUnitName = bu.StrBusinessUnitName,
                                  CurrencyId = c.IntCurrencyId,
                                  CurrencyName = c.StrCurrencyName,
                                  BaseCurrency = buc.IsBaseCurrency,
                                  ActionBy = buc.IntActionBy,
                                  LastActionDateTime = buc.DteLastActionDateTime

                              };



                var successmsg = new Message
                {
                    status = true,
                    message = " Business Unit Currency Cancelled Successfully.",
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
    }
}
