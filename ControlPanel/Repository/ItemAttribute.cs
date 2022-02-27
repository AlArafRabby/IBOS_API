using ControlPanel.DbContexts;
using ControlPanel.DTO;
using ControlPanel.DTO.ItemAttribute;
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
    public class ItemAttribute : IItemAttribute
    {
        public readonly iBOSContext _context;

        public ItemAttribute(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetItemAttributeAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All ItemAttribute ",
                    data = await Task.FromResult((from ep in _context.TblItemAttribute
                                               join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                                               join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                                               join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                                               where ep.IsActive == true
                                               select new GetItemAttributeDTO()
                                               {
                                                   Id = ep.IntItemAttributeId,
                                                   ItemAttributeName = ep.StrItemAttributeName,
                                                   ItemAttributeUoMName = u.StrUomname,
                                                   ItemCategoryId = c.IntItemCategoryId,
                                                   ItemCategoryName = c.StrItemCategoryName,
                                                   BusinessUnitId = b.IntBusinessUnitId,
                                                   BusinessUnitName = b.StrBusinessUnitName,
                                                   LastActionDateTime = ep.DteLastActionDateTime,

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
        public async Task<Message> GetItemAttributeById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Attribute List By Id ",
                    data = await Task.FromResult((from ep in _context.TblItemAttribute
                                           join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                                           join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                                           join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where ep.IsActive == true && ep.IntItemAttributeId ==Id
                                           select new GetItemAttributeDTO()
                                           {
                                               Id = ep.IntItemAttributeId,
                                               ItemAttributeName = ep.StrItemAttributeName,
                                               ItemAttributeUoMName = u.StrUomname,
                                               ItemCategoryId = c.IntItemCategoryId,
                                               ItemCategoryName = c.StrItemCategoryName,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               LastActionDateTime = ep.DteLastActionDateTime,

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
        public async Task<Message> GetItemAttributeByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Attribute List By Unit Id ",
                    data = await Task.FromResult((from ep in _context.TblItemAttribute
                                           join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                                           join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                                           join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                                           where ep.IsActive == true && ep.IntBusinessUnitId == UId
                                           select new GetItemAttributeDTO()
                                           {
                                               Id = ep.IntItemAttributeId,
                                               ItemAttributeName = ep.StrItemAttributeName,
                                               ItemAttributeUoMName = u.StrUomname,
                                               ItemCategoryId = c.IntItemCategoryId,
                                               ItemCategoryName = c.StrItemCategoryName,
                                               BusinessUnitId = b.IntBusinessUnitId,
                                               BusinessUnitName = b.StrBusinessUnitName,
                                               LastActionDateTime = ep.DteLastActionDateTime,

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
        public async Task<Message> GetItemAttributeByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Attribute List By Client Id ",
                    data = await Task.FromResult((from ep in _context.TblItemAttribute
                                                  join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                                                  join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                                                  join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  where ep.IsActive == true && ep.IntClientId == CId
                                                  select new GetItemAttributeDTO()
                                                  {
                                                      Id = ep.IntItemAttributeId,
                                                      ItemAttributeName = ep.StrItemAttributeName,
                                                      ItemAttributeUoMName = u.StrUomname,
                                                      ItemCategoryId = c.IntItemCategoryId,
                                                      ItemCategoryName = c.StrItemCategoryName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      LastActionDateTime = ep.DteLastActionDateTime,

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
        public async Task<object> CreateItemAttribute(CreateItemAttributeDTO postItemAttribute)
        {
            try
            {
                var detalis = new TblItemAttribute
                {
                    IntClientId = postItemAttribute.ClientId,
                    StrItemAttributeName = postItemAttribute.ItemAttributeName,
                    IntItemAttributeUom = postItemAttribute.ItemAttributeUom,
                    IntBusinessUnitId = postItemAttribute.BusinessUnitId,
                    IntItemCategoryId = postItemAttribute.ItemCategoryId,
                    IntActionBy = postItemAttribute.ActionBy,
                    DteLastActionDateTime = postItemAttribute.LastActionDateTime
                };
                await _context.TblItemAttribute.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from ep in _context.TblItemAttribute
                              join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                              join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                              join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                              where ep.IsActive == true && ep.IntItemAttributeId == detalis.IntItemAttributeId
                                  select new GetItemAttributeDTO()
                              {
                                  Id = ep.IntItemAttributeId,
                                  ItemAttributeName = ep.StrItemAttributeName,
                                  ItemAttributeUoMName = u.StrUomname,
                                  ItemCategoryId = c.IntItemCategoryId,
                                  ItemCategoryName = c.StrItemCategoryName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  LastActionDateTime = ep.DteLastActionDateTime,
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
        public async Task<object> EditItemAttribute(EditItemAttributeDTO putItemAttribute)
        {
            try
            {
                TblItemAttribute data = _context.TblItemAttribute.First(x => x.IntItemAttributeId == putItemAttribute.Id);
                data.StrItemAttributeName = putItemAttribute.ItemAttributeName;
                data.IntItemAttributeUom = putItemAttribute.ItemAttributeUom;
                data.IntItemCategoryId = putItemAttribute.ItemCategoryId;
                data.IntActionBy = putItemAttribute.ActionBy;
                data.DteLastActionDateTime = putItemAttribute.LastActionDateTime;
                data.DteLastActionDateTime = DateTime.UtcNow;
                _context.TblItemAttribute.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ep in _context.TblItemAttribute
                              join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                              join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                              join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                              where ep.IsActive == true && ep.IntItemAttributeId == putItemAttribute.Id
                              select new GetItemAttributeDTO()
                              {
                                  Id = ep.IntItemAttributeId,
                                  ItemAttributeName = ep.StrItemAttributeName,
                                  ItemAttributeUoMName = u.StrUomname,
                                  ItemCategoryId = c.IntItemCategoryId,
                                  ItemCategoryName = c.StrItemCategoryName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  LastActionDateTime = ep.DteLastActionDateTime,
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute Edit Successfully.",
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
        public async Task<Message> CancelItemAttribute(CancelItemAttributeDTO ItemAttribute)
        {
            try
            {
                TblItemAttribute data = _context.TblItemAttribute.First(x => x.IntItemAttributeId == ItemAttribute.Id);
                data.IntActionBy = ItemAttribute.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblItemAttribute.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from ep in _context.TblItemAttribute
                              join u in _context.TblUnitOfMeasurement on ep.IntItemAttributeUom equals u.IntUomid
                              join c in _context.TblItemCategory on ep.IntItemCategoryId equals c.IntItemCategoryId
                              join b in _context.TblBusinessUnit on ep.IntBusinessUnitId equals b.IntBusinessUnitId
                              where ep.IsActive == false && ep.IntItemAttributeId == ItemAttribute.Id
                              select new GetItemAttributeDTO()
                              {
                                  Id = ep.IntItemAttributeId,
                                  ItemAttributeName = ep.StrItemAttributeName,
                                  ItemAttributeUoMName = u.StrUomname,
                                  ItemCategoryId = c.IntItemCategoryId,
                                  ItemCategoryName = c.StrItemCategoryName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  LastActionDateTime = ep.DteLastActionDateTime,
                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Attribute  Cancel Successfully.",
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
