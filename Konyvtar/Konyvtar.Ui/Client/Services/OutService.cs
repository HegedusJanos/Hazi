using Pass;
using System.Net.Http.Json;

namespace Konyvtar.Ui.Services
{
    public class OutService: IOutServices
    {
        private readonly HttpClient _httpClient;

        public OutService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<Out>?> GetOutAsync() =>
            _httpClient.GetFromJsonAsync<IEnumerable<Out>>("Out");

        public Task<Out?> GetOutByIdAsync(int id) =>
            _httpClient.GetFromJsonAsync<Out>($"Out/{id}");

        public Task UpdateOutAsync(int id, Out outs) =>
            _httpClient.PutAsJsonAsync($"Out/{id}", outs);

        public Task DeleteOutAsync(int id) =>
            _httpClient.DeleteAsync($"Out/{id}");

        public Task AddOutAsync(Out person) =>
            _httpClient.PostAsJsonAsync("Out", person);
    }
}
