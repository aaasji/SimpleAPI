using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace SimpleAPI
{
    [ApiController]
    [Route("api/[controller]")]
    
        public class ValuesController : ControllerBase
         {
        // GET: api/values
          [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Sanjay", "Arora" };
        }

        // GET: api/values/5
        [HttpGet]
        public string Get(int id)
        {
            return "AshishArora";
        }

        // POST: api/values
        // public void Post([FromBody]string value)
        // {
        // }

        // // PUT: api/values/5
        // public void Put(int id, [FromBody]string value)
        // {
        // }

        // // DELETE: api/values/5
        // public void Delete(int id)
        // {
        // }
    }
    
}