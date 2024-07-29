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
        [Route("List")]
        public IEnumerable<string> List()
        {
            return new string[] { "Sanjay", "Arora" };
        }

        // GET: api/values/5
        [HttpGet]
        [Route("Get")]
        public string Get(int id)
        {
            return "AshishArora";
        }

       
    }
    
}