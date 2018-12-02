using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;
using System.Linq;

namespace Nano.N_Gym.App.Validation
{
    internal class LocalizacaoValidation : BaseEmpresaValidation<Localizacao>, ILocalizacaoValidation
    {
        private readonly ILocalizacaoRepository _repository;

        public LocalizacaoValidation(ILocalizacaoRepository repository)
        {
            _repository = repository;
        }

        public override void Validate(Localizacao localizacao)
        {
            base.Validate(localizacao);

            if (string.IsNullOrEmpty(localizacao.Descricao))
                throw new InvalidOrNullRequiredPropertyException($"Propriedade {nameof(localizacao.Descricao)} é obrigatória e não pode ser vasia");

            if (_repository.GetAll().Any(l => l.Descricao.ToUpper().Equals(localizacao.Descricao.ToUpper()) && l.Id != localizacao.Id))
                throw new DuplicatedPropertyException($"Já existe uma localização com a descrição {localizacao.Descricao}");

            if (localizacao.Pai != null && localizacao.Id > 0 && localizacao.Id == localizacao.Pai.Id)
                throw new InvalidHierarchyException("Localização agregada não pode ser a mesma do cadastro");
        }
    }
}
