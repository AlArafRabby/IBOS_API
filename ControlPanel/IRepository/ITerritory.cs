using ControlPanel.DTO.Territory;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ITerritory
    {
        Task<Message> GetTerritoryAll();
        Task<Message> GetTerritoryById(long Id);
        Task<Message> GetTerritoryByUnitId(long UId);
        Task<Message> GetTerritoryByClientId(long CId);
        Task<Message> GetTerritoryByTerritoryTypeId(long TTId, long UId);
        Task<Message> GetTerritoryByParentTerritoryId(long PTId, long UId);
        Task<object> CreateTerritory(CreateTerritoryDTO postTerritory);
        Task<object> EditTerritory(EditTerritoryDTO Territory);
        Task<object> CancelTerritory(CancelTerritoryDTO Territory);
    }
}
