using ControlPanel.DTO.SoldToPartnerShipToPartner;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ISoldToPartnerShipToPartner
    {
        Task<Message> GetSoldToPartnerShipToPartnerAll();
        Task<Message> GetSoldToPartnerShipToPartnerById(long Id);
        Task<Message> GetSoldToPartnerShipToPartnerByUnitId(long UId);
        Task<Message> GetSoldToPartnerShipToPartnerByClientId(long CId);
        Task<object> CreateSoldToPartnerShipToPartner(CreateSoldToPartnerShipToPartnerDTO postSoldToPartnerShipToPartner);
        Task<object> EditSoldToPartnerShipToPartner(EditSoldToPartnerShipToPartnerDTO SoldToPartnerShipToPartner);
        Task<object> CancelSoldToPartnerShipToPartner(CancelSoldToPartnerShipToPartnerDTO SoldToPartnerShipToPartner);
    }
}
