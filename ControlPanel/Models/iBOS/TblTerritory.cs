using System;
using System.Collections.Generic;

namespace ControlPanel.Models.iBOS
{
    public partial class TblTerritory
    {
        public long IntTerritoryId { get; set; }
        public long IntClientId { get; set; }
        public string StrTerritoryCode { get; set; }
        public string StrTerritoryName { get; set; }
        public long IntTerritoryTypeId { get; set; }
        public long IntBusinessUnitId { get; set; }
        public long IntParentTerritoryId { get; set; }
        public long IntPlantId { get; set; }
        public long? IntCountryId { get; set; }
        public string StrCountryName { get; set; }
        public long IntDivision { get; set; }
        public string StrDivision { get; set; }
        public long IntDistirct { get; set; }
        public string StrDistirct { get; set; }
        public long IntThana { get; set; }
        public string StrThana { get; set; }
        public string StrAddress { get; set; }
        public long IntActionBy { get; set; }
        public DateTime DteLastActionDateTime { get; set; }
        public DateTime DteServerDateTime { get; set; }
        public bool? IsActive { get; set; }
    }
}
