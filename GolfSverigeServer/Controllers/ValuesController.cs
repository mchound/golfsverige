using GolfSverigeServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GolfSverigeServer.Database;

namespace GolfSverigeServer.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<District> Get()
        {
            IEnumerable<District> districts = new List<District>();
            using (Repository db = new Repository())
            {
                districts = db.GetDistricts().ToList();
            }

            return districts;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}