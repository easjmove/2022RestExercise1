using Microsoft.AspNetCore.Mvc;
using RestExercise1.Managers;
using RestExercise1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestExercise1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlowersController : ControllerBase
    {
        private FlowersManagerList _manager = new FlowersManagerList();

        // GET: api/<FlowersController>
        [HttpGet]
        public IEnumerable<Flower> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<FlowersController>/5
        [HttpGet("{id}")]
        public Flower Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<FlowersController>
        [HttpPost]
        public Flower Post([FromBody] Flower newFlower)
        {
            return _manager.Add(newFlower);
        }

        // PUT api/<FlowersController>/5
        [HttpPut("{id}")]
        public Flower Put(int id, [FromBody] Flower updates)
        {
            return _manager.Update(id, updates);
        }

        // DELETE api/<FlowersController>/5
        [HttpDelete("{id}")]
        public Flower Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
