using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly IPessoaContext _context;

        public PessoaRepository(IPessoaContext context) : base(context)
        {
            _context = context;
        }
    }
}
