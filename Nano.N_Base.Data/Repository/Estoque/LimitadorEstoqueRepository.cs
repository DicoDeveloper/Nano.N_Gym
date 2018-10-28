using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class LimitadorEstoqueRepository : BaseRepository<LimitadorEstoque>, ILimitadorEstoqueRepository
    {
        private readonly ILimitadorEstoqueContext _context;

        public LimitadorEstoqueRepository(ILimitadorEstoqueContext context) : base(context)
        {
            _context = context;
        }
    }
}
