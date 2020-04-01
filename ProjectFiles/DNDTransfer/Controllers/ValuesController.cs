using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;//extension method

namespace DNDTransfer.Controllers
{
    [Authorize]
    public class ValuesController : ApiController//api since this inherits from API controller
    {
        // GET api/values
        public IEnumerable<string> Get()//return like it is a method, still wrapped in http response codes
        {

            string userId = RequestContext.Principal.Identity.GetUserId();
            return new string[] { "value1", "value2", userId };
        }
        /*
        public IHttpActionResult Get()//another way we can do it
        {

            string userId = RequestContext.Principal.Identity.GetUserId();
            return Ok(new string[] { "value1", "value2", userId });
        }*/

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
