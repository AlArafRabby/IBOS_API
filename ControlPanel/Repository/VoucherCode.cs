using ControlPanel.DbContexts;
using ControlPanel.DTO.AccountingJournalCodeGenerator;
using ControlPanel.DTO.AccountingJournalTypeBusinessUnit;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class VoucherCode : IVoucherCode
    {
        public readonly iBOSContext _context;
        public readonly AccountingJournalCodeGenerator _context1;
        public VoucherCode(iBOSContext context, AccountingJournalCodeGenerator context1)
        {
            _context = context;
            _context1 = context1;
        }

        public AccountingJournalCodeGenerator _AccountingJournalCodeGenerator;

        public async Task<string> GetVoucherCode(long ClientId, long BusinessUnitId, long AccountingJournalTypeId)
        {
            string voucherCode = string.Empty;
            try
            {
                var _AccountingJournalType = (from a in _context.TblAccountingJournalType
                                              where a.IntAccountingJournalTypeId == AccountingJournalTypeId
                                              select a).SingleOrDefault();

                var _AccountingJournalTypeBusinessUnit = (from a in _context.TblAccountingJournalTypeBusinessUnit
                                                          join cl in _context.TblClient on a.IntClientId equals cl.IntClientId
                                                          join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                          join t in _context.TblAccountingJournalType on a.IntAccountingJournalTypeId equals t.IntAccountingJournalTypeId
                                                          where a.IsActive == true && a.IntClientId == ClientId && a.IntAccountingJournalTypeId == AccountingJournalTypeId
                                                                && a.IntBusinessUnitId == BusinessUnitId
                                                          select a).Single();

                TblAccountingJournalCodeGenerator _tblAccountingJournalCodeGenerator = (from g in _context.TblAccountingJournalCodeGenerator
                                                                                        where g.IntClientId == ClientId && g.IntAccountingJournalTypeId == AccountingJournalTypeId
                                                                                                && g.IntBusinessUintId == BusinessUnitId
                                                                                        select g).SingleOrDefault();

                if (_tblAccountingJournalCodeGenerator == null)
                {
                    CreateAccountingJournalCodeGenerator objAccountingJournalCodeGenerator = new CreateAccountingJournalCodeGenerator
                    {
                        ClientId = ClientId,
                        BusinessUintId = BusinessUnitId,
                        AccountingJournalTypeId = AccountingJournalTypeId,
                        AccountingJournalTypeName = _AccountingJournalType.StrAccountingJournalTypeName,
                        Year = DateTime.Now.Year,
                        Month = DateTime.Now.Month,
                        Count = 1
                    };
                    var dtAccountingJournalCodeGenerator = await _context1.CreateAccountingJournalCodeGenerator(objAccountingJournalCodeGenerator);

                    _tblAccountingJournalCodeGenerator = (from g in _context.TblAccountingJournalCodeGenerator
                                                          where g.IntClientId == ClientId && g.IntAccountingJournalTypeId == AccountingJournalTypeId
                                                                  && g.IntBusinessUintId == BusinessUnitId
                                                          select g).SingleOrDefault();
                }

                Char pad = '0';
                voucherCode = _AccountingJournalTypeBusinessUnit.StrPrefix + _tblAccountingJournalCodeGenerator.IntYear.ToString();
                string countValue = _tblAccountingJournalCodeGenerator.IntCount.ToString();

                if (_AccountingJournalTypeBusinessUnit.IsMonth)
                {
                    string monthValue = _tblAccountingJournalCodeGenerator.IntMonth.ToString();
                    if (monthValue.Length == 1)
                        monthValue = "0" + monthValue.Length;

                    voucherCode = voucherCode + monthValue + countValue.PadLeft(int.Parse(_AccountingJournalTypeBusinessUnit.IntMonthlyNumberLength.ToString()), pad);
                }
                else
                {
                    voucherCode = voucherCode + "00" + countValue.PadLeft(int.Parse(_AccountingJournalTypeBusinessUnit.IntYearlyNumberLength.ToString()), pad);
                }
                              

                _tblAccountingJournalCodeGenerator.IntCount = _tblAccountingJournalCodeGenerator.IntCount + 1;
                _context.TblAccountingJournalCodeGenerator.Update(_tblAccountingJournalCodeGenerator);
                await _context.SaveChangesAsync();

                return voucherCode;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
