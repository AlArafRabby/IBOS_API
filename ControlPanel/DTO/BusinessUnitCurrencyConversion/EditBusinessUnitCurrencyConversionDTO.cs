using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessUnitCurrencyConversion
{
    public class EditBusinessUnitCurrencyConversionDTO
    {
        [Required]
        public int ConfigId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long BaseCurrencyId { get; set; }
        [Required]
        public long AlternateCurrencyId { get; set; }
        [Required]
        public decimal ConversionRate { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
