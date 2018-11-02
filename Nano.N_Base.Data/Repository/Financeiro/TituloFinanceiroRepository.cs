using Nano.N_Base.Data.Interface.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Data.Repository.Financeiro
{
    public class TituloFinanceiroRepository : BaseRepository<TituloFinanceiro>, ITituloFinanceiroRepository
    {
        private readonly ITituloFinanceiroContext _context;

        public TituloFinanceiroRepository(ITituloFinanceiroContext context) : base(context)
        {
            _context = context;
        }
    }
}
