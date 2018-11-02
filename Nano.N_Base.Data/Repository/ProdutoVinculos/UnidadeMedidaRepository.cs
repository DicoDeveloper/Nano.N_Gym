using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class UnidadeMedidaRepository : BaseRepository<UnidadeMedida>, IUnidadeMedidaRepository
    {
        private readonly IUnidadeMedidaContext _context;

        public UnidadeMedidaRepository(IUnidadeMedidaContext context) : base(context)
        {
            _context = context;
        }
    }
}
