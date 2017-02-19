using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspMvcWithWebApi.Controllers.API
{
    public class DefaultWithReadWriteController : ApiController
    {
        // GET: api/DefaultWithReadWrite
        // [HttpGet] -> no need to use because of convention : action name start with Get
        public IEnumerable<string> Get()
        {
            return new string[] { "1", "2" };
        }

        // GET: api/DefaultWithReadWrite/5
        // [HttpGet] -> no need to use because of convention : action name start with Get
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DefaultWithReadWrite
        // [HttpPost] -> no need to use because of convention : action name start with Post
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DefaultWithReadWrite/5
        // [HttpPut] -> no need to use because of convention : action name start with Put
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DefaultWithReadWrite/5
        // [HttpDelete] -> no need to use because of convention : action name start with Delete
        public void Delete(int id)
        {
        }
    }
}
