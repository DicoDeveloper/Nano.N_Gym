using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
        private readonly IEmpresaContext _context;

        public EmpresaRepository(IEmpresaContext context) : base(context)
        {
            _context = context;
        }
    }
}
