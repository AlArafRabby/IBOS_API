using ControlPanel.DbContexts;
using ControlPanel.DTO.Bank;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class Bank : IBank
    {
        public readonly iBOSContext _context;
        public Bank(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBankAll()
        {
            try
            {

                return new Message
                {
                    status = true,
                    message = "All Bank List .",
                    data = await _context.TblBank.Where(x => x.IsActive == true).Select(t => new GetBankDTO()
                    {
                        BankId = t.IntBankId,
                        BankName = t.StrBankName,
                        BankCode = t.StrBankCode,
                        ActionBy = t.IntActionBy,
                        LastActionDateTime = t.DteLastActionDateTime

                    }).ToListAsync()
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
        public async Task<Message> GetBankById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Bank List by ID.",
                    data = await _context.TblBank.Where(x => x.IsActive == true && x.IntBankId == Id).Select(t => new GetBankDTO()
                    {
                        BankId = t.IntBankId,
                        BankName = t.StrBankName,
                        BankCode = t.StrBankCode,
                        ActionBy = t.IntActionBy,
                        LastActionDateTime = t.DteLastActionDateTime

                    }).ToListAsync()
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
        public async Task<object> CreateBank(CreateBankDTO postBank)
        {
            try
            {
                var detalis = new TblBank
                {
                    StrBankName = postBank.BankName,
                    StrBankCode = postBank.BankName.Substring(0,3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    IntActionBy = postBank.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblBank.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = new GetBankDTO
                {
                    BankId = detalis.IntBankId,
                    BankName = detalis.StrBankName,
                    BankCode = detalis.StrBankCode,
                    ActionBy = detalis.IntActionBy,
                    LastActionDateTime = detalis.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Created Successfully.",
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
        public async Task<object> EditBank(EditBankDTO Bank)
        {
            try
            {
                TblBank data = _context.TblBank.First(x => x.IntBankId == Bank.BankId);
                data.StrBankName = Bank.BankName;
                data.IntActionBy = Bank.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblBank.Update(data);
                await _context.SaveChangesAsync();

                var detalis = new GetBankDTO
                {
                    BankId = data.IntBankId,
                    BankName = data.StrBankName,
                    BankCode = data.StrBankCode,
                    ActionBy = data.IntActionBy,
                    LastActionDateTime = data.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Edited Successfully.",
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
        public async Task<object> CancelBank(CancelBankDTO Bank)
        {
            try
            {
                TblBank data = _context.TblBank.First(x => x.IntBankId == Bank.BankId);

                data.IntActionBy = Bank.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBank.Update(data);
                await _context.SaveChangesAsync();

                var detalis = new GetBankDTO
                {
                    BankId = data.IntBankId,
                    BankName = data.StrBankName,
                    BankCode = data.StrBankCode,
                    ActionBy = data.IntActionBy,
                    LastActionDateTime = data.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Bank Cancelled Successfully.",
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
