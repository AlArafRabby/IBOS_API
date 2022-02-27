using ControlPanel.DbContexts;
using ControlPanel.DTO.SalesOrganization;
using ControlPanel.DTO.Territory;
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
    public class Territory : ITerritory
    {
        public readonly iBOSContext _context;
        public Territory(iBOSContext context)
        {
            _context = context;
        }
        public async Task<Message> GetTerritoryAll()
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Business Area List ",
                    data = await Task.FromResult((from bp in _context.TblTerritory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true
                                                   select new GetTerritoryDTO()
                                                   {
                                                       TerritoryId = bp.IntTerritoryId,
                                                       TerritoryCode = bp.StrTerritoryCode,
                                                       TerritoryName = bp.StrTerritoryName,
                                                       TerritoryTypeId = bp.IntTerritoryTypeId,
                                                       TerritoryTypeName = trp.StrTerritoryTypeName,
                                                       ClientId = bp.IntClientId,
                                                       ClientName = c.StrClientName,
                                                       BusinessUnitId = b.IntBusinessUnitId,
                                                       BusinessUnitName = b.StrBusinessUnitName,
                                                       PlantId = bp.IntPlantId,
                                                       PlantName = p.StrPlantName,
                                                       CountryId = bp.IntCountryId,
                                                       CountryName = bp.StrCountryName,
                                                       Division = bp.IntDivision,
                                                       DivisionName = bp.StrTerritoryName,
                                                       Distirct = bp.IntDistirct,
                                                       DistirctName = bp.StrDistirct,
                                                       Thana = bp.IntThana,
                                                       ThanaName = bp.StrThana,
                                                       Address = bp.StrAddress,
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
        public async Task<Message> GetTerritoryById(long Id)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Territory List by Id: ",
                    data = await Task.FromResult((from bp in _context.TblTerritory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntTerritoryId==Id
                                                  select new GetTerritoryDTO()
                                                  {
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryCode = bp.StrTerritoryCode,
                                                      TerritoryName = bp.StrTerritoryName,
                                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                                      TerritoryTypeName = trp.StrTerritoryTypeName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = bp.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      Division = bp.IntDivision,
                                                      DivisionName = bp.StrTerritoryName,
                                                      Distirct = bp.IntDistirct,
                                                      DistirctName = bp.StrDistirct,
                                                      Thana = bp.IntThana,
                                                      ThanaName = bp.StrThana,
                                                      Address = bp.StrAddress,
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
        public async Task<Message> GetTerritoryByUnitId(long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Territory List by Unit Id: ",
                    data = await Task.FromResult((from bp in _context.TblTerritory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntBusinessUnitId == UId
                                                  select new GetTerritoryDTO()
                                                  {
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryCode = bp.StrTerritoryCode,
                                                      TerritoryName = bp.StrTerritoryName,
                                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                                      TerritoryTypeName = trp.StrTerritoryTypeName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = bp.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      Division = bp.IntDivision,
                                                      DivisionName = bp.StrTerritoryName,
                                                      Distirct = bp.IntDistirct,
                                                      DistirctName = bp.StrDistirct,
                                                      Thana = bp.IntThana,
                                                      ThanaName = bp.StrThana,
                                                      Address = bp.StrAddress,
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
        public async Task<Message> GetTerritoryByClientId(long CId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Territory List by Client Id: ",
                    data = await Task.FromResult((from bp in _context.TblTerritory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntClientId == CId
                                                  select new GetTerritoryDTO()
                                                  {
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryCode = bp.StrTerritoryCode,
                                                      TerritoryName = bp.StrTerritoryName,
                                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                                      TerritoryTypeName = trp.StrTerritoryTypeName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = bp.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      Division = bp.IntDivision,
                                                      DivisionName = bp.StrTerritoryName,
                                                      Distirct = bp.IntDistirct,
                                                      DistirctName = bp.StrDistirct,
                                                      Thana = bp.IntThana,
                                                      ThanaName = bp.StrThana,
                                                      Address = bp.StrAddress,
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
        public async Task<Message> GetTerritoryByTerritoryTypeId(long TTId, long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Territory List by Territory Type Id: ",
                    data = await Task.FromResult((from bp in _context.TblTerritory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntTerritoryTypeId == TTId && bp.IntBusinessUnitId == UId
                                                  select new GetTerritoryDTO()
                                                  {
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryCode = bp.StrTerritoryCode,
                                                      TerritoryName = bp.StrTerritoryName,
                                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                                      TerritoryTypeName = trp.StrTerritoryTypeName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = bp.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      Division = bp.IntDivision,
                                                      DivisionName = bp.StrTerritoryName,
                                                      Distirct = bp.IntDistirct,
                                                      DistirctName = bp.StrDistirct,
                                                      Thana = bp.IntThana,
                                                      ThanaName = bp.StrThana,
                                                      Address = bp.StrAddress,
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
        public async Task<Message> GetTerritoryByParentTerritoryId(long PTId, long UId)
        {
            try
            {
                return new Message
                {
                    status = true,
                    message = "All Territory List by Parent Territory Id: ",
                    data = await Task.FromResult((from bp in _context.TblTerritory
                                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                                  where bp.IsActive == true && bp.IntParentTerritoryId == PTId && bp.IntBusinessUnitId == UId
                                                  select new GetTerritoryDTO()
                                                  {
                                                      TerritoryId = bp.IntTerritoryId,
                                                      TerritoryCode = bp.StrTerritoryCode,
                                                      TerritoryName = bp.StrTerritoryName,
                                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                                      TerritoryTypeName = trp.StrTerritoryTypeName,
                                                      ClientId = bp.IntClientId,
                                                      ClientName = c.StrClientName,
                                                      BusinessUnitId = b.IntBusinessUnitId,
                                                      BusinessUnitName = b.StrBusinessUnitName,
                                                      PlantId = bp.IntPlantId,
                                                      PlantName = p.StrPlantName,
                                                      CountryId = bp.IntCountryId,
                                                      CountryName = bp.StrCountryName,
                                                      Division = bp.IntDivision,
                                                      DivisionName = bp.StrTerritoryName,
                                                      Distirct = bp.IntDistirct,
                                                      DistirctName = bp.StrDistirct,
                                                      Thana = bp.IntThana,
                                                      ThanaName = bp.StrThana,
                                                      Address = bp.StrAddress,
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
        public async Task<object> CreateTerritory(CreateTerritoryDTO postTerritory)
        {
            try
            {
                var detalis = new TblTerritory
                {
                    StrTerritoryCode = postTerritory.TerritoryName.Substring(0, 3) + Convert.ToString(DateTime.Now.Year) + Convert.ToString(DateTime.Now.Month) + Convert.ToString(DateTime.Now.Day),
                    StrTerritoryName = postTerritory.TerritoryName,
                    IntClientId = postTerritory.ClientId,
                    IntTerritoryTypeId = postTerritory.TerritoryTypeId,
                    IntBusinessUnitId = postTerritory.BusinessUnitId,
                    IntParentTerritoryId = postTerritory.ParentTerritoryId,
                    IntPlantId = postTerritory.PlantId,
                    IntCountryId = postTerritory.CountryId,
                    StrCountryName = postTerritory.CountryName,
                    IntDivision = postTerritory.Division,
                    StrDivision = postTerritory.DivisionName,
                    IntDistirct = postTerritory.Distirct,
                    StrDistirct = postTerritory.DistirctName,
                    IntThana = postTerritory.Thana,
                    StrThana = postTerritory.ThanaName,
                    StrAddress = postTerritory.Address,
                    DteLastActionDateTime = DateTime.UtcNow,
                    IntActionBy = postTerritory.ActionBy
                };
                await _context.TblTerritory.AddAsync(detalis);
                await _context.SaveChangesAsync();

                var detalisView = from bp in _context.TblTerritory
                                  join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                                  join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                                  join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                                  join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                                  where bp.IsActive == true && bp.IntTerritoryId == detalis.IntTerritoryId
                                  select new GetTerritoryDTO()
                                  {
                                      TerritoryId = bp.IntTerritoryId,
                                      TerritoryCode = bp.StrTerritoryCode,
                                      TerritoryName = bp.StrTerritoryName,
                                      TerritoryTypeId = bp.IntTerritoryTypeId,
                                      TerritoryTypeName = trp.StrTerritoryTypeName,
                                      ClientId = bp.IntClientId,
                                      ClientName = c.StrClientName,
                                      BusinessUnitId = b.IntBusinessUnitId,
                                      BusinessUnitName = b.StrBusinessUnitName,
                                      PlantId = bp.IntPlantId,
                                      PlantName = p.StrPlantName,
                                      CountryId = bp.IntCountryId,
                                      CountryName = bp.StrCountryName,
                                      Division = bp.IntDivision,
                                      DivisionName = bp.StrTerritoryName,
                                      Distirct = bp.IntDistirct,
                                      DistirctName = bp.StrDistirct,
                                      Thana = bp.IntThana,
                                      ThanaName = bp.StrThana,
                                      Address = bp.StrAddress,
                                      ActionBy = bp.IntActionBy,
                                      LastActionDateTime = bp.DteLastActionDateTime

                                  };

                var successmsg = new Message
            {
                status = true,
                message = "Territory Created Successfully.",
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
        public async Task<object> EditTerritory(EditTerritoryDTO Territory)
        {
            try
            {
                TblTerritory data = _context.TblTerritory.First(x => x.IntTerritoryId == Territory.TerritoryId);

                data.IntTerritoryId = Territory.TerritoryId;
                data.StrTerritoryName = Territory.TerritoryName;
                data.IntTerritoryTypeId = Territory.TerritoryTypeId;
                data.IntParentTerritoryId = Territory.ParentTerritoryId;
                data.IntPlantId = Territory.PlantId;
                data.IntCountryId = Territory.CountryId;
                data.StrCountryName = Territory.CountryName;
                data.IntDivision = Territory.Division;
                data.StrDivision = Territory.DivisionName;
                data.IntDistirct = Territory.Distirct;
                data.StrDistirct = Territory.DistirctName;
                data.IntThana = Territory.Thana;
                data.StrThana = Territory.ThanaName;
                data.StrAddress = Territory.Address;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IntActionBy = Territory.ActionBy;

                _context.TblTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblTerritory
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                              join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == true && bp.IntTerritoryId == Territory.TerritoryId
                              select new GetTerritoryDTO()
                              {
                                  TerritoryId = bp.IntTerritoryId,
                                  TerritoryCode = bp.StrTerritoryCode,
                                  TerritoryName = bp.StrTerritoryName,
                                  TerritoryTypeId = bp.IntTerritoryTypeId,
                                  TerritoryTypeName = trp.StrTerritoryTypeName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = bp.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  CountryId = bp.IntCountryId,
                                  CountryName = bp.StrCountryName,
                                  Division = bp.IntDivision,
                                  DivisionName = bp.StrDivision,
                                  Distirct = bp.IntDistirct,
                                  DistirctName = bp.StrDistirct,
                                  Thana = bp.IntThana,
                                  ThanaName = bp.StrThana,
                                  Address = bp.StrAddress,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Territory Edited Successfully.",
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
        public async Task<object> CancelTerritory(CancelTerritoryDTO Territory)
        {
            try
            {
                TblTerritory data = _context.TblTerritory.First(x => x.IntTerritoryId == Territory.TerritoryId);
                data.IntActionBy = Territory.ActionBy;
                data.DteLastActionDateTime = DateTime.UtcNow;
                data.IsActive = false;
                _context.TblTerritory.Update(data);
                await _context.SaveChangesAsync();

                var detalis = from bp in _context.TblTerritory
                              join b in _context.TblBusinessUnit on bp.IntBusinessUnitId equals b.IntBusinessUnitId
                              join trp in _context.TblTerritoryType on bp.IntTerritoryTypeId equals trp.IntTerritoryTypeId
                              join p in _context.TblPlant on bp.IntPlantId equals p.IntPlantId
                              join c in _context.TblClient on bp.IntClientId equals c.IntClientId
                              where bp.IsActive == false && bp.IntTerritoryId == Territory.TerritoryId
                              select new GetTerritoryDTO()
                              {
                                  TerritoryId = bp.IntTerritoryId,
                                  TerritoryCode = bp.StrTerritoryCode,
                                  TerritoryName = bp.StrTerritoryName,
                                  TerritoryTypeId = bp.IntTerritoryTypeId,
                                  TerritoryTypeName = trp.StrTerritoryTypeName,
                                  ClientId = bp.IntClientId,
                                  ClientName = c.StrClientName,
                                  BusinessUnitId = b.IntBusinessUnitId,
                                  BusinessUnitName = b.StrBusinessUnitName,
                                  PlantId = bp.IntPlantId,
                                  PlantName = p.StrPlantName,
                                  CountryId = bp.IntCountryId,
                                  CountryName = bp.StrCountryName,
                                  Division = bp.IntDivision,
                                  DivisionName = bp.StrTerritoryName,
                                  Distirct = bp.IntDistirct,
                                  DistirctName = bp.StrDistirct,
                                  Thana = bp.IntThana,
                                  ThanaName = bp.StrThana,
                                  Address = bp.StrAddress,
                                  ActionBy = bp.IntActionBy,
                                  LastActionDateTime = bp.DteLastActionDateTime

                              };

                var successmsg = new Message
                {
                    status = true,
                    message = "Territory Cancelled Successfully.",
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
