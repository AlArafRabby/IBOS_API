using ControlPanellNew.Helper;
using ControlPanel.DTO.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IVehicle
    {
        Task<Message> GetVehicleAll();
        Task<Message> GetVehicleById(long Id);
        Task<Message> GetVehicleByUnitId(long UId);
        Task<Message> GetVehicleByClientId(long CId);
        Task<object> CreateVehicle(CreateVehicleDTO postVehicle);
        Task<object> EditVehicle(EditVehicleDTO putVehicle);
        Task<object> CancelVehicle(CancelVehicleDTO putVehicle);
    }
}
