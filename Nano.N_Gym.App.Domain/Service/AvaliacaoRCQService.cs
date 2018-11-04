using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoRCQService : GymBaseService<AvaliacaoRCQ>, IAvaliacaoRCQService
    {
        private readonly IAvaliacaoRCQRepository _repository;

        public AvaliacaoRCQService(IAvaliacaoRCQRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoRCQ avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
