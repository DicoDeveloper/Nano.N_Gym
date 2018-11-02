using Nano.N_Base.Data.Interface.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Data.Repository.Financeiro
{
    public class MeioPagamentoRepository : BaseRepository<MeioPagamento>, IMeioPagamentoRepository
    {
        private readonly IMeioPagamentoContext _context;

        public MeioPagamentoRepository(IMeioPagamentoContext context) : base(context)
        {
            _context = context;
        }
    }
}
