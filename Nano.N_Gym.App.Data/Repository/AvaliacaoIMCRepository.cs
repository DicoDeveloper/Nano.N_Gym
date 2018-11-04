using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Data.Repository
{
    public class AvaliacaoIMCRepository : BaseRepository<AvaliacaoIMC>, IAvaliacaoIMCRepository
    {
        private readonly IAvaliacaoIMCContext _context;

        public AvaliacaoIMCRepository(IAvaliacaoIMCContext context) : base(context)
        {
            _context = context;
        }
    }
}
