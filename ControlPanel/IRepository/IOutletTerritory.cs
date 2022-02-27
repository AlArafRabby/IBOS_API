using ControlPanel.DTO.OutletTerritory;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IOutletTerritory
    {
        Task<Message> GetOutletTerritoryAll();
        Task<Message> GetOutletTerritoryById(long Id);
        Task<Message> GetOutletTerritoryByClientId(long CId);
        Task<Message> GetOutletTerritoryByUnitId(long UId);
        Task<object> CreateOutletTerritory(CreateOutletTerritoryDTO postOutletTerritory);
        Task<object> EditOutletTerritory(EditOutletTerritoryDTO OutletTerritory);
        Task<object> CancelOutletTerritory(CancelOutletTerritoryDTO OutletTerritory);
    }
}
