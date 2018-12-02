using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ExercicioService : BaseService<Exercicio>, IExercicioService
    {
        private readonly IExercicioRepository _repository;

        public ExercicioService(IExercicioRepository repository, IBaseValidation<Exercicio> validation) : base(repository, validation)
        {
            _repository = repository;
        }
    }
}
