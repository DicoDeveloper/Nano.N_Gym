using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ExercicioTreinoService : GymBaseService<ExercicioTreino>, IExercicioTreinoService
    {
        private readonly IExercicioTreinoRepository _repository;

        public ExercicioTreinoService(IExercicioTreinoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(ExercicioTreino exercicioTreino)
        {
            // Executar verificacoes especificas
            return base.Save(exercicioTreino);
        }
    }
}
