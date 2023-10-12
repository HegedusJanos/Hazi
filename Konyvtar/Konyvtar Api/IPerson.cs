namespace Konyvtar_Api
{
    public interface IPerson
    {
        void Add(Person p);
        void Delete(Person p);
        Person Get(int id);
        IEnumerable<Person> GetAll();
        void Update(Person p);
    }
}
