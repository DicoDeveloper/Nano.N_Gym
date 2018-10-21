using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
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
