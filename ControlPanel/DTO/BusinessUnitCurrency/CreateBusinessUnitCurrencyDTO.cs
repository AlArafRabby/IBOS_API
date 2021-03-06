using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BusinessUnitCurrency
{
    public class CreateBusinessUnitCurrencyDTO
    {
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long CurrencyId { get; set; }
        [Required]
        public bool BaseCurrency { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
    }
}
