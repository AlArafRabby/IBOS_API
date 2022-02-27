using ControlPanel.DTO;
using ControlPanel.DTO.DistributionChannel;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IDistributionChannel
    {
        Task<Message> GetDistributionChannelAll();
        Task<Message> GetDistributionChannelById(long Id);
        Task<Message> GetDistributionChannelByUnitId(long UId);
        Task<Message> GetDistributionChannelByAreaId(long AId);
        Task<Message> GetDistributionChannelByClientId(long CId);
        Task<object> CreateDistributionChannel(CreateDistributionChannelDTO postDistributionChannel);
        Task<object> EditDistributionChannel(EditDistributionChannelDTO distributionChannel);
        Task<object> CancelDistributionChannel(CancelDistributionChannelDTO distributionChannel);
    }

    
}
