using Nano.N_Base.Data.Interface.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Data.Repository.Financeiro
{
    public class DespesaReceitaRepository : BaseRepository<DespesaReceita>, IDespesaReceitaRepository
    {
        private readonly IDespesaReceitaContext _context;

        public DespesaReceitaRepository(IDespesaReceitaContext context) : base(context)
        {
            _context = context;
        }
    }
}
