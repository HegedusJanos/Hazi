using Pass;
namespace Konyvtar_Api
{
    public interface IOut
    {
        void Add(Out o);
        List<Out> GetB(int id);
        List<Out> GetP(int id);
        IEnumerable<Out> GetAll();
        void Update(Out b);
    }
}
