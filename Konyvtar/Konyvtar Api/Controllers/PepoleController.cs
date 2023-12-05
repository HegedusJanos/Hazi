using Pass;
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
        public async Task<IActionResult> Add([FromBody] Person p)
        {
            var exp = await _person.Get(p.ID);
            if (exp != null) 
            {
                return Conflict();
            }
             await _person.Add(p);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var p = await _person.Get(id);
            if (p is null)
            {
                return NotFound();
            }
            await _person.Delete(p);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) 
        {
            var p = await _person.Get(id);
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
