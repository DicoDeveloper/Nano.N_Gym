using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
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
