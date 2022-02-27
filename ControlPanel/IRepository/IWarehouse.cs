using ControlPanel.DTO.Warehouse;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IWarehouse
    {
        Task<Message> GetWarehouseAll();
        Task<Message> GetWarehouseById(long Id);
        Task<Message> GetWarehouseByUnitId(long UId);
        Task<Message> GetWarehouseByClientId(long CId);
        Task<object> CreateWarehouse(CreateWarehouseDTO postWarehouse);
        Task<object> EditWarehouse(EditWarehouseDTO warehouse);
        Task<object> CancelWarehouse(CancelWarehouseDTO warehouse);
    }
}
