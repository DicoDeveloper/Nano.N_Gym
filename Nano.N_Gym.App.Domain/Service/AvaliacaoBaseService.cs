using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoBaseService : GymBaseService<AvaliacaoBase>, IAvaliacaoBaseService
    {
        private readonly IAvaliacaoBaseRepository _repository;

        public AvaliacaoBaseService(IAvaliacaoBaseRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoBase avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
