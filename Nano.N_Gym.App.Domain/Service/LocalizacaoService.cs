using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class LocalizacaoService : GymBaseService<Localizacao>, ILocalizacaoService
    {
        private readonly ILocalizacaoRepository _repository;

        public LocalizacaoService(ILocalizacaoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Localizacao localizacao)
        {
            // Executar verificacoes especificas
            return base.Save(localizacao);
        }
    }
}
