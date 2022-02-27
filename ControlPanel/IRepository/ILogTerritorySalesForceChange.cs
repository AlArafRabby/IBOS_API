using ControlPanel.DTO.LogTerritorySalesForceChange;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ILogTerritorySalesForceChange
    {
        Task<Message> GetLogTerritorySalesForceChangeAll();
        Task<Message> GetLogTerritorySalesForceChangeById(long Id);
        Task<Message> GetLogTerritorySalesForceChangeByClientId(long CId);
        Task<Message> GetLogTerritorySalesForceChangeByUnitId(long UId);
        Task<Message> CreateLogTerritorySalesForceChange(CreateLogTerritorySalesForceChangeDTO postLogTerritorySalesForceChange);
        Task<Message> EditLogTerritorySalesForceChange(EditLogTerritorySalesForceChangeDTO LogTerritorySalesForceChange);
        Task<Message> CancelLogTerritorySalesForceChange(CancelLogTerritorySalesForceChangeDTO LogTerritorySalesForceChange);
    }
}
