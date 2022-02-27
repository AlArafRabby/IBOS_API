﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.DTO.SoldToPartnerShipToPartner
{
    public class CancelSoldToPartnerShipToPartnerDTO
    {
        [Required]
        public long ConfigId { get; set; }
        [Required]
        public long ActionBy { get; set; }
    }
}
