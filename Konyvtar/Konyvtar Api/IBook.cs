namespace Konyvtar_Api
{
    public interface IBook
    {
        void Add(Book b);
        void delete(Book b);
        Book Get(int id);
        IEnumerable<Book> GetAll();
        void Update(Book b);
    }
}
