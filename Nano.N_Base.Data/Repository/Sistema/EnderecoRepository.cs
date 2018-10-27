using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class EnderecoRepository : BaseRepository<Endereco>, IEnderecoRepository
    {
        private readonly IEnderecoContext _context;

        public EnderecoRepository(IEnderecoContext context) : base(context)
        {
            _context = context;
        }
    }
}
