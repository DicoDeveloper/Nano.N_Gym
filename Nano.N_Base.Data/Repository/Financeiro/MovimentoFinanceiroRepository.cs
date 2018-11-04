using Nano.N_Base.Data.Interface.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Data.Repository.Financeiro
{
    public class MovimentoFinanceiroRepository : BaseRepository<MovimentoFinanceiro>, IMovimentoFinanceiroRepository
    {
        private readonly IMovimentoFinanceiroContext _context;

        public MovimentoFinanceiroRepository(IMovimentoFinanceiroContext context) : base(context)
        {
            _context = context;
        }
    }
}
