using ControlPanel.DTO.AccountingPostingType;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IAccountingPostingType
    {
        Task<Message> GetAccountingPostingTypeAll();
        Task<Message> GetAccountingPostingTypeById(long Id);
    }
}
