using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class FabricanteRepository : BaseRepository<Fabricante>, IFabricanteRepository
    {
        private readonly IFabricanteContext _context;

        public FabricanteRepository(IFabricanteContext context) : base(context)
        {
            _context = context;
        }
    }
}
