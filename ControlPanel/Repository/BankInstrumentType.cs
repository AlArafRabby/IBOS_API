using ControlPanel.DbContexts;
using ControlPanel.DTO.BankInstrumentType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BankInstrumentType : IBankInstrumentType
    {
        public readonly iBOSContext _context;
        public BankInstrumentType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBankInstrumentTypeAll()
        {
            
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Account Category List ",
                    data = await Task.FromResult((from a in _context.TblBankInstrumentType
                                                  where a.IsActive == true
                                                  select new GetBankInstrumentTypeDTO()
                                                  {
                                                      InstrumentId = a.IntInstrumentId,
                                                      InstrumentName=a.StrInstrumentName,
                                                      ActionBy=a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<Message> GetBankInstrumentTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Account Category List ",
                    data = await Task.FromResult((from a in _context.TblBankInstrumentType
                                                  where a.IsActive == true && a.IntInstrumentId == Id
                                                  select new GetBankInstrumentTypeDTO()
                                                  {
                                                      InstrumentId = a.IntInstrumentId,
                                                      InstrumentName = a.StrInstrumentName,
                                                      ActionBy = a.IntActionBy,
                                                      LastActionDateTime = a.DteLastActionDateTime

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
        public async Task<object> CreateBankInstrumentType(CreateBankInstrumentTypeDTO postBankInstrumentType)
        {
            try
            {
                var detalis = new TblBankInstrumentType
                {
                    StrInstrumentName = postBankInstrumentType.InstrumentName,
                    IntActionBy = postBankInstrumentType.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IsActive = true

                };
                await _context.TblBankInstrumentType.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblBankInstrumentType
                              where a.IsActive == true && a.IntInstrumentId == detalis.IntInstrumentId
                              select new GetBankInstrumentTypeDTO()
                              {
                                  InstrumentId = a.IntInstrumentId,
                                  InstrumentName = a.StrInstrumentName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Category Created Successfully.",
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
        public async Task<object> EditBankInstrumentType(EditBankInstrumentTypeDTO BankInstrumentType)
        {
            try
            {
                TblBankInstrumentType data = _context.TblBankInstrumentType.First(x => x.IntInstrumentId == BankInstrumentType.InstrumentId);
                data.StrInstrumentName = BankInstrumentType.InstrumentName;
                data.IntActionBy = BankInstrumentType.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                    

                _context.TblBankInstrumentType.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBankInstrumentType
                              where a.IsActive == true && a.IntInstrumentId == BankInstrumentType.InstrumentId
                              select new GetBankInstrumentTypeDTO()
                              {
                                  InstrumentId = a.IntInstrumentId,
                                  InstrumentName = a.StrInstrumentName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Category Edited Successfully.",
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
        public async Task<object> CancelBankInstrumentType(CancelBankInstrumentTypeDTO BankInstrumentType)
        {
            try
            {
                TblBankInstrumentType data = _context.TblBankInstrumentType.First(x => x.IntInstrumentId == BankInstrumentType.InstrumentId);

                data.IntActionBy = BankInstrumentType.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBankInstrumentType.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from a in _context.TblBankInstrumentType
                              where a.IsActive == false && a.IntInstrumentId == BankInstrumentType.InstrumentId
                              select new GetBankInstrumentTypeDTO()
                              {
                                  InstrumentId = a.IntInstrumentId,
                                  InstrumentName = a.StrInstrumentName,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Account Category Cancelled Successfully.",
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
