using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Data.Repository
{
    public class PeriodoTurmaRepository : BaseRepository<PeriodoTurma>, IPeriodoTurmaRepository
    {
        private readonly IPeriodoTurmaContext _context;

        public PeriodoTurmaRepository(IPeriodoTurmaContext context) : base(context)
        {
            _context = context;
        }
    }
}
