using ControlPanel.DbContexts;
using ControlPanel.DTO.ProductDivision;
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
    public class ProductDivision : IProductDivision
    {
        public readonly iBOSContext _context;
        public ProductDivision(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetProductDivisionAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Product Division List: ",
                    data = await Task.FromResult((from bp in _context.TblProductDivision
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                  select new GetProductDivisionDTO()
                                                  {
                                                      ProductDivisionId = bp.IntProductDivisionId,
                                                      ProductDivisionCode = bp.StrProductDivisionCode,
                                                      ProductDivisionName = bp.StrProductDivisionName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetProductDivisionById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Product Division List By Id: ",
                    data = await Task.FromResult((from bp in _context.TblProductDivision
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntProductDivisionId == Id && bp.IsActive == true
                                                  select new GetProductDivisionDTO()
                                                  {
                                                      ProductDivisionId = bp.IntProductDivisionId,
                                                      ProductDivisionCode = bp.StrProductDivisionCode,
                                                      ProductDivisionName = bp.StrProductDivisionName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetProductDivisionByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Product Division List By Unit Id: ",
                    data = await Task.FromResult((from bp in _context.TblProductDivision
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntProductDivisionId == UId && bp.IsActive == true
                                                  select new GetProductDivisionDTO()
                                                  {
                                                      ProductDivisionId = bp.IntProductDivisionId,
                                                      ProductDivisionCode = bp.StrProductDivisionCode,
                                                      ProductDivisionName = bp.StrProductDivisionName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<Message> GetProductDivisionByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Product Division List By Client Id: ",
                    data = await Task.FromResult((from bp in _context.TblProductDivision
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntClientId == CId && bp.IsActive == true
                                                  select new GetProductDivisionDTO()
                                                  {
                                                      ProductDivisionId = bp.IntProductDivisionId,
                                                      ProductDivisionCode = bp.StrProductDivisionCode,
                                                      ProductDivisionName = bp.StrProductDivisionName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      BusinessAreaId = d.IntBusinessAreaId,
                                                      BusinessAreaName = d.StrBusinessAreaName,
                                                      ActionBy = bp.IntActionBy,
                                                      LastActionDateTime = bp.DteLastActionDateTime

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
        public async Task<object> CreateProductDivision(CreateProductDivisionDTO postProductDivision)
        {
            try
            {
                var detalis = new TblProductDivision
                {
                    IntClientId = postProductDivision.ClientId,
                    StrProductDivisionCode = postProductDivision.ProductDivisionCode,
                    StrProductDivisionName = postProductDivision.ProductDivisionName,
                    IntBusinessUnitId = postProductDivision.BusinessUnitId,
                    IntBusinessAreaId = postProductDivision.BusinessAreaId,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postProductDivision.ActionBy

                };
                await _context.TblProductDivision.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblProductDivision
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntProductDivisionId == detalis.IntProductDivisionId
                              select new GetProductDivisionDTO()
                              {
                                  ProductDivisionId = bp.IntProductDivisionId,
                                  ProductDivisionCode = bp.StrProductDivisionCode,
                                  ProductDivisionName = bp.StrProductDivisionName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Product Division Created Successfully.",
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
        public async Task<object> EditProductDivision(EditProductDivisionDTO productDivision)
        {
            try
            {
                TblProductDivision data = _context.TblProductDivision.First(x => x.IntProductDivisionId == productDivision.ProductDivisionId);

                data.IntProductDivisionId = productDivision.ProductDivisionId;
                data.StrProductDivisionName = productDivision.ProductDivisionName;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = productDivision.ActionBy;

                _context.TblProductDivision.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblProductDivision
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntProductDivisionId == productDivision.ProductDivisionId
                              select new GetProductDivisionDTO()
                              {
                                  ProductDivisionId = bp.IntProductDivisionId,
                                  ProductDivisionCode = bp.StrProductDivisionCode,
                                  ProductDivisionName = bp.StrProductDivisionName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Product Division Edited Successfully.",
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
        public async Task<object> CancelProductDivision(CancelProductDivisionDTO productDivision)
        {
            try
            {
                TblProductDivision data = _context.TblProductDivision.First(x => x.IntProductDivisionId == productDivision.ProductDivisionId);
                data.IntActionBy = productDivision.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblProductDivision.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblProductDivision
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join d in _context.TblBusinessArea on bp.IntBusinessAreaId equals d.IntBusinessAreaId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntProductDivisionId == productDivision.ProductDivisionId
                              select new GetProductDivisionDTO()
                              {
                                  ProductDivisionId = bp.IntProductDivisionId,
                                  ProductDivisionCode = bp.StrProductDivisionCode,
                                  ProductDivisionName = bp.StrProductDivisionName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  BusinessAreaId = d.IntBusinessAreaId,
                                  BusinessAreaName = d.StrBusinessAreaName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Product Division Cancelled Successfully.",
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

