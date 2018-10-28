using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class LoteCorRepository : BaseRepository<LoteCor>, ILoteCorRepository
    {
        private readonly ILoteCorContext _context;

        public LoteCorRepository(ILoteCorContext context) : base(context)
        {
            _context = context;
        }
    }
}
