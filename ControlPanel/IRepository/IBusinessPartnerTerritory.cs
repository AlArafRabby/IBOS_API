using ControlPanel.DTO.BusinessArea;
using ControlPanel.DTO.BusinessPartnerTerritory;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartnerTerritory
    {

        Task<Message> GetBusinessPartnerTerritoryAll();
        Task<Message> GetBusinessPartnerTerritoryById(long Id);
        Task<Message> GetBusinessPartnerTerritoryByClientId(long CId);
        Task<object> CreateBusinessPartnerTerritory(CreateBusinessPartnerTerritoryDTO postBusinessPartnerTerritory);
        Task<object> EditBusinessPartnerTerritory(EditBusinessPartnerTerritoryDTO putBusinessPartnerTerritory);
        Task<object> CancelBusinessPartnerTerritory(CancelBusinessPartnerTerritoryDTO putBusinessPartnerTerritory);
    }
}
