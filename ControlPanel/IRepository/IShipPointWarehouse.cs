using ControlPanel.DTO.ShipPointWarehouse;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IShipPointWarehouse
    {
        Task<Message> GetShipPointWarehouseAll();
        Task<Message> GetShipPointWarehouseById(long Id);
        Task<Message> GetShipPointWarehouseByClientId(long CId);
        Task<Message> GetShipPointWarehouseByUnitId(long UId);
        Task<object> CreateShipPointWarehouse(CreateShipPointWarehouseDTO postShipPointWarehouse);
        Task<object> EditShipPointWarehouse(EditShipPointWarehouseDTO ShipPointWarehouse);
        Task<object> CancelShipPointWarehouse(CancelShipPointWarehouseDTO ShipPointWarehouse);
    }
}
