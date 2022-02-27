using ControlPanel.DTO.Currency;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface ICurrency
    {
        Task<Message> GetCurrencyAll();
        Task<Message> GetCurrencyById(long Id);
    }
}
