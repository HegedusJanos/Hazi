using System.Net.Http.Json;
using Pass;

namespace Konyvtar.UI.Services
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _httpClient;

        public PersonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<Person>?> GetPeopleAsync() =>
            _httpClient.GetFromJsonAsync<IEnumerable<Person>>("People");

        public Task<Person?> GetPersonByIdAsync(int id) =>
            _httpClient.GetFromJsonAsync<Person>($"People/{id}");

        public Task UpdatePersonAsync(int id, Person person) =>
            _httpClient.PutAsJsonAsync($"People/{id}", person);

        public Task DeletePersonAsync(int id) =>
            _httpClient.DeleteAsync($"People/{id}");

        public Task AddPersonAsync(Person person) =>
            _httpClient.PostAsJsonAsync("People", person);
    }
}