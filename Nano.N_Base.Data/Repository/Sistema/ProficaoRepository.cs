using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ProficaoRepository : BaseRepository<Proficao>, IProficaoRepository
    {
        private readonly IProficaoContext _context;

        public ProficaoRepository(IProficaoContext context) : base(context)
        {
            _context = context;
        }
    }
}
