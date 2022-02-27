using ControlPanel.DTO.Outlet;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IOutlet
    {
        Task<Message> GetOutletAll();
        Task<Message> GetOutletById(long Id);
        Task<Message> GetOutletByClientId(long CId);
        Task<object> CreateOutlet(CreateOutletDTO postOutlet);
        Task<object> EditOutlet(EditOutletDTO outlet);
        Task<object> CancelOutlet(CancelOutletDTO outlet);
    }
}
