using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Territory
{
    public class GetTerritoryDTO
    {
        public long TerritoryId { get; set; }
        public string TerritoryCode { get; set; }
        public string TerritoryName { get; set; }
        public long TerritoryTypeId { get; set; }
        public string TerritoryTypeName { get; set; }
        public long ClientId { get; set; }
        public string ClientName { get; set; }
        public long BusinessUnitId { get; set; }
        public string BusinessUnitName { get; set; }
        //public long ParentTerritoryId { get; set; }
        //public string ParentTerritoryName { get; set; }
        public long PlantId { get; set; }
        public string PlantName { get; set; }
        public long? CountryId { get; set; }
        public string CountryName { get; set; }
        public long Division { get; set; }
        public string DivisionName { get; set; }
        public long Distirct { get; set; }
        public string DistirctName { get; set; }
        public long Thana { get; set; }
        public string ThanaName { get; set; }
        public string Address { get; set; }
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
    }
}
