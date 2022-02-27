using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblBusinessUnitSalesOrganizationIncoterms
    {
        public long IntConfigId { get; set; }
        public long IntClientId { get; set; }
        public long IntBusinessUintId { get; set; }
        public string StrBusinessUnitName { get; set; }
        public long IntIncotermsId { get; set; }
        public string StrIncotermsName { get; set; }
        public long IntSalesOrganizationId { get; set; }
        public string StrSalesOrganizationName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
