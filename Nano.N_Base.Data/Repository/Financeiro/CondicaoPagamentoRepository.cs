using Nano.N_Base.Data.Interface.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Data.Repository.Financeiro
{
    public class CondicaoPagamentoRepository : BaseRepository<CondicaoPagamento>, ICondicaoPagamentoRepository
    {
        private readonly ICondicaoPagamentoContext _context;

        public CondicaoPagamentoRepository(ICondicaoPagamentoContext context) : base(context)
        {
            _context = context;
        }
    }
}
