using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IVoucherCode
    {
        Task<string> GetVoucherCode(long ClientId, long BusinessUnitId, long AccountingJournalTypeId);
    }
}
