using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ITransportZone
    {
        Task<Message> GetTransportZoneAll();
        Task<Message> GetTransportZoneById(long Id);
        Task<Message> GetTransportZoneByClientId(long CId);
        Task<Message> GetTransportZoneByUnitId(long UId);
    }
}
