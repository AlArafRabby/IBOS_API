using ControlPanel.DTO.TerritoryType;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ITerritoryType
    {
        Task<Message> GetTerritoryTypeAll();
        Task<Message> GetTerritoryTypeById(long Id);
        Task<Message> GetTerritoryTypeByUnitId(long UId);
        Task<Message> GetTerritoryTypeByClientId(long CId);
        Task<object> CreateTerritoryType(CreateTerritoryTypeDTO postTerritoryType);
        Task<object> EditTerritoryType(EditTerritoryTypeDTO TerritoryType);
        Task<object> CancelTerritoryType(CancelTerritoryTypeDTO TerritoryType);
    }
}
