using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class FuncionarioRepository : BaseRepository<Funcionario>, IFuncionarioRepository
    {
        private readonly IFuncionarioContext _context;

        public FuncionarioRepository(IFuncionarioContext context) : base(context)
        {
            _context = context;
        }
    }
}
