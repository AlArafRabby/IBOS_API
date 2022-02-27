using ControlPanel.DTO.UnitOfMeasurement;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IUnitOfMeasurement
    {
        Task<Message> GetUnitOfMeasurementAll();
        Task<Message> GetUnitOfMeasurementById(long Id);
        Task<Message> GetUnitOfMeasurementByUnitId(long UId);
        Task<Message> GetUnitOfMeasurementByClientId(long CId);
        Task<object> CreateUnitOfMeasurement(CreateUnitOfMeasurementDTO postUnitOfMeasurement);
        Task<object> EditUnitOfMeasurement(EditUnitOfMeasurementDTO UnitOfMeasurement);
        Task<object> CancelUnitOfMeasurement(CancelUnitOfMeasurementDTO UnitOfMeasurement);
    }
}
