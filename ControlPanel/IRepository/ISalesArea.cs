using ControlPanel.DTO.SalesArea;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ISalesArea
    {
        Task<Message> GetSalesAreaAll();
        Task<Message> GetSalesAreaById(long Id);
        Task<Message> GetSalesAreaByUnitId(long UId);
        Task<Message> GetSalesAreaByClientId(long CId);
        Task<object> CreateSalesArea(CreateSalesAreaDTO postSalesArea);
        Task<object> EditSalesArea(EditSalesAreaDTO SalesArea);
        Task<object> CancelSalesArea(CancelSalesAreaDTO SalesArea);
    }
}
