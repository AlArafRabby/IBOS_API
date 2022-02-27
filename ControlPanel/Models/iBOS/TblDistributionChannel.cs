using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblDistributionChannel
    {
        public long IntDistributionChannelId { get; set; }
        public long IntClientId { get; set; }
        public string StrDistributionChannelCode { get; set; }
        public string StrDistributionChannelName { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntBusinessAreaId { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
