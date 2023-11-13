using Pass;
using System.Security.Claims;

namespace Konyvtar_Api
{
    public class Books : IBook
    {
        private readonly List<Book> books = new();
        private readonly ILogger<Books> _logger;

        public Books(ILogger<Books> logger)
        {
            _logger = logger;
        }

        public void Add(Book b)
        {
            books.Add(b);
        }

        public void delete(Book b)
        {
            books.Remove(b);
        }

        public Book Get(int id)
        {
            return books.Find(match: p=>p.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public void Update(Book b)
        {
            var exBook = Get(b.Id);
            exBook.CreatedDate = b.CreatedDate;
            exBook.Creators = b.Creators;
            exBook.Author = b.Author;
            exBook.Title = b.Title;
        }
    }
}
