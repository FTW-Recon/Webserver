using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace FTWWebserver.Controllers.StoreFile
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreFileController : ControllerBase
    {
        // GET: api/<StoreFileController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StoreFileController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StoreFileController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StoreFileController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StoreFileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
