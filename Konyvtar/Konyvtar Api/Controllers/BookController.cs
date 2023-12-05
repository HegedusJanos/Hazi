using Pass;
using Microsoft.AspNetCore.Mvc;

namespace Konyvtar_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private IBook _books;
        public BookController(IBook book)
        {
            _books = book;
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Book b)
        {
            var exp = await _books.Get(b.Id);
            if (exp != null) 
            {
                return Conflict();
            }
            await _books.Add(b);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var b = await _books.Get(id);
            if (b is null)
            {
                return NotFound();
            }
            await _books.delete(b);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id) 
        {
            var b = await _books.Get(id);
            if (b is null)
            {
                return NotFound();
            }
            return Ok(b);
        }
        [HttpGet]
        public async Task<ActionResult<List<Book>>> GetAll(string id) 
        {
            var books = await _books.GetAll();
            return Ok(books.ToList());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Book b)
        {
            if (b.Id != id)
            {
                return BadRequest();
            }
            var po = _books.Get(id);
            if(po is null)
            {
                return NotFound();
            }
            await _books.Update(b);
            return Ok();
        }
    }
}
