using ControlPanel.DTO.BusinessPartnerShipPoint;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IBusinessPartnerShipPoint
    {
        Task<Message> GetBusinessPartnerShipPointAll();
        Task<Message> GetBusinessPartnerShipPointById(long Id);
        Task<Message> GetBusinessPartnerShipPointByClientId(long CId);
        Task<Message> GetBusinessPartnerShipPointByUnittId(long UId);
        Task<object> CreateBusinessPartnerShipPoint(CreateBusinessPartnerShipPointDTO postBusinessPartnerShipPoint);
        Task<object> EditBusinessPartnerShipPoint(EditBusinessPartnerShipPointDTO putBusinessPartnerShipPoint);
        Task<object> CancelBusinessPartnerShipPoint(CancelBusinessPartnerShipPointDTO putBusinessPartnerShipPoint);
    }
}
