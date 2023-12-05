using Pass;

namespace Konyvtar.UI.Services
{
    public interface IPersonService  
    {  
        Task<IEnumerable<Person>?> GetPeopleAsync();  
  
        Task<Person?> GetPersonByIdAsync(int id);  
  
        Task UpdatePersonAsync(int id, Person person);  
  
        Task DeletePersonAsync(int id);  
  
        Task AddPersonAsync(Person person);  
    }
}