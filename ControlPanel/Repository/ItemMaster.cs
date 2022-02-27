using ControlPanel.DbContexts;
using ControlPanel.DTO.ItemMaster;
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
    public class ItemMaster : IItemMaster
    {
        public readonly iBOSContext _context;
        public ItemMaster(iBOSContext context)
        {
            _context = context;
        }       
        public async Task<Message> GetItemMasteryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Item Master List ",
                    data = await _context.TblItemMaster.Where(x => x.IsActive == true).Select(t => new GetItemMasterAllDTO()
                    {
                        Id = t.IntItemMasterId,
                        ItemMasterName = t.StrItemMasterName,
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
        public async Task<Message> GetItemMasterById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Master List by Id.",
                    data = await _context.TblItemMaster.Where(x => x.IntItemMasterId == Id && x.IsActive == true).Select(t => new GetItemMasterAllDTO()
                    {
                        Id = t.IntItemMasterId,
                        ItemMasterName = t.StrItemMasterName,
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
        public async Task<Message> GetItemMasterByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "Item Master List by Client Id.",
                    data = await _context.TblItemMaster.Where(x => x.IntClientId == CId && x.IsActive == true).Select(t => new GetItemMasterAllDTO()
                    {
                        Id = t.IntItemMasterId,
                        ItemMasterName = t.StrItemMasterName,
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
        public async Task<object> CreateItemMaster(CreateItemMasterDTO postItemMaster)
        {
            try
            {
                var detalis = new TblItemMaster
                {
                    IntClientId = postItemMaster.ClientId,
                    StrItemMasterName = postItemMaster.ItemMasterName,
                    IntActionBy = postItemMaster.ActionBy,
                    DteLastActionDateTime = postItemMaster.LastActionDateTime
                };
                await _context.TblItemMaster.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = new GetItemMasterAllDTO()
                {
                    Id = detalis.IntItemMasterId,
                    ItemMasterName = detalis.StrItemMasterName,
                    ActionBy = detalis.IntActionBy,
                    LastActionDateTime = detalis.DteLastActionDateTime
                };

                var successmsg = new Message
                {
                    status = true,
                    message = "Item Master Create Successfully.",
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
        public async Task<object> EditItemMaster(EditItemMasterDTO putIItemMaster)
        {
            try
            {
               TblItemMaster data = _context.TblItemMaster.First(x => x.IntItemMasterId == putIItemMaster.Id);              
                data.StrItemMasterName = putIItemMaster.ItemMasterName;
                data.IntActionBy = putIItemMaster.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblItemMaster.Update(data);
                await _context.SaveChangesAsync();

                var detalis = new GetItemMasterAllDTO()
                {
                    Id = data.IntItemMasterId,
                    ItemMasterName = data.StrItemMasterName,
                    ActionBy = data.IntActionBy,
                    LastActionDateTime = data.DteLastActionDateTime
                };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Master Edit Successfully.",
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
        public async Task<object> CancelItemMaster(CancelItemMasterDTO ItemItemMaster)
        {
            try
            {
                TblItemMaster data = _context.TblItemMaster.First(x => x.IntItemMasterId == ItemItemMaster.Id);
                data.IntActionBy = ItemItemMaster.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblItemMaster.Update(data);
                await _context.SaveChangesAsync();

                var detalis = new GetItemMasterAllDTO()
                {
                    Id = data.IntItemMasterId,
                    ItemMasterName = data.StrItemMasterName,
                    ActionBy = data.IntActionBy,
                    LastActionDateTime = data.DteLastActionDateTime
                };
                var successmsg = new Message
                {
                    status = true,
                    message = "Item Master Cancel Successfully.",
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
