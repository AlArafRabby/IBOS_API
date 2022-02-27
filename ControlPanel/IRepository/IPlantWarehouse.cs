using ControlPanel.DTO.PlantWarehouse;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IPlantWarehouse
    {
        Task<Message> GetPlantWarehouseAll();
        Task<Message> GetPlantWarehouseById(long Id);
        Task<Message> GetPlantWarehouseByClientId(long CId);
        Task<object> CreatePlantWarehouse(CreatePlantWarehouseDTO postPlantWarehouse);
        Task<object> EditPlantWarehouse(EditPlantWarehouseDTO PlantWarehouse);
        Task<object> CancelPlantWarehouse(CancelPlantWarehouseDTO PlantWarehouse);
    }
}
