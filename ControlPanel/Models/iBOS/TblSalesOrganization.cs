using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblSalesOrganization
    {
        public long IntSalesOrganizationId { get; set; }
        public long IntClientId { get; set; }
        public string StrSalesOrganizationCode { get; set; }
        public string StrSalesOrganizationName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
