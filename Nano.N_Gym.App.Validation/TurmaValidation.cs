using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Validation
{
    internal class TurmaValidation : BaseEmpresaValidation<Turma>, ITurmaValidation
    {
        private readonly ITurmaRepository _repository;

        public TurmaValidation(ITurmaRepository repository)
        {
            _repository = repository;
        }

        public override void Validate(Turma turma)
        {
            base.Validate(turma);

            if (string.IsNullOrEmpty(turma.Nome))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(turma.Nome)} é obrigatória e não pode ser vasia.");

            if (turma.Modalidade == null)
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(turma.Modalidade)} é obrigatória e não pode ser vasia.");

            if (_repository.GetAll().Any(p => p.Nome.ToUpper() == turma.Nome.ToUpper() && p.Id != turma.Id))
                throw new DuplicatedPropertyException($"Já existe uma turma com o nome {turma.Nome}.");

            if (turma.LimiteMaximo.HasValue && turma.LimiteMaximo <= 0)
                throw new NegativeValueException($"Quantidade do limite máximo não pode ser menor ou igual a zero.");
        }
    }
}
