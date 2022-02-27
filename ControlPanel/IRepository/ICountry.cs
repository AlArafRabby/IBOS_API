using ControlPanel.DTO.Country;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
    public interface ICountry
    {
        Task<Message> GetCountryAll();
        Task<Message> GetCountryId(long Id);
        Task<Message> GetCountryByClientId(long CId);
        Task<object> CreateCountry(CreateCountryDTO postCountry);
        Task<object> EditCountry(EditCountryDTO Country);
        Task<object> CancelCountry(CancelCountryDTO Country);

    }
}
