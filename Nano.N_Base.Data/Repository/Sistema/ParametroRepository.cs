using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ParametroRepository : BaseRepository<Parametro>, IParametroRepository
    {
        private readonly IParametroContext _context;

        public ParametroRepository(IParametroContext context) : base(context)
        {
            _context = context;
        }
    }
}
