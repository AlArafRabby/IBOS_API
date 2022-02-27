using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.Territory
{
    public class CreateTerritoryDTO
    {
        [Required]
        public string TerritoryName { get; set; }
        [Required]
        public long ClientId { get; set; }
        [Required]
        public long TerritoryTypeId { get; set; }
        [Required]
        public long BusinessUnitId { get; set; }
        [Required]
        public long ParentTerritoryId { get; set; }
        [Required]
        public long PlantId { get; set; }
        [Required]
        public long? CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
        [Required]
        public long Division { get; set; }
        [Required]
        public string DivisionName { get; set; }
        [Required]
        public long Distirct { get; set; }
        [Required]
        public string DistirctName { get; set; }
        [Required]
        public long Thana { get; set; }
        [Required]
        public string ThanaName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public long ActionBy { get; set; }
        public DateTime LastActionDateTime { get; set; }
   
    }
}
