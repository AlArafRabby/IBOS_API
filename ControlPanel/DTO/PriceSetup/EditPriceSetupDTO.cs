using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.PriceSetup
{
    public class EditPriceSetupDTO
    {
        [Required]
        public long PriceConditionId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ConditionTypeId { get; set; }
        [Required]
        public string ConditionTypeName { get; set; }
        [Required]
        public long ConditionReffId { get; set; }
        [Required]
        public long ItemId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? EndDate { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
