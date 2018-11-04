using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class MovimentoEstoqueRepository : BaseRepository<MovimentoEstoque>, IMovimentoEstoqueRepository
    {
        private readonly IMovimentoEstoqueContext _context;

        public MovimentoEstoqueRepository(IMovimentoEstoqueContext context) : base(context)
        {
            _context = context;
        }
    }
}
