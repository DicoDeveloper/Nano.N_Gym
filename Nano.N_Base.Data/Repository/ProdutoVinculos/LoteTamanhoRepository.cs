using Nano.N_Base.Data.Interface.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Data.Repository.ProdutoVinculos
{
    public class LoteTamanhoRepository : BaseRepository<LoteTamanho>, ILoteTamanhoRepository
    {
        private readonly ILoteTamanhoContext _context;

        public LoteTamanhoRepository(ILoteTamanhoContext context) : base(context)
        {
            _context = context;
        }
    }
}
