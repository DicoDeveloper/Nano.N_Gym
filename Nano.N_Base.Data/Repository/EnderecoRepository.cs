using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
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
