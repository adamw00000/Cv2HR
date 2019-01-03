﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CV2HR.Models
{
    public class JobOfferCreateViewModel : JobOffer
    {
        public IEnumerable<Company> Companies { get; set; }
    }
}
