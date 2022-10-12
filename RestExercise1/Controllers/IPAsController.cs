using Microsoft.AspNetCore.Mvc;
using RestExercise1.Managers;
using RestExercise1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestExercise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IPAsController : ControllerBase
    {
        private IPAsManagerList _manager = new IPAsManagerList();
        // GET: api/<IPAsController>
        [HttpGet]
        public IEnumerable<IPA> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<IPAsController>/5
        [HttpGet("{id}")]
        public IPA Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<IPAsController>
        [HttpPost]
        public IPA Post([FromBody] IPA newIPA)
        {
            return _manager.Add(newIPA);
        }

        // PUT api/<IPAsController>/5
        [HttpPut("{id}")]
        public IPA Put(int id, [FromBody] IPA updates)
        {
            return _manager.Update(id, updates);
        }

        // DELETE api/<IPAsController>/5
        [HttpDelete("{id}")]
        public IPA Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
