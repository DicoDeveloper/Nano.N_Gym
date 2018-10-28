using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class LoteCorTamanhoRepository : BaseRepository<LoteCorTamanho>, ILoteCorTamanhoRepository
    {
        private readonly ILoteCorTamanhoContext _context;

        public LoteCorTamanhoRepository(ILoteCorTamanhoContext context) : base(context)
        {
            _context = context;
        }
    }
}
