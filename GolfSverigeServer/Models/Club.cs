using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfSverigeServer.Models
{
    public class Club
    {
        public Guid GUID { get; set; }
        public string Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
    }
}