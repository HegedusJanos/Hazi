using Pass;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Konyvtar_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OutController : ControllerBase
    {
        private readonly IOut _out;
        private readonly IPerson _person;
        private readonly IBook _book;
        public OutController(IOut outs,IPerson person, IBook books)
        {
            _out = outs;
            _person = person;
            _book = books;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Out o)
        {
            var exp1 = _person.Get(o.P_ID);
            var exp2 = _book.Get(o.B_ID);
            var exp3 = _out.Get(o.ID);
            if (exp3 != null)
            {
                return Conflict();
            }
            if (exp1 == null || exp2 == null)
            {
                return NotFound();
            }
            await _out.Add(o);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var o = await _out.Get(id);
            if (o is null)
            {
                return NotFound();
            }
            await _out.Delete(o);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var o = await _out.Get(id);
            if (o is null)
            {
                return NotFound();
            }
            return Ok(o);
        }
        [HttpGet]
        public async Task<ActionResult<List<Out>>> GetAll()
        {
            var outs = await _out.GetAll();
            return Ok(outs.ToList());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Out o)
        {
            if (o.ID != id)
            {
                return Conflict();
            }
            var ou = await _out.Get(id);
            if (ou is null)
            {
                return NotFound();
            }
            await _out.Update(o);
            return Ok();
        }
    }
}
