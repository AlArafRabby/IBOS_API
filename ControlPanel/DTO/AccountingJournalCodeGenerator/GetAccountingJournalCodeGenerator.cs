using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.AccountingJournalCodeGenerator
{
    public class GetAccountingJournalCodeGenerator
    {
        public long ClientId { get; set; }
        public long BusinessUintId { get; set; }
        public long AccountingJournalTypeId { get; set; }
        public string AccountingJournalTypeName { get; set; }
        public long Year { get; set; }
        public long Month { get; set; }
        public long Count { get; set; }
    }
}
