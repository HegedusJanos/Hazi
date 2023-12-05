using Pass;

namespace Konyvtar.Ui.Services
{
    public interface IOutServices
    {
        Task<IEnumerable<Out>?> GetOutAsync();

        Task<Out?> GetOutByIdAsync(int id);

        Task UpdateOutAsync(int id, Out outs);

        Task DeleteOutAsync(int id);

        Task AddOutAsync(Out outs);
    }
}
