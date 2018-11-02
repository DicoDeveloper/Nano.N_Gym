using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ColaboradorRepository : BaseRepository<Colaborador>, IColaboradorRepository
    {
        private readonly IColaboradorContext _context;

        public ColaboradorRepository(IColaboradorContext context) : base(context)
        {
            _context = context;
        }
    }
}
