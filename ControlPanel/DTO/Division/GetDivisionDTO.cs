using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Division
{
    public class GetDivisionDTO
    {
        public long DivisionId { get; set; }
        public string Divition { get; set; }
        public long CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsActive { get; set; }
        public string DivitionBanglaName { get; set; }
    }
}
