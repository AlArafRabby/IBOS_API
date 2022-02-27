using ControlPanel.DbContexts;
using ControlPanel.DTO.BankBranch;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class BankBranch : IBankBranch
    {
        public readonly iBOSContext _context;
        public BankBranch(iBOSContext context)
        {
            _context = context;
        }

        public async Task<Message> GetBankBranchAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All  Bank Branch List ",
                    data = await Task.FromResult((from bb in _context.TblBankBranch
                                                  join c in _context.TblCountry on bb.IntCountryId equals c.IntCountryId
                                                  join b in _context.TblBank on bb.IntBankId equals b.IntBankId
                                                  where bb.IsActive == true
                                                  select new GetBankBranchDTO()
                                                  {
                                                      BankBranchId = bb.IntBankBranchId,
                                                      BankBranchCode = bb.StrBankBranchCode,
                                                      BankBranchName = bb.StrBankBranchName,
                                                      BankBranchAddress = bb.StrBankBranchAddress,
                                                      CountryId = c.IntCountryId,
                                                      CountryName = c.StrCountryName,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      ActionBy = bb.IntActionBy,
                                                      LastActionDateTime = bb.DteLastActionDateTime

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
        public async Task<Message> GetBankBranchById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All  Bank Branch List by Id ",
                    data = await Task.FromResult((from bb in _context.TblBankBranch
                                                  join c in _context.TblCountry on bb.IntCountryId equals c.IntCountryId
                                                  join b in _context.TblBank on bb.IntBankId equals b.IntBankId
                                                  where bb.IsActive == true && bb.IntBankId==Id
                                                  select new GetBankBranchDTO()
                                                  {
                                                      BankBranchId = bb.IntBankBranchId,
                                                      BankBranchCode = bb.StrBankBranchCode,
                                                      BankBranchName = bb.StrBankBranchName,
                                                      BankBranchAddress = bb.StrBankBranchAddress,
                                                      CountryId = c.IntCountryId,
                                                      CountryName = c.StrCountryName,
                                                      BankId = b.IntBankId,
                                                      BankName = b.StrBankName,
                                                      ActionBy = bb.IntActionBy,
                                                      LastActionDateTime = bb.DteLastActionDateTime

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
        public async Task<object> CreateBankBranch(CreateBankBranchDTO postBankBranch)
        {
            try
            {
                var detalis = new TblBankBranch
                {
                    StrBankBranchName= postBankBranch.BankBranchName,
                    StrBankBranchCode = postBankBranch.BankBranchName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrBankBranchAddress = postBankBranch.BankBranchAddress,
                    IntCountryId = postBankBranch.CountryId,
                    IntBankId = postBankBranch.BankId,
                    IntActionBy = postBankBranch.ActionBy,
                    IsActive = true,
                    DteLastActionDateTime = DateTime.UtcNow

                };
                await _context.TblBankBranch.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bb in _context.TblBankBranch
                              join c in _context.TblCountry on bb.IntCountryId equals c.IntCountryId
                              join b in _context.TblBank on bb.IntBankId equals b.IntBankId
                              where bb.IsActive == true && bb.IntBankBranchId == detalis.IntBankBranchId
                              select new GetBankBranchDTO()
                              {
                                  BankBranchId = bb.IntBankBranchId,
                                  BankBranchCode = bb.StrBankBranchCode,
                                  BankBranchName = bb.StrBankBranchName,
                                  BankBranchAddress = bb.StrBankBranchAddress,
                                  CountryId = c.IntCountryId,
                                  CountryName = c.StrCountryName,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  ActionBy = bb.IntActionBy,
                                  LastActionDateTime = bb.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = " Bank Branch Created Successfully.",
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
        public async Task<object> EditBankBranch(EditBankBranchDTO BankBranch)
        {
            try
            {
                TblBankBranch data = _context.TblBankBranch.First(x => x.IntBankBranchId == BankBranch.BankBranchId);

                data.StrBankBranchCode = BankBranch.BankBranchCode;
                data.StrBankBranchName = BankBranch.BankBranchName;
                data.StrBankBranchAddress = BankBranch.BankBranchAddress;
                data.IntBankId = BankBranch.BankId;
                data.IntActionBy = BankBranch.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBankBranch.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bb in _context.TblBankBranch
                              join c in _context.TblCountry on bb.IntCountryId equals c.IntCountryId
                              join b in _context.TblBank on bb.IntBankId equals b.IntBankId
                              where bb.IsActive == true && bb.IntBankBranchId == BankBranch.BankBranchId
                              select new GetBankBranchDTO()
                              {
                                  BankBranchId = bb.IntBankBranchId,
                                  BankBranchCode = bb.StrBankBranchCode,
                                  BankBranchName = bb.StrBankBranchName,
                                  BankBranchAddress = bb.StrBankBranchAddress,
                                  CountryId = c.IntCountryId,
                                  CountryName = c.StrCountryName,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  ActionBy = bb.IntActionBy,
                                  LastActionDateTime = bb.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = " Bank Branch Edited Successfully.",
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
        public async Task<object> CancelBankBranch(CancelBankBranchDTO BankBranch)
        {
            try
            {
                TblBankBranch data = _context.TblBankBranch.First(x => x.IntBankBranchId == BankBranch.BankBranchId);

                data.IntBankBranchId = BankBranch.BankBranchId;
                data.IntActionBy = BankBranch.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBankBranch.Update(data);
                await _context.SaveChangesAsync();
                var detalis = from bb in _context.TblBankBranch
                              join c in _context.TblCountry on bb.IntCountryId equals c.IntCountryId
                              join b in _context.TblBank on bb.IntBankId equals b.IntBankId
                              where bb.IsActive == false && bb.IntBankBranchId == BankBranch.BankBranchId
                              select new GetBankBranchDTO()
                              {
                                  BankBranchId = bb.IntBankBranchId,
                                  BankBranchCode = bb.StrBankBranchCode,
                                  BankBranchName = bb.StrBankBranchName,
                                  BankBranchAddress = bb.StrBankBranchAddress,
                                  CountryId = c.IntCountryId,
                                  CountryName = c.StrCountryName,
                                  BankId = b.IntBankId,
                                  BankName = b.StrBankName,
                                  ActionBy = bb.IntActionBy,
                                  LastActionDateTime = bb.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = " Bank Branch Cancelled Successfully.",
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
