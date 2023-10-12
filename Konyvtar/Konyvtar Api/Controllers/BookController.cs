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
        public IActionResult Add([FromBody] Book b)
        {
            var exp = _books.Get(b.Id);
            if (exp != null) 
            {
                return Conflict();
            }
            _books.Add(b);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var b = _books.Get(id);
            if (b is null)
            {
                return NotFound();
            }
            _books.delete(b);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id) 
        {
            var b = _books.Get(id);
            if (b is null)
            {
                return NotFound();
            }
            return Ok(b);
        }
        [HttpGet]
        public ActionResult<List<Book>> GetAll(string id) 
        {
            return Ok(_books);
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Book b)
        {
            if (b.Id != id)
            {
                return Conflict();
            }
            var po = _books.Get(id);
            if(po is null)
            {
                return NotFound();
            }
            _books.Update(b);
            return Ok();
        }
    }
}
