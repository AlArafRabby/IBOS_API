using ControlPanel.DTO.BusinessArea;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBusinessArea
    {
        Task<Message> GetBusinessAreaAll();
        Task<Message> GetBusinessAreaById(long Id);
        Task<Message> GetBusinessAreaByClientId(long CId);
        Task<object> CreateBusinessArea(CreateBusinessAreaDTO postBusinessUnit);
        Task<object> EditBusinessArea(EditBusinessAreaDTO businessUnit);
        Task<object> CancelBusinessArea(CancelBusinessAreaDTO businessArea);

    }
}
