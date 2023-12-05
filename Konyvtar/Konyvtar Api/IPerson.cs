using Pass;
namespace Konyvtar_Api
{
    public interface IPerson
    {
        Task Add(Person p);
        Task Delete(Person p);
        Task<Person> Get(int id);
        Task<IEnumerable<Person>> GetAll();
        Task Update(Person p);
    }
}
