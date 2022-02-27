using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblAccountCategory
    {
        public long IntAccountCategoryId { get; set; }
        public long IntClientId { get; set; }
        public long IntAccountGroupId { get; set; }
        public long IntAccountClassId { get; set; }
        public string StrAccountCategoryCode { get; set; }
        public string StrAccountCategoryName { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
