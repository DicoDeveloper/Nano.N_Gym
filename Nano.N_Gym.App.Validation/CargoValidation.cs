using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Validation
{
    internal class CargoValidation : BaseValidation<Cargo>, ICargoValidation
    {
        private readonly ICargoRepository _repository;

        public CargoValidation(ICargoRepository repository)
        {
            _repository = repository;
        }

        public override void Validate(Cargo cargo)
        {
            base.Validate(cargo);

            if (string.IsNullOrEmpty(cargo.Descricao))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(cargo.Descricao)} é obrigatória e não pode ser vasia.");

            if (_repository.GetAll().Any(c => c.Descricao.ToUpper() == cargo.Descricao.ToUpper() && c.Id != cargo.Id))
                throw new DuplicatedPropertyException($"Já existe um cargo com a descrição {cargo.Descricao}.");
        }
    }
}
