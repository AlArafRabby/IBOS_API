using ControlPanel.DTO.Plant;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IPlant
    {
        Task<Message> GetPlantAll();
        Task<Message> GetPlantById(long Id);
        Task<Message> GetPlantByClientId(long CId);
        Task<object> CreatePlant(CreatePlantDTO postPlant);
        Task<object> EditPlant(EditPlantDTO plant);
        Task<object> CancelPlant(CancelPlantDTO plant);
    }
}
