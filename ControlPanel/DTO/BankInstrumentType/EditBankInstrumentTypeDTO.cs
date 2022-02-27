using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.BankInstrumentType
{
    public class EditBankInstrumentTypeDTO
    {
        [Required]
        public long InstrumentId { get; set; }
        [Required]
        public string InstrumentName { get; set; }
        [Required]
        public long ActionBy { get; set; }
        [Required]
        public DateTime LastActionDateTime { get; set; }
        [Required]
        public bool? IsActive { get; set; }
    }
}
