using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mtg.Repositories;

namespace Mtg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SetController : ControllerBase
    {
        // GET: api/Set
        [HttpGet]
        public object Get()
        {
            var _repo = new SetRepository();

            var set = _repo.GetSet();
            return set;
        }

        // GET: api/Set/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Set
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Set/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
