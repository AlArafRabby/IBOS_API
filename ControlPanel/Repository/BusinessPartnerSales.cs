using ControlPanel.DbContexts;
using ControlPanel.DTO.BusinessPartnerWarehouseSales;
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
    public class BusinessPartnerSales : IBusinessPartnerSales
    {
        public readonly iBOSContext _context;

        public BusinessPartnerSales(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetBusinessPartnerSalesAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Partner Sales List ",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerSales
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join bct in _context.TblBalanceCheckType on ip.IntBalanceCheckTypeId equals bct.IntBalanceCheckTypeId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  where ip.IsActive == true
                                                  select new GetBusinessPartnerSalesDTO()
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
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      LedgerBalance = ip.NumLedgerBalance,
                                                      UnbilledAmount = ip.NumUnbilledAmount,
                                                      CreditLimit = ip.NumCreditLimit,
                                                      BalanceCheckTypeId = ip.IntBalanceCheckTypeId,
                                                      BalanceCheckTypeName = bct.StrBalanceCheckName,
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
        public async Task<Message> GetBusinessPartnerSalesById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Sales List By Id.",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerSales
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join bct in _context.TblBalanceCheckType on ip.IntBalanceCheckTypeId equals bct.IntBalanceCheckTypeId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  where ip.IntConfigId == Id && ip.IsActive == true
                                                  select new GetBusinessPartnerSalesDTO()
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
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      LedgerBalance = ip.NumLedgerBalance,
                                                      UnbilledAmount = ip.NumUnbilledAmount,
                                                      CreditLimit = ip.NumCreditLimit,
                                                      BalanceCheckTypeId = ip.IntBalanceCheckTypeId,
                                                      BalanceCheckTypeName = bct.StrBalanceCheckName,
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
        public async Task<Message> GetBusinessPartnerSalesByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Business Partner Sales List By client Id.",
                    data = await Task.FromResult((from ip in _context.TblBusinessPartnerSales
                                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                                  join bct in _context.TblBalanceCheckType on ip.IntBalanceCheckTypeId equals bct.IntBalanceCheckTypeId
                                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                                  where ip.IntClientId == CId && ip.IsActive == true
                                                  select new GetBusinessPartnerSalesDTO()
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
                                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                                      LedgerBalance = ip.NumLedgerBalance,
                                                      UnbilledAmount = ip.NumUnbilledAmount,
                                                      CreditLimit = ip.NumCreditLimit,
                                                      BalanceCheckTypeId = ip.IntBalanceCheckTypeId,
                                                      BalanceCheckTypeName = bct.StrBalanceCheckName,
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
        public async Task<object> CreateBusinessPartnerSales(CreateBusinessPartnerSalesDTO postBusinessPartnerSales)
        {
            try
            {
                var detalis = new TblBusinessPartnerSales
                {
                    IntClientId = postBusinessPartnerSales.ClientId,
                    IntBusinessPartnerId = postBusinessPartnerSales.BusinessPartnerId,
                    IntBusinessUnitId = postBusinessPartnerSales.BusinessUnitId,
                    IntBusinessAreaId = postBusinessPartnerSales.BusinessAreaId,
                    IntSalesOrganizationId = postBusinessPartnerSales.SalesOrganizationId,
                    NumLedgerBalance = 0,
                    NumUnbilledAmount = 0,
                    NumCreditLimit = (postBusinessPartnerSales.CreditLimit)*(-1),
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postBusinessPartnerSales.ActionBy
                };
                await _context.TblBusinessPartnerSales.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ip in _context.TblBusinessPartnerSales
                                  join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                                  join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                                  join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                                  join bct in _context.TblBalanceCheckType on ip.IntBalanceCheckTypeId equals bct.IntBalanceCheckTypeId
                                  join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                                  where ip.IsActive == true && ip.IntConfigId == detalis.IntConfigId
                                  select new GetBusinessPartnerSalesDTO()
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
                                      SalesOrganizationId = s.IntSalesOrganizationId,
                                      SalesOrganizationName = s.StrSalesOrganizationName,
                                      LedgerBalance = ip.NumLedgerBalance,
                                      UnbilledAmount = ip.NumUnbilledAmount,
                                      CreditLimit = ip.NumCreditLimit,
                                      BalanceCheckTypeId = ip.IntBalanceCheckTypeId,
                                      BalanceCheckTypeName = bct.StrBalanceCheckName,
                                      ActionBy = ip.IntActionBy,
                                      LastActionDateTime = ip.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales Created Successfully.",
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
        public async Task<object> EditBusinessPartnerSales(EditBusinessPartnerSalesDTO putBusinessPartnerSales)
        {
            try
            {
                TblBusinessPartnerSales data = _context.TblBusinessPartnerSales.First(x => x.IntConfigId == putBusinessPartnerSales.ConfigId);

                data.IntConfigId = putBusinessPartnerSales.ConfigId;
                data.IntBusinessPartnerId = putBusinessPartnerSales.BusinessPartnerId;
                data.IntBusinessAreaId = putBusinessPartnerSales.BusinessAreaId;
                data.IntSalesOrganizationId = putBusinessPartnerSales.SalesOrganizationId;
                data.NumCreditLimit = (putBusinessPartnerSales.CreditLimit) * (-1);
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = putBusinessPartnerSales.ActionBy;

                _context.TblBusinessPartnerSales.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblBusinessPartnerSales
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              join bct in _context.TblBalanceCheckType on ip.IntBalanceCheckTypeId equals bct.IntBalanceCheckTypeId
                              join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                              where ip.IsActive == true && ip.IntConfigId == putBusinessPartnerSales.ConfigId
                              select new GetBusinessPartnerSalesDTO()
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
                                  SalesOrganizationId = s.IntSalesOrganizationId,
                                  SalesOrganizationName = s.StrSalesOrganizationName,
                                  LedgerBalance = ip.NumLedgerBalance,
                                  UnbilledAmount = ip.NumUnbilledAmount,
                                  CreditLimit = ip.NumCreditLimit,
                                  BalanceCheckTypeId = ip.IntBalanceCheckTypeId,
                                  BalanceCheckTypeName = bct.StrBalanceCheckName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales Edited Successfully.",
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
        public async Task<object> CancelBusinessPartnerSales(CancelBusinessPartnerSalesDTO putBusinessPartnerSales)
        {
            try
            {
                TblBusinessPartnerSales data = _context.TblBusinessPartnerSales.First(x => x.IntConfigId == putBusinessPartnerSales.ConfigId);

                data.IntActionBy = putBusinessPartnerSales.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblBusinessPartnerSales.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ip in _context.TblBusinessPartnerSales
                              join bp in _context.TblBusinessPartner on ip.IntBusinessPartnerId equals bp.IntBusinessPartnerId
                              join b in _context.TblBusinessUnit on ip.IntBusinessUnitId equals b.IntBusinessUnitId
                              join a in _context.TblBusinessArea on ip.IntBusinessAreaId equals a.IntBusinessAreaId
                              join c in _context.TblClient on ip.IntClientId equals c.IntClientId
                              join bct in _context.TblBalanceCheckType on ip.IntBalanceCheckTypeId equals bct.IntBalanceCheckTypeId
                              join s in _context.TblSalesOrganization on ip.IntSalesOrganizationId equals s.IntSalesOrganizationId
                              where ip.IsActive == false && ip.IntConfigId == putBusinessPartnerSales.ConfigId
                              select new GetBusinessPartnerSalesDTO()
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
                                  SalesOrganizationId = s.IntSalesOrganizationId,
                                  SalesOrganizationName = s.StrSalesOrganizationName,
                                  LedgerBalance = ip.NumLedgerBalance,
                                  UnbilledAmount = ip.NumUnbilledAmount,
                                  CreditLimit = ip.NumCreditLimit,
                                  BalanceCheckTypeId = ip.IntBalanceCheckTypeId,
                                  BalanceCheckTypeName = bct.StrBalanceCheckName,
                                  ActionBy = ip.IntActionBy,
                                  LastActionDateTime = ip.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales Cancelled Successfully.",
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
                var LedgerBalance = (from ip in _context.TblBusinessPartnerSales
                                 where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                 select new { ip.NumLedgerBalance }).SingleOrDefault();

                decimal LBalance = LedgerBalance.NumLedgerBalance - amount;

                var result = (from ip in _context.TblBusinessPartnerSales
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();
                result.NumLedgerBalance = LBalance;
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerSales
                                  where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                  select new { ip.NumLedgerBalance }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales leadger balance updated Successfully.",
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
                var UnbilledAmount = (from ip in _context.TblBusinessPartnerSales
                                     where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                     select new { ip.NumUnbilledAmount }).SingleOrDefault();

                decimal UnBilled = UnbilledAmount.NumUnbilledAmount + SOamount;

                var result = (from ip in _context.TblBusinessPartnerSales
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                result.NumUnbilledAmount = UnBilled;
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerSales
                                  where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                  select new 
                                  {
                                      ip.NumUnbilledAmount
                                  }).SingleOrDefault(); 

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales unbilled Sales Order balance updated Successfully.",
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
                var UnbilledAmount_Ledger = (from ip in _context.TblBusinessPartnerSales
                                      where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                      select new { ip.NumUnbilledAmount, ip.NumLedgerBalance }).SingleOrDefault();

                decimal UnBilled = UnbilledAmount_Ledger.NumUnbilledAmount - Billamount;
                decimal LBalance = UnbilledAmount_Ledger.NumLedgerBalance + Billamount;

                var result = (from ip in _context.TblBusinessPartnerSales
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                result.NumUnbilledAmount = UnBilled;
                result.NumLedgerBalance = LBalance;
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerSales
                                  where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                  select new { ip.NumUnbilledAmount, ip.NumLedgerBalance }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales Unbilled balance updated Successfully.",
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
                var result = (from ip in _context.TblBusinessPartnerSales
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                result.NumCreditLimit = (Limitamount * (-1));
                await _context.SaveChangesAsync();

                var detalisView = (from ip in _context.TblBusinessPartnerSales
                                   where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                                   select new { ip.NumCreditLimit }).SingleOrDefault();

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales Credit Limit  updated Successfully.",
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
                var result = (from ip in _context.TblBusinessPartnerSales
                              where ip.IsActive == true && ip.IntBusinessPartnerId == pId
                              select ip).SingleOrDefault();

                decimal AvailableLimit = ((result.NumLedgerBalance + result.NumUnbilledAmount + result.NumCreditLimit) * (-1));
               

                var successmsg = new Message
                {
                    status = true,
                    message = "Business Partner Sales Available Limit By Partner Id.",
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
