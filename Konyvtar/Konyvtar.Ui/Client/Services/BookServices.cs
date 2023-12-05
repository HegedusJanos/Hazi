using Pass;
using System.Net.Http;
using System.Net.Http.Json;

namespace Konyvtar.Ui.Services
{
    public class BookServices : IBookServices
    {
        private readonly HttpClient _httpClient;
 
        public BookServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<IEnumerable<Book>?> GetBookAsync() =>
            _httpClient.GetFromJsonAsync<IEnumerable<Book>>("Book");

        public Task<Book?> GetBookByIdAsync(int id) =>
            _httpClient.GetFromJsonAsync<Book>($"Book/{id}");

        public Task UpdateBookAsync(int id, Book book) =>
            _httpClient.PutAsJsonAsync($"Book/{id}", book);

        public Task DeleteBookAsync(int id) =>
            _httpClient.DeleteAsync($"Book/{id}");

        public Task AddBookAsync(Book book) =>
            _httpClient.PostAsJsonAsync("People", book);
    }
}
