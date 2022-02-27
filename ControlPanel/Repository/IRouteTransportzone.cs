using ControlPanel.DTO.RouteTransportzone;
using ControlPanellNew.Helper;
using System.Threading.Tasks;

namespace ControlPanel.Repository
{
    public interface IRouteTransportzone
    {
        Task<Message> GetRouteTransportzoneAll();
        Task<Message> GetRouteTransportzoneById(long Id);
        Task<Message> GetRouteTransportzoneByClientId(long CId);
        Task<Message> GetRouteTransportzoneByUnitId(long UId);
        Task<Message> GetRouteTransportzoneByTransportzoneId(long TZId);
        Task<Message> GetRouteTransportzoneByRouteId(long RId);
        Task<object> CreateRouteTransportzone(CreateRouteTransportzoneDTO postRouteTransportzone);
        Task<object> EditRouteTransportzone(EditRouteTransportzoneDTO RouteTransportzone);
        Task<object> CancelRouteTransportzone(CancelRouteTransportzoneDTO RouteTransportzone);
    }
}