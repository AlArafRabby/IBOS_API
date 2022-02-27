using ControlPanel.DbContexts;
using ControlPanel.DTO.Plant;
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
    public class Plant : IPlant
    {
        public readonly iBOSContext _context;
        public Plant(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetPlantAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Plant List: ",
                    data = await Task.FromResult((from bp in _context.TblPlant
                                                   join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                   join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                   where bp.IsActive == true
                                                   select new GetPlantDTO()
                                                   {
                                                       PlantId = bp.IntPlantId,
                                                       PlantCode = bp.StrPlantCode,
                                                       PlantName = bp.StrPlantName,
                                                       PlantAddress = bp.StrPlantAddress,
                                                       BusinessUnitId =b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName,
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
        public async Task<Message> GetPlantById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Plant List by Id: ",
                    data = await Task.FromResult((from bp in _context.TblPlant
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntPlantId == Id
                                                  select new GetPlantDTO()
                                                  {
                                                      PlantId = bp.IntPlantId,
                                                      PlantCode = bp.StrPlantCode,
                                                      PlantName = bp.StrPlantName,
                                                      PlantAddress = bp.StrPlantAddress,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<Message> GetPlantByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Plant List by Client Id: ",
                    data = await Task.FromResult((from bp in _context.TblPlant
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetPlantDTO()
                                                  {
                                                      PlantId = bp.IntPlantId,
                                                      PlantCode = bp.StrPlantCode,
                                                      PlantName = bp.StrPlantName,
                                                      PlantAddress = bp.StrPlantAddress,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
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
        public async Task<object> CreatePlant(CreatePlantDTO postPlant)
        {
            try
            { 
                var detalis = new TblPlant
                {
                    
                    StrPlantCode = postPlant.PlantName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrPlantName = postPlant.PlantName,
                    StrPlantAddress = postPlant.PlantAddress,
                    IntBusinessUnitId = postPlant.BusinessUnitId,
                    IntClientId = postPlant.ClientId,
                    IntActionBy = postPlant.ActionBy,
                    DteLastActionDateTime = DateTime.UtcNow
                };
                await _context.TblPlant.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblPlant
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntPlantId == detalis.IntPlantId
                              select new GetPlantDTO()
                              {
                                  PlantId = bp.IntPlantId,
                                  PlantCode = bp.StrPlantCode,
                                  PlantName = bp.StrPlantName,
                                  PlantAddress = bp.StrPlantAddress,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Plant Created Successfully.",
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
        public async Task<object> EditPlant(EditPlantDTO plant)
        {
            try
            {
                TblPlant data = _context.TblPlant.First(x => x.IntPlantId == plant.PlantId);

                data.IntPlantId = plant.PlantId;
                data.StrPlantName = plant.PlantName;
                data.StrPlantAddress = plant.PlantCode;
                data.IntActionBy = plant.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;

                _context.TblPlant.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblPlant
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntPlantId == plant.PlantId
                              select new GetPlantDTO()
                              {
                                  PlantId = bp.IntPlantId,
                                  PlantCode = bp.StrPlantCode,
                                  PlantName = bp.StrPlantName,
                                  PlantAddress = bp.StrPlantAddress,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Plant Edited Successfully.",
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
        public async Task<object> CancelPlant(CancelPlantDTO plant)
        {
            try
            {
                TblPlant data = _context.TblPlant.First(x => x.IntPlantId == plant.PlantId);

                data.IntActionBy = plant.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;

                _context.TblPlant.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblPlant
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntPlantId == plant.PlantId
                              select new GetPlantDTO()
                              {
                                  PlantId = bp.IntPlantId,
                                  PlantCode = bp.StrPlantCode,
                                  PlantName = bp.StrPlantName,
                                  PlantAddress = bp.StrPlantAddress,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Plant Cancelled Successfully.",
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
