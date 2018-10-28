using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class ProdutoRepository : BaseRepository<Produto>, IProdutoRepository
    {
        private readonly IProdutoContext _context;

        public ProdutoRepository(IProdutoContext context) : base(context)
        {
            _context = context;
        }
    }
}
