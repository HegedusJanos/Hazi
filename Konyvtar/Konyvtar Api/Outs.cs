using Konyvtar_Api.Context;
using Microsoft.EntityFrameworkCore;
using Pass;
using System;

namespace Konyvtar_Api
{
    public class Outs : IOut
    {
        private readonly KonyvtarApi2023Context _konyvtarOut;
        private readonly ILogger<Outs> _logger;
        public Outs(ILogger<Outs> logger, KonyvtarApi2023Context outs)
        {
            _konyvtarOut = outs;
            _logger = logger;
        }
        public async Task Add(Out o)
        {
            _konyvtarOut.outs.Add(o);
            await _konyvtarOut.SaveChangesAsync();
            _logger.LogInformation("Out added. Out: {@Out}", o);
        }
        public async Task<IEnumerable<Out>> GetAll()
        {
            _logger.LogInformation("Out retrieved");
            var ouut = await _konyvtarOut.outs.ToListAsync();
            return ouut;
        }

        public async Task Update(Out b)
        {
            var exp = await Get(b.ID);
            exp.P_ID = b.P_ID;
            exp.B_ID = b.B_ID;
            exp.outcast = b.outcast;
            exp.recast = b.recast;
            _logger.LogInformation("Out updated. Out: {@Out}", exp);
            await _konyvtarOut.SaveChangesAsync();
        }

        public async Task<Out> Get(int id)
        {
            var outs = await _konyvtarOut.outs.FindAsync(id);
            _logger.LogInformation("Out retrieved. Out: {@Out}", outs);
            return outs;
        }

        public async Task Delete(Out o)
        {
            _konyvtarOut.outs.Remove(o);
            await _konyvtarOut.SaveChangesAsync();
            _logger.LogInformation("Out Deleted!");
        }
    }
}
