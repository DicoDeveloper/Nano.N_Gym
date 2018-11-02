using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class TransportadoraRepository : BaseRepository<Transportadora>, ITransportadoraRepository
    {
        private readonly ITransportadoraContext _context;

        public TransportadoraRepository(ITransportadoraContext context) : base(context)
        {
            _context = context;
        }
    }
}
