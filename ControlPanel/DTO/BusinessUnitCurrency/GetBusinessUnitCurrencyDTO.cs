using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessUnitCurrency
{
    public class GetBusinessUnitCurrencyDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public bool BaseCurrency { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
