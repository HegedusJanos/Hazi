using Pass;
namespace Konyvtar_Api
{
    public interface IOut
    {
        Task Add(Out o);
        Task Delete(Out o);
        Task<Out> Get(int id);
        Task<IEnumerable<Out>> GetAll();
        Task Update(Out b);
    }
}
