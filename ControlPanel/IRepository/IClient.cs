using ControlPanel.DTO.Client;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IClient
    {
        Task<Message> GetClientAll();
        Task<Message> GetClientById(long Id);
        Task<object> CreateClient(CreateClientDTO postClient);
        Task<object> EditClient(EditClientDTO client);
        Task<object> CancelClient(CancelClientDTO client);
        
    }
}
