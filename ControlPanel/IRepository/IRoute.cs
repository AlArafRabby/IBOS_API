using ControlPanel.DTO.Route;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IRoute
    {
        Task<Message> GetRouteAll();
        Task<Message> GetRouteById(long Id);
        Task<Message> GetRouteByClientId(long CId);
        Task<Message> GetRouteByUnitId(long UId);
        Task<object> CreateRoute(CreateRouteDTO postRoute);
        Task<object> EditRoute(EditRouteDTO Route);
        Task<object> CancelRoute(CancelRouteDTO Route);
    }
}
