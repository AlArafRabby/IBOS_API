using ControlPanellNew.Helper;
using ControlPanel.DTO.ShipPoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IShipPoint
    {
        Task<Message> GetShipPointAll();
        Task<Message> GetShipPointById(long Id);
        Task<Message> GetShipPointByClientId(long CId); 
        Task<Message> GetShipPointByUnitId(long UId);
    }
}
