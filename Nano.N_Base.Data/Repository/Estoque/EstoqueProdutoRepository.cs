using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class EstoqueProdutoRepository : BaseRepository<Model.Entity.Estoque.EstoqueProduto>, IEstoqueProdutoRepository
    {
        private readonly IEstoqueProdutoContext _context;

        public EstoqueProdutoRepository(IEstoqueProdutoContext context) : base(context)
        {
            _context = context;
        }
    }
}
