using GolfSverigeServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GolfSverigeServer.Database
{
    public class Repository : IDisposable
    {
        justGolfEntities db;
        public Repository()
        {
            this.db = new justGolfEntities();
        }

        public IEnumerable<District> GetDistricts()
        {
            return this.db.Districts.Select(d => new District
            {
                GUID = d.GUID,
                Name = d.Name,
                Clubs = d.Clubs.Select(c => new Club
                {
                    GUID = c.GUID,
                    Name = c.Name,
                    Latitude = c.Lat,
                    Longitude = c.Lon
                })
            });
        }

        public void Dispose()
        {
            this.db.Dispose();
        }
    }
}