using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.IItemUOMConversion
{
    public class GetIItemUOMConversionDTO
    {
        public long Id { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long BaseUom { get; set; }
        public long ConvertedUom { get; set; }
        public decimal ConversionRate { get; set; }
        public DateTime LastActionDateTime { get; set; }
        public long ActionBy { get; set; }
    }
}
