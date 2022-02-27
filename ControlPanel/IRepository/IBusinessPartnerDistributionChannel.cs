using ControlPanel.DTO.BusinessPartnerDistributionChannel;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessPartnerDistributionChannel
    {
        Task<Message> GetBusinessPartnerDistributionChannelAll();
        Task<Message> GetBusinessPartnerDistributionChannelById(long Id);
        Task<Message> GetBusinessPartnerDistributionChannelByClientId(long CId);
        Task<object> CreateBusinessPartnerDistributionChannel(CreateBusinessPartnerDistributionChannelDTO postBusinessPartnerDistributionChannel);
        Task<object> EditBusinessPartnerDistributionChannel(EditBusinessPartnerDistributionChannelDTO putBusinessPartnerDistributionChannel);
        Task<object> CancelBusinessPartnerDistributionChannel(CancelBusinessPartnerDistributionChannelDTO putBusinessPartnerDistributionChannel);
    }
}
