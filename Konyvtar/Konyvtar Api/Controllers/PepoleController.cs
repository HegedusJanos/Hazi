using Microsoft.AspNetCore.Mvc;

namespace Konyvtar_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PepoleController : ControllerBase
    {
        private IPerson _person;
        public PepoleController(IPerson person)
        {
            _person = person;
        }
        [HttpPost]
        public IActionResult Add([FromBody] Person p)
        {
            var exp = _person.Get(p.ID);
            if (exp != null) 
            {
                return Conflict();
            }
            _person.Add(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var p = _person.Get(id);
            if (p is null)
            {
                return NotFound();
            }
            _person.Delete(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var p = _person.Get(id);
            if (p is null)
            {
                return NotFound();
            }
            return Ok(p);
        }
        [HttpGet]
        public ActionResult<List<Person>> GetAll(string id) 
        {
            return Ok(_person);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Person p)
        {
            if (p.ID != id)
            {
                return Conflict();
            }
            var po = _person.Get(id);
            if(po is null)
            {
                return NotFound();
            }
            _person.Update(p);
            return Ok();
        }
    }
}
