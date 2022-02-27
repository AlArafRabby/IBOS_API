using ControlPanel.DTO;
using ControlPanel.DTO.BusinessPartner;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartner
    {
        Task<Message> GetBusinessPartnerAll();
        Task<Message> GetBusinessPartnerId(long Id);
        Task<Message> GetBusinessPartnerByClientId(long CId);
        Task<object> CreateBusinessPartner(CreateBusinessPartnerDTO postBusinessPartner);
        Task<object> EditBusinessPartner(EditBusinessPartnerDTO businesspartner);
        Task<object> CancelBusinessPartner(CancelBusinessPartnerDTO businesspartner);
    }
}
