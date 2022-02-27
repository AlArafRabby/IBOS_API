using ControlPanel.DTO.District;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface IDistrict
    {
        Task<Message> GetDistrictAll();
        Task<Message> GetDistrictId(long Id);
        Task<Message> GetDistrictByClientId(long CId);
        Task<object> CreateDistrict(CreateDistrictDTO postDistrict);
        Task<object> EditDistrict(EditDistrictDTO district);
        Task<object> CancelDistrict(CancelDistrictDTO district);
    }
}
