using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class AtributoProdutoRepository : BaseRepository<AtributoProduto>, IAtributoProdutoRepository
    {
        private readonly IAtributoProdutoContext _context;

        public AtributoProdutoRepository(IAtributoProdutoContext context) : base(context)
        {
            _context = context;
        }
    }
}
