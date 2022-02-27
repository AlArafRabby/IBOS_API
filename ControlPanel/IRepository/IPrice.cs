using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IPrice
    {
        Task<Message> GetPrices(long BusinessId, long intPartner, long intItemId, DateTime dtePricingDate, long intTerr, long ChannelId, long sorgid);
        
    }
}
