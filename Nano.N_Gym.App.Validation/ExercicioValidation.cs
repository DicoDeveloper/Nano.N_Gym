using Nano.N_Base.Model.Exception;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Validation
{
    internal class ExercicioValidation : GymValidation<Exercicio>, IExercicioValidation
    {
        private readonly IExercicioRepository _repository;

        public ExercicioValidation(IExercicioRepository repository)
        {
            _repository = repository;
        }

        public override void Validate(Exercicio exercicio)
        {
            base.Validate(exercicio);

            if (string.IsNullOrEmpty(exercicio.Nome))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(exercicio.Nome)} é obrigatória e não pode ser vasia");

            if (_repository.GetAll().Any(e => e.Nome.ToUpper().Equals(exercicio.Nome.ToUpper())))
                throw new DuplicatedPropertyException($"Já existe um exercício com o nome {exercicio.Nome}");
        }
    }
}
