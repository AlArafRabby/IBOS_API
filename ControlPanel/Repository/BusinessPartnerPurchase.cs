
using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessPartnerWarehousePurchase;
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
    public class BusinessPartnerPurchase : IBusinessPartnerPurchase
    {
        public readonly iBOSContext _context;
        public BusinessPartnerPurchase(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerPurchaseAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner Purchase List ",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerPurchase
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join p in _context.TblPurchaseOrganization on ip.IntPurchaseOrganizationId equals p.IntPurchaseOrganizationid
                                                  where ip.IsActive == true
                                                  select new GetBusinessPartnerPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = ip.IntBusinessAreaId ,
                                                      BusinessAreaName = a.StrBusinessAreaName ,
                                                      PurchaseOrganizationId = ip.IntPurchaseOrganizationId,
                                                      PurchaseOrganizationName = p.StrPurchaseOrganization,
                                                      LedgerBalance = ip.NumLedgerBalance,
                                                      UnbilledAmount = ip.NumUnbilledAmount ,
                                                      CreditLimit = ip.NumCreditLimit,
                                                      ActionBy = ip.IntActionBy,
                                                      LastActionDateTime = ip.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerPurchaseById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Purchase List By Id.",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerPurchase
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                                  join p in _context.TblPurchaseOrganization on ip.IntPurchaseOrganizationId equals p.IntPurchaseOrganizationid
                                                  where ip.IntConfigId == Id && ip.IsActive == true
                                                  select new GetBusinessPartnerPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = ip.IntBusinessAreaId,
                                                      BusinessAreaName = a.StrBusinessAreaName,
                                                      PurchaseOrganizationId = ip.IntPurchaseOrganizationId,
                                                      PurchaseOrganizationName = p.StrPurchaseOrganization,
                                                      LedgerBalance = ip.NumLedgerBalance,
                                                      UnbilledAmount = ip.NumUnbilledAmount,
                                                      CreditLimit = ip.NumCreditLimit,
                                                      ActionBy = ip.IntActionBy,
                                                      LastActionDateTime = ip.DteLastActionDateTime

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
        public async Task<Message> GetBusinessPartnerPurchaseByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Purchase List By client Id.",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerPurchase
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                                  join p in _context.TblPurchaseOrganization on ip.IntPurchaseOrganizationId equals p.IntPurchaseOrganizationid
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetBusinessPartnerPurchaseDTO()
                                                  {
                                                      ConfigId = ip.IntConfigId,
                                                      ClientId = ip.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = ip.IntBusinessAreaId,
                                                      BusinessAreaName = a.StrBusinessAreaName,
                                                      PurchaseOrganizationId = ip.IntPurchaseOrganizationId,
                                                      PurchaseOrganizationName = p.StrPurchaseOrganization,
                                                      LedgerBalance = ip.NumLedgerBalance,
                                                      UnbilledAmount = ip.NumUnbilledAmount,
                                                      CreditLimit = ip.NumCreditLimit,
                                                      ActionBy = ip.IntActionBy,
                                                      LastActionDateTime = ip.DteLastActionDateTime

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
        public async Task<object> CreateBusinessPartnerPurchase(CreateBusinessPartnerPurchaseDTO postBusinessPartnerPurchase)
        {
            try
            {
                var detalis = new TblBusinessPartnerPurchase
                {
                    IntClientId = postBusinessPartnerPurchase.ClientId,
                    IntBusinessAreaId = postBusinessPartnerPurchase.BusinessAreaId,
                    IntBusinessPartnerId = postBusinessPartnerPurchase.BusinessPartnerId,
                    IntBusinessUnitId = postBusinessPartnerPurchase.BusinessUnitId,
                    IntPurchaseOrganizationId = postBusinessPartnerPurchase.PurchaseOrganizationId,
                    NumLedgerBalance = postBusinessPartnerPurchase.LedgerBalance,
                    NumUnbilledAmount = postBusinessPartnerPurchase.UnbilledAmount,
                    NumCreditLimit = postBusinessPartnerPurchase.CreditLimit,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postBusinessPartnerPurchase.ActionBy
                };
                await _context.TblBusinessPartnerPurchase.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblBusinessPartnerPurchase
                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                  join p in _context.TblPurchaseOrganization on ip.IntPurchaseOrganizationId equals p.IntPurchaseOrganizationid
                                  where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                                  select new GetBusinessPartnerPurchaseDTO()
                                  {
                                      ConfigId = ip.IntConfigId,
                                      ClientId = ip.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessPartnerId = bp.IntBusinessPartnerId,
                                      BusinessPartnerName = bp.StrBusinessPartnerName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      BusinessAreaId = ip.IntBusinessAreaId,
                                      BusinessAreaName = a.StrBusinessAreaName,
                                      PurchaseOrganizationId = ip.IntPurchaseOrganizationId,
                                      PurchaseOrganizationName = p.StrPurchaseOrganization,
                                      LedgerBalance = ip.NumLedgerBalance,
                                      UnbilledAmount = ip.NumUnbilledAmount,
                                      CreditLimit = ip.NumCreditLimit,
                                      ActionBy = ip.IntActionBy,
                                      LastActionDateTime = ip.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase Created Successfully.",
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
        public async Task<object> EditBusinessPartnerPurchase(EditBusinessPartnerPurchaseDTO putBusinessPartnerPurchase)
        {
            try
            {
                TblBusinessPartnerPurchase data = _context.TblBusinessPartnerPurchase.First(x => x.IntConfigId == putBusinessPartnerPurchase.ConfigId);

                data.IntConfigId = putBusinessPartnerPurchase.ConfigId;
                data.IntBusinessUnitId = putBusinessPartnerPurchase.BusinessUnitId;
                data.IntBusinessAreaId = putBusinessPartnerPurchase.BusinessAreaId;
                data.IntBusinessPartnerId = putBusinessPartnerPurchase.BusinessPartnerId;
                data.IntPurchaseOrganizationId = putBusinessPartnerPurchase.PurchaseOrganizationId;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = putBusinessPartnerPurchase.ActionBy;

                _context.TblBusinessPartnerPurchase.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblBusinessPartnerPurchase
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                              join p in _context.TblPurchaseOrganization on ip.IntPurchaseOrganizationId equals p.IntPurchaseOrganizationid
                              where ip.IsActive == true && ip.IntConfigId == putBusinessPartnerPurchase.ConfigId
                              select new GetBusinessPartnerPurchaseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessPartnerId = bp.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = ip.IntBusinessAreaId,
                                  BusinessAreaName = a.StrBusinessAreaName,
                                  PurchaseOrganizationId = ip.IntPurchaseOrganizationId,
                                  PurchaseOrganizationName = p.StrPurchaseOrganization,
                                  LedgerBalance = ip.NumLedgerBalance,
                                  UnbilledAmount = ip.NumUnbilledAmount,
                                  CreditLimit = ip.NumCreditLimit,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerPurchase(CancelBusinessPartnerPurchaseDTO putBusinessPartnerPurchase)
        {
            try
            {
                TblBusinessPartnerPurchase data = _context.TblBusinessPartnerPurchase.First(x => x.IntConfigId == putBusinessPartnerPurchase.ConfigId);

                data.IntActionBy = putBusinessPartnerPurchase.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartnerPurchase.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblBusinessPartnerPurchase
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                              join p in _context.TblPurchaseOrganization on ip.IntPurchaseOrganizationId equals p.IntPurchaseOrganizationid
                              where ip.IsActive == false && ip.IntConfigId == putBusinessPartnerPurchase.ConfigId
                              select new GetBusinessPartnerPurchaseDTO()
                              {
                                  ConfigId = ip.IntConfigId,
                                  ClientId = ip.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessPartnerId = bp.IntBusinessPartnerId,
                                  BusinessPartnerName = bp.StrBusinessPartnerName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = ip.IntBusinessAreaId,
                                  BusinessAreaName = a.StrBusinessAreaName,
                                  PurchaseOrganizationId = ip.IntPurchaseOrganizationId,
                                  PurchaseOrganizationName = p.StrPurchaseOrganization,
                                  LedgerBalance = ip.NumLedgerBalance,
                                  UnbilledAmount = ip.NumUnbilledAmount,
                                  CreditLimit = ip.NumCreditLimit,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase Cancelled Successfully.",
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

        public async Task<Message> LedgerBalanceUpdateDuringPartnerRecive(long pId, decimal amount)
        {
            try
            {
                var LedgerBalance = (from ip in _context.TblBusinessPartnerPurchase
                                     where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                     select new { ip.NumLedgerBalance }).SingleOrDefault();

                decimal LBalance = LedgerBalance.NumLedgerBalance - amount;

                var result = (from ip in _context.TblBusinessPartnerPurchase
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();
                result.NumLedgerBalance = LBalance;
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerPurchase
                                   where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                   select new { ip.NumLedgerBalance }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase leadger balance updated Successfully.",
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

        public async Task<Message> UnbilledAmountUpdateDuringSalesOrder(long pId, decimal SOamount)
        {
            try
            {
                var UnbilledAmount = (from ip in _context.TblBusinessPartnerPurchase
                                      where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                      select new { ip.NumUnbilledAmount }).SingleOrDefault();

                decimal UnBilled = UnbilledAmount.NumUnbilledAmount + SOamount;

                var result = (from ip in _context.TblBusinessPartnerPurchase
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                result.NumUnbilledAmount = UnBilled;
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerPurchase
                                   where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                   select new
                                   {
                                       ip.NumUnbilledAmount
                                   }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase unbilled Sales Order balance updated Successfully.",
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

        public async Task<Message> UnbilledAmountUpdateDuringPartnerBilling(long pId, decimal Billamount)
        {
            try
            {
                var UnbilledAmount_Ledger = (from ip in _context.TblBusinessPartnerPurchase
                                             where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                             select new { ip.NumUnbilledAmount, ip.NumLedgerBalance }).SingleOrDefault();

                decimal UnBilled = UnbilledAmount_Ledger.NumUnbilledAmount - Billamount;
                decimal LBalance = UnbilledAmount_Ledger.NumLedgerBalance + Billamount;

                var result = (from ip in _context.TblBusinessPartnerPurchase
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                result.NumUnbilledAmount = UnBilled;
                result.NumLedgerBalance = LBalance;
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerPurchase
                                   where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                   select new { ip.NumUnbilledAmount, ip.NumLedgerBalance }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase Unbilled balance updated Successfully.",
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

        public async Task<Message> CreditLimitUpdateDuringPartnerCreaditLimit(long pId, decimal Limitamount)
        {
            try
            {
                var result = (from ip in _context.TblBusinessPartnerPurchase
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                result.NumCreditLimit = (Limitamount * (-1));
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerPurchase
                                   where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                   select new { ip.NumCreditLimit }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase Credit Limit  updated Successfully.",
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

        public async Task<Message> GetAvailableBalance(long pId)
        {
            try
            {
                var result = (from ip in _context.TblBusinessPartnerPurchase
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                decimal AvailableLimit = ((result.NumLedgerBalance + result.NumUnbilledAmount + result.NumCreditLimit) * (-1));


                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Purchase Available Limit By Partner Id.",
                    data = "Available Limit: " + AvailableLimit
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
