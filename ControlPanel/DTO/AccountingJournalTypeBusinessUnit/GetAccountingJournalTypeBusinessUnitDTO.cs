using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountingJournalTypeBusinessUnit
{
    public class GetAccountingJournalTypeBusinessUnitDTO
    {
        [Required]
        public long ConfigId { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public string AccountingJournalTypeName { get; set; }
        public string Prefix { get; set; }
        public bool IsYear { get; set; }
        public bool IsMonth { get; set; }
        public long MonthlyNumberLength { get; set; }
        public long YearlyNumberLength { get; set; }
        public bool IsMonthlyNumberChange { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
