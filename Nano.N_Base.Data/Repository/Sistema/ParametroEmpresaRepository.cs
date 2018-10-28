using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ParametroEmpresaRepository : BaseRepository<ParametroEmpresa>, IParametroEmpresaRepository
    {
        private readonly IParametroEmpresaContext _context;

        public ParametroEmpresaRepository(IParametroEmpresaContext context) : base(context)
        {
            _context = context;
        }
    }
}
