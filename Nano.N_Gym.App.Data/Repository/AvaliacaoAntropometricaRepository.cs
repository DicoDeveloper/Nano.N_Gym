using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Data.Repository
{
    public class AvaliacaoAntropometricaRepository : BaseRepository<AvaliacaoAntropometrica>, IAvaliacaoAntropometricaRepository
    {
        private readonly IAvaliacaoAntropometricaContext _context;

        public AvaliacaoAntropometricaRepository(IAvaliacaoAntropometricaContext context) : base(context)
        {
            _context = context;
        }
    }
}
