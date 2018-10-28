using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class MovimentacaoEstoqueRepository : BaseRepository<MovimentacaoEstoque>, IMovimentacaoEstoqueRepository
    {
        private readonly IMovimentacaoEstoqueContext _context;

        public MovimentacaoEstoqueRepository(IMovimentacaoEstoqueContext context) : base(context)
        {
            _context = context;
        }
    }
}
