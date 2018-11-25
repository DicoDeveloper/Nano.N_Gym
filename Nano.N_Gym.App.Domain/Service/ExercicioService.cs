using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ExercicioService : GymBaseService<Exercicio>, IExercicioService
    {
        private readonly IExercicioRepository _repository;

        public ExercicioService(IExercicioRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
