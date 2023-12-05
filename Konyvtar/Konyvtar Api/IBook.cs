using Pass;
namespace Konyvtar_Api
{
    public interface IBook
    {
        Task Add(Book b);
        Task delete(Book b);
        Task<Book> Get(int id);
        Task<IEnumerable<Book>> GetAll();
        Task Update(Book b);
    }
}
