﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampReserVation
{
     public  class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public Location(int locationId,string locationName)
        {
            LocationId = locationId;
            LocationName = locationName;
        }
    }
}
