using ControlPanel.DbContexts;
using ControlPanel.DTO.PriceSetup;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public class PriceSetup : IPriceSetup
    {
        public readonly iBOSContext _context;
        public PriceSetup(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetPriceSetupById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Price setup List by  Id ",
                    data = await Task.FromResult((from a in _context.TblPriceSetup
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join i in _context.TblItem on a.IntItemId equals i.IntItemId
                                                  where a.IsActive == true && a.IntPriceConditionId == Id
                                                  select new GetPriceSetupDTO()
                                                  {
                                                      PriceConditionId = a.IntPriceConditionId,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ConditionTypeId = a.IntConditionTypeId,
                                                      ConditionTypeName = a.StrConditionTypeName,
                                                      ItemId = a.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      Price = a.NumPrice,
                                                      StartDate = a.DteStartDate,
                                                      EndDate = a.DteEndDate,
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
        public async Task<Message> GetPriceSetupByUnitId(long UId, DateTime fromDate, DateTime Todate)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Price setup List by  Id ",
                    data = await Task.FromResult((from a in _context.TblPriceSetup
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join i in _context.TblItem on a.IntItemId equals i.IntItemId
                                                  where a.IsActive == true && a.IntBusinessUnitId == UId && (a.DteStartDate == fromDate && a.DteEndDate == Todate)
                                                  select new GetPriceSetupDTO()
                                                  {
                                                      PriceConditionId = a.IntPriceConditionId,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ConditionTypeId = a.IntConditionTypeId,
                                                      ConditionTypeName = a.StrConditionTypeName,
                                                      ItemId = a.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      Price = a.NumPrice,
                                                      StartDate = a.DteStartDate,
                                                      EndDate = a.DteEndDate,
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
        public async Task<Message> GetPriceSetupClientId(long CId, DateTime fromDate, DateTime Todate)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Price setup List by  Id ",
                    data = await Task.FromResult((from a in _context.TblPriceSetup
                                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                                  join i in _context.TblItem on a.IntItemId equals i.IntItemId
                                                  where a.IsActive == true && a.IntClientId == CId && (a.DteStartDate == fromDate && a.DteEndDate == Todate)
                                                  select new GetPriceSetupDTO()
                                                  {
                                                      PriceConditionId = a.IntPriceConditionId,
                                                      ClientId = c.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = u.IntBusinessUnitId,
                                                      BusinessUnitName = u.StrBusinessUnitName,
                                                      ConditionTypeId = a.IntConditionTypeId,
                                                      ConditionTypeName = a.StrConditionTypeName,
                                                      ItemId = a.IntItemId,
                                                      ItemName = i.StrItemName,
                                                      Price = a.NumPrice,
                                                      StartDate = a.DteStartDate,
                                                      EndDate = a.DteEndDate,
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
        public async Task<object> CreatePriceSetup(CreatePriceSetupDTO postPriceSetup)
        {
            try
            {
                var detalis = new TblPriceSetup
                {
                    IntClientId = postPriceSetup.ClientId,
                    IntBusinessUnitId = postPriceSetup.BusinessUnitId,
                    IntConditionTypeId = postPriceSetup.ConditionTypeId,
                    StrConditionTypeName = postPriceSetup.ConditionTypeName,
                    IntConditionReffId = postPriceSetup.ConditionReffId,
                    IntItemId = postPriceSetup.ItemId,
                    NumPrice = postPriceSetup.Price,
                    DteStartDate = postPriceSetup.StartDate,
                    DteEndDate = postPriceSetup.EndDate,
                    IntActionBy = postPriceSetup.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblPriceSetup.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from a in _context.TblPriceSetup
                                  join c in _context.TblClient on a.IntClientId equals c.IntClientId
                                  join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                                  join i in _context.TblItem on a.IntItemId equals i.IntItemId
                                  where a.IsActive == true && a.IntPriceConditionId == detalis.IntPriceConditionId
                                  select new GetPriceSetupDTO()
                                  {
                                      PriceConditionId = a.IntPriceConditionId,
                                      ClientId = c.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = u.IntBusinessUnitId,
                                      BusinessUnitName = u.StrBusinessUnitName,
                                      ConditionTypeId = a.IntConditionTypeId,
                                      ConditionTypeName = a.StrConditionTypeName,
                                      ItemId = a.IntItemId,
                                      ItemName = i.StrItemName,
                                      Price = a.NumPrice,
                                      StartDate = a.DteStartDate,
                                      EndDate = a.DteEndDate,
                                      ActionBy = a.IntActionBy,
                                      LastActionDateTime = a.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Price Setup Created Successfully.",
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
        public async Task<object> CancelPriceSetup(CancelPriceSetupDTO PriceSetup)
        {
            try
            {
                TblPriceSetup data = _context.TblPriceSetup.First(x => x.IntPriceConditionId == PriceSetup.PriceConditionId);
                data.IntActionBy = PriceSetup.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblPriceSetup.Update(data);
                await _context.SaveChangesAsync();


                var detalis = from a in _context.TblPriceSetup
                              join c in _context.TblClient on a.IntClientId equals c.IntClientId
                              join u in _context.TblBusinessUnit on a.IntBusinessUnitId equals u.IntBusinessUnitId
                              join i in _context.TblItem on a.IntItemId equals i.IntItemId
                              where a.IsActive == false && a.IntPriceConditionId == PriceSetup.PriceConditionId
                              select new GetPriceSetupDTO()
                              {
                                  PriceConditionId = a.IntPriceConditionId,
                                  ClientId = c.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = u.IntBusinessUnitId,
                                  BusinessUnitName = u.StrBusinessUnitName,
                                  ConditionTypeId = a.IntConditionTypeId,
                                  ConditionTypeName = a.StrConditionTypeName,
                                  ItemId = a.IntItemId,
                                  ItemName = i.StrItemName,
                                  Price = a.NumPrice,
                                  StartDate = a.DteStartDate,
                                  EndDate = a.DteEndDate,
                                  ActionBy = a.IntActionBy,
                                  LastActionDateTime = a.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Price Setup  Cancelled Successfully.",
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
