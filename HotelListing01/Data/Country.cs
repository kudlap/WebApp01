﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace HotelListing01.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string ShortName { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
