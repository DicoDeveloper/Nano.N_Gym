using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoIMCService : GymBaseService<AvaliacaoIMC>, IAvaliacaoIMCService
    {
        private readonly IAvaliacaoIMCRepository _repository;

        public AvaliacaoIMCService(IAvaliacaoIMCRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoIMC avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
