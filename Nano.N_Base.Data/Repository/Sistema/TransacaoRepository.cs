using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class TransacaoRepository : BaseRepository<Transacao>, ITransacaoRepository
    {
        private readonly ITransacaoContext _context;

        public TransacaoRepository(ITransacaoContext context) : base(context)
        {
            _context = context;
        }
    }
}
