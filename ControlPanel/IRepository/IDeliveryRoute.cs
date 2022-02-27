using ControlPanel.DTO.DeliveryRoute;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IDeliveryRoute
    {
        Task<Message> GetDeliveryRouteAll();
        Task<Message> GetDeliveryRouteById(long Id);
        Task<Message> GetDeliveryRouteByClientBusinessUnitId(long CId, long UId);

        Task<object> CreateDeliveryRoute(CreateDeliveryRouteDTO postDeliveryRoute);
        Task<object> EditDeliveryRoute(EditDeliveryRouteDTO postDeliveryRoute);
        Task<object> CancelDeliveryRoute(CancelDeliveryRouteDTO postDeliveryRoute);
    }
}
