using ControlPanel.DbContexts;
using ControlPanel.DTO.TerritoryType;
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
    public class TerritoryType : ITerritoryType
    {
        public readonly iBOSContext _context;
        public TerritoryType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTerritoryTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Territory Type.",
                    data = await Task.FromResult((from bp in _context.TblTerritoryType
                                                   join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                   where bp.IsActive == true
                                                   select new GetTerritoryTypeDTO()
                                                   {
                                                       TerritoryTypeId = bp.IntTerritoryTypeId,
                                                       TerritoryTypeName = bp.StrTerritoryTypeName,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       BusinessUnitId = bp.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       levelPosition = bp.IntlevelPosition,
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
        public async Task<Message> GetTerritoryTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Territory Type By Id.",
                    data = await Task.FromResult((from bp in _context.TblTerritoryType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntTerritoryTypeId == Id && bp.IsActive == true
                                                  select new GetTerritoryTypeDTO()
                                                  {
                                                       TerritoryTypeId = bp.IntTerritoryTypeId,
                                                       TerritoryTypeName = bp.StrTerritoryTypeName,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       BusinessUnitId = bp.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       levelPosition = bp.IntlevelPosition,
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
        public async Task<Message> GetTerritoryTypeByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Territory Type By Unit Id.",
                    data = await Task.FromResult((from bp in _context.TblTerritoryType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntTerritoryTypeId == UId && bp.IsActive == true
                                                  select new GetTerritoryTypeDTO()
                                                  {
                                                       TerritoryTypeId = bp.IntTerritoryTypeId,
                                                       TerritoryTypeName = bp.StrTerritoryTypeName,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       BusinessUnitId = bp.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       levelPosition = bp.IntlevelPosition,
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
        public async Task<Message> GetTerritoryTypeByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Territory Type By Client Id.",
                    data = await Task.FromResult((from bp in _context.TblTerritoryType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IntClientId == CId && bp.IsActive == true
                                                  select new GetTerritoryTypeDTO()
                                                  {
                                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                                      TerritoryTypeName = bp.StrTerritoryTypeName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = bp.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      levelPosition = bp.IntlevelPosition,
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
        public async Task<object> CreateTerritoryType(CreateTerritoryTypeDTO postTerritoryType)
        {
            try
            {
                var detalis = new TblTerritoryType
                {
                    StrTerritoryTypeName = postTerritoryType.TerritoryTypeName,
                    IntBusinessUnitId = postTerritoryType.BusinessUnitId,
                    IntlevelPosition = postTerritoryType.levelPosition,
                    IntActionBy = postTerritoryType.ActionBy,
                    IntClientId=postTerritoryType.ClientId,
                    DteLastActionDateTime = DateTime.UtcNow,

                };
                await _context.TblTerritoryType.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblTerritoryType
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IntTerritoryTypeId == detalis.IntTerritoryTypeId && bp.IsActive == true
                                  select new GetTerritoryTypeDTO()
                                  {
                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                      TerritoryTypeName = bp.StrTerritoryTypeName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = bp.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      levelPosition = bp.IntlevelPosition,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
                {
                    status = true,
                    message = "Territory Type has been Created Successfully.",
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
        public async Task<object> EditTerritoryType(EditTerritoryTypeDTO TerritoryType)
        {
            try
            {
                TblTerritoryType data = _context.TblTerritoryType.First(x => x.IntTerritoryTypeId == TerritoryType.TerritoryTypeId);

                data.IntTerritoryTypeId = TerritoryType.TerritoryTypeId;
                data.StrTerritoryTypeName = TerritoryType.TerritoryTypeName;
                data.IntlevelPosition = TerritoryType.levelPosition;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = TerritoryType.ActionBy;

                _context.TblTerritoryType.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblTerritoryType
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IntTerritoryTypeId == TerritoryType.TerritoryTypeId && bp.IsActive == true
                              select new GetTerritoryTypeDTO()
                              {
                                  TerritoryTypeId = bp.IntTerritoryTypeId,
                                  TerritoryTypeName = bp.StrTerritoryTypeName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  levelPosition = bp.IntlevelPosition,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Territory Type Edited Successfully.",
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
        public async Task<object> CancelTerritoryType(CancelTerritoryTypeDTO TerritoryType)
        {
            try
            {
                TblTerritoryType data = _context.TblTerritoryType.First(x => x.IntTerritoryTypeId == TerritoryType.TerritoryTypeId);

                data.IntActionBy = TerritoryType.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.DteServerDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblTerritoryType.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblTerritoryType
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IntTerritoryTypeId == TerritoryType.TerritoryTypeId && bp.IsActive == false
                              select new GetTerritoryTypeDTO()
                              {
                                  TerritoryTypeId = bp.IntTerritoryTypeId,
                                  TerritoryTypeName = bp.StrTerritoryTypeName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = bp.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  levelPosition = bp.IntlevelPosition,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Territory Type Cancelled Successfully.",
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
