using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoService : GymBaseService<Avaliacao>, IAvaliacaoService
    {
        private readonly IAvaliacaoRepository _repository;

        public AvaliacaoService(IAvaliacaoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Avaliacao avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
