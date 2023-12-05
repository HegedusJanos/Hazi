using Pass;

namespace Konyvtar.Ui.Services
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>?> GetBookAsync();

        Task<Book?> GetBookByIdAsync(int id);

        Task UpdateBookAsync(int id, Book book);

        Task DeleteBookAsync(int id);

        Task AddBookAsync(Book book);
    }
}
