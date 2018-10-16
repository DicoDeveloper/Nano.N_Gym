using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
{
    public class EstoqueProdutoRepository : BaseRepository<EstoqueProduto>, IEstoqueProdutoRepository
    {
        private readonly IEstoqueProdutoContext _context;

        public EstoqueProdutoRepository(IEstoqueProdutoContext context) : base(context)
        {
            _context = context;
        }
    }
}
