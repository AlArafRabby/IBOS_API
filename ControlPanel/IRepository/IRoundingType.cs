using ControlPanel.DTO.RoundingType;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IRoundingType
    {
        Task<Message> GetRoundingTypeAll();
        Task<Message> GetRoundingTypeById(long Id);
    }
}
