using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.IItemUOMConversion
{
    public class CreateIItemUOMConversionDTO
    {
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public long BaseUom { get; set; }
        [Required]
        public long ConvertedUom { get; set; }
        [Required]
        public decimal ConversionRate { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
