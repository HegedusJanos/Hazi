using Konyvtar_Api.Context;
using Microsoft.EntityFrameworkCore;
using Pass;
using System;

namespace Konyvtar_Api
{
    public class Persons : IPerson
    {
        private readonly KonyvtarApi2023Context _konyvtarPeole;
        private readonly ILogger<Persons> _logger;
        public Persons(ILogger<Persons> logger, KonyvtarApi2023Context peole)
        {
            _konyvtarPeole = peole;
            _logger = logger;
        }
        public async Task Add(Person p)
        {
            _konyvtarPeole.People.Add(p);
            await _konyvtarPeole.SaveChangesAsync();
            _logger.LogInformation("Person Added. Person{@Person}",p);
        }

        public async Task Delete(Person p)
        {
            _konyvtarPeole.People.Remove(p);
            await _konyvtarPeole.SaveChangesAsync();
            _logger.LogInformation("Deleted.");
        }

        public async Task<Person> Get(int id)
        {
            var person = await _konyvtarPeole.People.FindAsync(id);
            _logger.LogInformation("Person retrieved. Person: {@Person}", person);
            return person;
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            _logger.LogInformation("People retrieved");
            var pepole = await _konyvtarPeole.People.ToListAsync();
            return pepole;
        }

        public async Task Update(Person np)
        {
            var exp = await Get(np.ID);
            exp.Name = np.Name;
            exp.Adress = np.Adress;
            exp.BYear = np.BYear;
            _logger.LogInformation("Person updated. Person: {@Person}", exp);
            await _konyvtarPeole.SaveChangesAsync();
        }
    }
}
