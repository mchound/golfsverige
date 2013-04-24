using System;
using System.Collections.Generic;

namespace GolfSverigeServer.Models
{
    public class District
    {
        public Guid GUID { get; set; }
        public string Name { get; set; }
        public IEnumerable<Club> Clubs { get; set; }

        public District()
        {
            
        }
    }
}