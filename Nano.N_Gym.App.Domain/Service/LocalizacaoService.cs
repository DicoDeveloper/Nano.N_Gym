using Nano.N_Base.Domain.Service;
using Nano.N_Base.Model.Exception;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class LocalizacaoService : BaseService<Localizacao>, ILocalizacaoService
    {
        private readonly ILocalizacaoRepository _repository;

        public LocalizacaoService(ILocalizacaoRepository repository, IBaseValidation<Localizacao> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Delete(Localizacao localizacao)
        {
            if (localizacao.Filhos != null && localizacao.Filhos.Count > 0)
                throw new InvalidDeleteOperationException("Cadastro possui localização abaixo na hierarquia");

            return base.Delete(localizacao);
        }
    }
}
