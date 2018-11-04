using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoComposicaoCorporalService : GymBaseService<AvaliacaoComposicaoCorporal>, IAvaliacaoComposicaoCorporalService
    {
        private readonly IAvaliacaoComposicaoCorporalRepository _repository;

        public AvaliacaoComposicaoCorporalService(IAvaliacaoComposicaoCorporalRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoComposicaoCorporal avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
