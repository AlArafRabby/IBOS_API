using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.ItemAttribute;
using ControlPanel.DTO.ItemCategory;
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
    public class ItemCategory : IItemCategory
    {
        public readonly iBOSContext _context;

        public ItemCategory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemCategoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Category ",
                    data = await Task.FromResult((from bp in _context.TblItemCategory
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                           join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                                           where bp.IsActive == true
                                           select new GetItemCategoryAllDTO()
                                           {
                                               Id = bp.IntItemCategoryId,
                                               Code = bp.StrItemCategoryCode,
                                               ItemCategoryName = bp.StrItemCategoryName,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               ItemTypeId = bp.IntItemTypeId,
                                               ItemTypeName = i.StrItemTypeName,
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
        public async Task<Message> GetItemCategoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Category Id ",
                    data= await Task.FromResult((from bp in _context.TblItemCategory
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                            join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                                            where bp.IntItemCategoryId == Id && bp.IsActive == true
                                           select new GetItemCategoryAllDTO()
                                           {
                                               Id = bp.IntItemCategoryId,
                                               Code = bp.StrItemCategoryCode,
                                               ItemCategoryName = bp.StrItemCategoryName,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               ItemTypeId = bp.IntItemTypeId,
                                               ItemTypeName = i.StrItemTypeName,
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
        public async Task<Message> GetItemCategoryByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Category Bussiness unit Id ",
                    data = await Task.FromResult((from bp in _context.TblItemCategory
                                           join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                            join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                                            where bp.IntBusinessUnitId == UId && bp.IsActive == true
                                           select new GetItemCategoryAllDTO()
                                           {
                                               Id = bp.IntItemCategoryId,
                                               Code = bp.StrItemCategoryCode,
                                               ItemCategoryName = bp.StrItemCategoryName,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               ItemTypeId = bp.IntItemTypeId,
                                               ItemTypeName = i.StrItemTypeName,
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
        public async Task<Message> GetItemCategoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Category Bussiness client Id ",
                    data = await Task.FromResult((from bp in _context.TblItemCategory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                                                  where bp.IntClientId == CId && bp.IsActive == true
                                                  select new GetItemCategoryAllDTO()
                                                  {
                                                      Id = bp.IntItemCategoryId,
                                                      Code = bp.StrItemCategoryCode,
                                                      ItemCategoryName = bp.StrItemCategoryName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ItemTypeId = bp.IntItemTypeId,
                                                      ItemTypeName = i.StrItemTypeName,
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
        public async Task<Message> CreateItemCategory(CreateItemCategoryDTO postItemCategory)
        {
            try
            {
                var detalis = new TblItemCategory
            {
                IntClientId = postItemCategory.ClientId,
                StrItemCategoryCode = postItemCategory.ItemCategoryName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                StrItemCategoryName = postItemCategory.ItemCategoryName,
                IntBusinessUnitId = postItemCategory.BusinessUnitId,
                IntItemTypeId = postItemCategory.ItemTypeId,
                IntActionBy = postItemCategory.ActionBy,
                DteLastActionDateTime = postItemCategory.LastActionDateTime
            };
            await _context.TblItemCategory.AddAsync(detalis);
            await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblItemCategory
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                              where bp.IntItemCategoryId == detalis.IntItemCategoryId && bp.IsActive == true
                              select new GetItemCategoryAllDTO()
                              {
                                  Id = bp.IntItemCategoryId,
                                  Code = bp.StrItemCategoryCode,
                                  ItemCategoryName = bp.StrItemCategoryName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemTypeId = bp.IntItemTypeId,
                                  ItemTypeName = i.StrItemTypeName,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Category Create Successfully.",
                    data = detalisView
                };

                return successmsg;
                // return detalis.IntItemAttributeId;
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
        public async Task<Message> EditItemCategory(EditItemCategoryDTO ItemCategory)
        {
            try
            {
                TblItemCategory data = _context.TblItemCategory.First(x => x.IntItemCategoryId == ItemCategory.Id);
                data.StrItemCategoryName = ItemCategory.ItemCategoryName;            
                data.IntActionBy = ItemCategory.ActionBy;
                data.DteLastActionDateTime = ItemCategory.LastActionDateTime;
                data.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblItemCategory.Update(data);
                await _context.SaveChangesAsync();
                var detalis = from bp in _context.TblItemCategory
                       join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                        join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                        where bp.IntItemCategoryId == ItemCategory.Id && bp.IsActive == true
                       select new GetItemCategoryAllDTO()
                       {
                           Id = bp.IntItemCategoryId,
                           Code = bp.StrItemCategoryCode,
                           ItemCategoryName = bp.StrItemCategoryName,
                           BusinessUnitId = b.IntBusinessUnitId,
                           BusinessUnitName = b.StrBusinessUnitName,
                           ItemTypeId = bp.IntItemTypeId,
                           ItemTypeName = i.StrItemTypeName,
                           LastActionDateTime = bp.DteLastActionDateTime

                       };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Category Edit Successfully.",
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
        public async Task<Message> CancelItemCategory(CancelItemCategoryDTO lItemCategoryDTO)
        {
            try
            {
                TblItemCategory data = _context.TblItemCategory.First(x => x.IntItemCategoryId == lItemCategoryDTO.Id);
                data.IntActionBy = lItemCategoryDTO.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblItemCategory.Update(data);
                await _context.SaveChangesAsync();
                var detalis = from bp in _context.TblItemCategory
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join i in _context.TblItemType on bp.IntItemTypeId equals i.IntItemTypeId
                              where bp.IntItemCategoryId == lItemCategoryDTO.Id && bp.IsActive == false
                              select new GetItemCategoryAllDTO()
                              {
                                  Id = bp.IntItemCategoryId,
                                  Code = bp.StrItemCategoryCode,
                                  ItemCategoryName = bp.StrItemCategoryName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ItemTypeId = bp.IntItemTypeId,
                                  ItemTypeName = i.StrItemTypeName,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Category Cancel Successfully.",
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
