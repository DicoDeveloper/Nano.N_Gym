using Nano.N_Base.Data.Repository;
using Nano.N_Gym.App.Data.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Data.Repository
{
    public class ExercicioRepository : BaseRepository<Exercicio>, IExercicioRepository
    {
        private readonly IExercicioContext _context;

        public ExercicioRepository(IExercicioContext context) : base(context)
        {
            _context = context;
        }
    }
}
