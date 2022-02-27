using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessUnitCurrencyConversion
{
    public class GetBusinessUnitCurrencyConversionDTO
    {
        [Required]
        public int ConfigId { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BaseCurrencyId { get; set; }
        public string BaseCurrencyName { get; set; }
        public long AlternateCurrencyId { get; set; }
        public string AlternateCurrencyName { get; set; }
        public decimal ConversionRate { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
