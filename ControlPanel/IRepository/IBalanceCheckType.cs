using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IBalanceCheckType
    {
        Task<Message> GetBalanceCheckTypeAll();
    }
}
