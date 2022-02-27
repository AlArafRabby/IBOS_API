using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.ElasticSearch
{
    public class CreateLogElasticSearchDTO
    {
        public string LogInfo { get; set; }
        public DateTime CurrentDateTime { get; set; }
        public string ErrorLog { get; set; }
        


    }
}
