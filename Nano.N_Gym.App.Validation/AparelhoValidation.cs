using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Validation
{
    internal class AparelhoValidation : BaseEmpresaValidation<Aparelho>, IAparelhoValidation
    {
        private readonly IAparelhoRepository _repository;

        public AparelhoValidation(IAparelhoRepository repository)
        {
            _repository = repository;
        }

        public override void Validate(Aparelho aparelho)
        {
            base.Validate(aparelho);

            if (string.IsNullOrEmpty(aparelho.Nome))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(aparelho.Nome)} é obrigatória e não pode ser vasia");

            if (_repository.GetAll().Any(l => l.Nome.ToUpper().Equals(aparelho.Nome.ToUpper()) && l.Numeracao.ToUpper().Equals(aparelho.Numeracao.ToUpper()) && l.Id != aparelho.Id))
                throw new DuplicatedPropertyException($"Já existe uma localização com a descrição {aparelho.Descricao}");

            if (aparelho.DataTransferencia.HasValue && aparelho.DataAquisicao.HasValue && aparelho.DataTransferencia < aparelho.DataAquisicao)
                throw new DateBetweenInvalidException("Data de transferencia não pode ser menor que data de aquisição");

            if (aparelho.ValorAquisicao.HasValue && aparelho.ValorAquisicao < 0)
                throw new NegativeValueException("Valor de aquisição não pode ser negativo");
        }
    }
}
