using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface ISalesOrderType
    {
        Task<Message> GetSalesOrderTypeAll();
        Task<Message> GetSalesOrderTypeById(long Id);
        Task<Message> GetSalesOrderTypeByUnitId(long UId);
    }
}
