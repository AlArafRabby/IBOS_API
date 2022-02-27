using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountingJournalTypeBusinessUnit
{
    public class EditAccountingJournalTypeBusinessUnitDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long AccountingJournalTypeId { get; set; }
        [Required]
        public string Prefix { get; set; }
        [Required]
        public bool IsYear { get; set; }
        [Required]
        public bool IsMonth { get; set; }
        [Required]
        public long MonthlyNumberLength { get; set; }
        [Required]
        public long YearlyNumberLength { get; set; }
        [Required]
        public bool IsMonthlyNumberChange { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
