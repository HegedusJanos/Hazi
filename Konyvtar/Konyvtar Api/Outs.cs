using Pass;
namespace Konyvtar_Api
{
    public class Outs : IOut
    {
        private readonly List<Out> _out = new();
        private readonly ILogger<Outs> _logger;
        public Outs(ILogger<Outs> logger)
        {
            _logger = logger;
        }
        public void Add(Out o)
        {
            _out.Add(o);
        }

        public List<Out> GetB(int id)
        {
            List<Out> outs = new();
            outs = _out.FindAll(match: o=> o.B_ID == id);
            return outs;
        }
        public List<Out> GetP(int id)
        {
            List<Out> outs = new();
            outs = _out.FindAll(match: o => o.P_ID == id);
            return outs;
        }

        public IEnumerable<Out> GetAll()
        {
            return _out;
        }

        public void Update(Out b)
        {
            List<Out> outs = new();
            outs = _out.FindAll(match: o => o.P_ID == b.P_ID);
        }
    }
}
