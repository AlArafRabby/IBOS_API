using ControlPanel.DTO.DepreciationType;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IDepreciationType
    {
        Task<Message> GetDepreciationTypeAll();
        Task<Message> GetDepreciationTypeById(long Id);

    }
}
