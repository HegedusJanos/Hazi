using Konyvtar_Api.Context;
using Microsoft.EntityFrameworkCore;
using Pass;
using System.Security.Claims;

namespace Konyvtar_Api
{
    public class Books : IBook
    {
        private readonly KonyvtarApi2023Context _konytarBook;
        private readonly ILogger<Books> _logger;

        public Books(ILogger<Books> logger, KonyvtarApi2023Context book)
        {
            _konytarBook = book;
            _logger = logger;
        }

        public async Task Add(Book b)
        {
            _konytarBook.book.Add(b);
            await _konytarBook.SaveChangesAsync();
            _logger.LogInformation("Book added. Book: {@Book}", b);
        }

        public async Task delete(Book b)
        {
            _konytarBook.book.Remove(b);
            await _konytarBook.SaveChangesAsync();
            _logger.LogInformation("Deleted a book.");
        }

        public async Task<Book> Get(int id)
        {
            var book = await _konytarBook.book.FindAsync(id);
            _logger.LogInformation("Book finded. Book: {@book}",book);
            return book;
        }

        public async Task<IEnumerable<Book>> GetAll()
        {
            var books = await _konytarBook.book.ToListAsync();
            _logger.LogInformation("Books retrieved");
            return books;
        }

        public async Task Update(Book b)
        {
            var exBook = await Get(b.Id);
            exBook.CreatedDate = b.CreatedDate;
            exBook.Creators = b.Creators;
            exBook.Author = b.Author;
            exBook.Title = b.Title;
            _logger.LogInformation("Book updated. Book: {@Book}",exBook);
        }
    }
}
