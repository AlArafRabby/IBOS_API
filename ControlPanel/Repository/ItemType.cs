using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemType;
using ControlPanel.IRepository;
using ControlPanel.Models.iBOS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanellNew.Helper;

namespace ControlPanel.Repository
{
    public class ItemType : IItemType
    {
        public readonly iBOSContext _context;
        public ItemType(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemTypeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Type ",
                    data = await Task.FromResult((from bp in _context.TblItemType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where bp.IsActive == true
                                                  select new GetItemTypeDTO()
                                                  {
                                                      Id = bp.IntItemTypeId,
                                                      ItemTypeName = bp.StrItemTypeName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<Message> GetItemTypeByBusinessUnitid(long BusinessUnitid)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Type By Business Unit id ",
                    data = await Task.FromResult((from bp in _context.TblItemType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where bp.IntBusinessUnitId == BusinessUnitid && bp.IsActive == true
                                                  select new GetItemTypeDTO()
                                                  {
                                                      Id = bp.IntItemTypeId,
                                                      ItemTypeName = bp.StrItemTypeName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<Message> GetItemTypeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Type By Business Unit id ",
                    data = await Task.FromResult((from bp in _context.TblItemType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where bp.IntItemTypeId == Id && bp.IsActive == true
                                                  select new GetItemTypeDTO()
                                                  {
                                                      Id = bp.IntItemTypeId,
                                                      ItemTypeName = bp.StrItemTypeName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<Message> GetItemTypeByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Type By Business Clinet id ",
                    data = await Task.FromResult((from bp in _context.TblItemType
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where bp.IntClientId == CId && bp.IsActive == true
                                                  select new GetItemTypeDTO()
                                                  {
                                                      Id = bp.IntItemTypeId,
                                                      ItemTypeName = bp.StrItemTypeName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
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
        public async Task<Message> CreateItemType(CreateItemTypeDTO postItemType)
        {
            try
            {
                var detalis = new TblItemType
                {
                    IntClientId = postItemType.ClientId,
                    StrItemTypeName = postItemType.ItemTypeName,
                    IntBusinessUnitId = postItemType.BusinessUnitId,
                    IntActionBy = postItemType.ActionBy,
                    DteLastActionDateTime = postItemType.LastActionDateTime
                };
                await _context.TblItemType.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblItemType
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IntItemTypeId == detalis.IntItemTypeId && bp.IsActive == true
                              select new GetItemTypeDTO()
                              {
                                  Id = bp.IntItemTypeId,
                                  ItemTypeName = bp.StrItemTypeName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  LastActionDateTime = bp.DteLastActionDateTime
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute Create Successfully.",
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
        public async Task<Message> EditItemType(EditItemTypeDTO putItemType)
        {
            try
            {
                TblItemType data = _context.TblItemType.First(x => x.IntItemTypeId == putItemType.Id);
                data.StrItemTypeName = putItemType.ItemTypeName;
                data.IntActionBy = putItemType.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblItemType.Update(data);
                await _context.SaveChangesAsync();
                var Details = from bp in _context.TblItemType
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IntItemTypeId == putItemType.Id && bp.IsActive == true
                              select new GetItemTypeDTO()
                              {
                                  Id = bp.IntItemTypeId,
                                  ItemTypeName = bp.StrItemTypeName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  LastActionDateTime = bp.DteLastActionDateTime
                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Type Edit Successfully.",
                    data = Details
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
        public async Task<Message> CancelItemType(CancelItemTypeDTO putItemType)
        {
            try
            {
                TblItemType data = _context.TblItemType.First(x => x.IntItemTypeId == putItemType.Id);
                data.IntActionBy = putItemType.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblItemType.Update(data);
                await _context.SaveChangesAsync();
                var Details = from bp in _context.TblItemType
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              where bp.IntItemTypeId == putItemType.Id && bp.IsActive == false
                              select new GetItemTypeDTO()
                              {
                                  Id = bp.IntItemTypeId,
                                  ItemTypeName = bp.StrItemTypeName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Type Cancel Successfully.",
                    data = Details
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
