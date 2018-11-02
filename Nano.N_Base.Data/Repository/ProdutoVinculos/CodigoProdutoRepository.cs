using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class CodigoProdutoRepository : BaseRepository<CodigoProduto>, ICodigoProdutoRepository
    {
        private readonly ICodigoProdutoContext _context;

        public CodigoProdutoRepository(ICodigoProdutoContext context) : base(context)
        {
            _context = context;
        }
    }
}
