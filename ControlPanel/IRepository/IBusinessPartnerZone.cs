using ControlPanel.DTO.BusinessPartnerZone;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartnerZone
    {
        Task<Message> GetBusinessPartnerZoneById(long ConfigId);
        Task<Message> GetBusinessPartnerZoneByClientBusinessUnitId(long ClientId, long BusinessUnitId);
        Task<Message> GetBusinessPartnerZoneByClientBusinessUnitPartnerId(long ClientId, long BusinessUnitId, long BusinessPartnerId);
        Task<object> CreateBusinessPartnerZone(CreateBusinessPartnerZoneDTO postBusinessPartnerZone);
        Task<object> EditBusinessPartnerZone(EditBusinessPartnerZoneDTO putBusinessPartnerZone);
        Task<object> CancelBusinessPartnerZone(CancelBusinessPartnerZoneDTO putBusinessPartnerZone);
    }
}
