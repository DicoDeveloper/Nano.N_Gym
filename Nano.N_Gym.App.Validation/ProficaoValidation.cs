using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Validation
{
    internal class ProficaoValidation : BaseValidation<Proficao>, IProficaoValidation
    {
        private readonly IProficaoRepository _repository;

        public ProficaoValidation(IProficaoRepository repository)
        {
            _repository = repository;
        }

        public override void Validate(Proficao proficao)
        {
            base.Validate(proficao);

            if (string.IsNullOrEmpty(proficao.Descricao))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(proficao.Descricao)} é obrigatória e não pode ser vasia.");

            if (_repository.GetAll().Any(p => p.Descricao.ToUpper() == proficao.Descricao.ToUpper() && p.Id != proficao.Id))
                throw new DuplicatedPropertyException($"Já existe uma profição com a descrição {proficao.Descricao}.");
        }
    }
}
