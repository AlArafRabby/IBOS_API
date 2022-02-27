using ControlPanel.DTO.Thana;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IThana
    {
        Task<Message> GetThanaAll();
        Task<Message> GetThanaById(long Id);
    }
}
