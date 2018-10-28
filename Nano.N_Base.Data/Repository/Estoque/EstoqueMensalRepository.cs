using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class EstoqueMensalRepository : BaseRepository<EstoqueMensal>, IEstoqueMensalRepository
    {
        private readonly IEstoqueMensalContext _context;

        public EstoqueMensalRepository(IEstoqueMensalContext context) : base(context)
        {
            _context = context;
        }
    }
}
