using Pass;
namespace Konyvtar_Api
{
    public class Persons : IPerson
    {
        private readonly List<Person> _people = new();
        private readonly ILogger<Persons> _logger;
        public Persons(ILogger<Persons> logger)
        {
            _logger = logger;
        }
        public void Add(Person p)
        {
            _people.Add(p);
            _logger.LogInformation("Person Added. Person{@Person}",p);
        }

        public void Delete(Person p)
        {
            _people.Remove(p);
            _logger.LogInformation("Deleted.");
        }

        public Person Get(int id)
        {
            return _people.Find(match: p => p.ID == id);
        }

        public IEnumerable<Person> GetAll()
        {
            return _people;
        }

        public void Update(Person np)
        {
            var exp = Get(np.ID);
            exp.Name = np.Name;
            exp.AdressT = np.AdressT;
            exp.AdressU = np.AdressU;
            exp.AdressHN = np.AdressHN;
            exp.BYear = np.BYear;
        }
    }
}
