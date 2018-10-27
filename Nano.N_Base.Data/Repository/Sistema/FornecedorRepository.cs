using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class FornecedorRepository : BaseRepository<Fornecedor>, IFornecedorRepository
    {
        private readonly IFornecedorContext _context;

        public FornecedorRepository(IFornecedorContext context) : base(context)
        {
            _context = context;
        }
    }
}
