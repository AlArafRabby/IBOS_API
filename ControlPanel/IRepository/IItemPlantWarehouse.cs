using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlPanel.DTO.ItemPlantWarehouse;
using ControlPanellNew.Helper;

namespace ControlPanel.IRepository
{
    public interface IItemPlantWarehouse
    {
        Task<Message> GetItemPlantWarehouseAll();
        Task<Message> GetItemPlantWarehouseById(long Id);
        Task<Message> GetItemPlantWarehouseByClientId(long CId);
        Task<Message> GetItemPlantWarehouseByUnitId(long UId);
        Task<object> CreateItemPlantWarehouse(CreateItemPlantWarehouseDTO postItemPlantWarehouse);
        Task<object> EditItemPlantWarehouse(EidtItemPlantWarehouseDTO putItemPlantWarehouse);
        Task<object> CancelItemPlantWarehouse(CancelItemPlantWarehouseDTO putItemPlantWarehouse);
    }
}
