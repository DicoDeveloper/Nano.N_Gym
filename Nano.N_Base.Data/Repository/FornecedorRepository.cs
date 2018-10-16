using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
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
