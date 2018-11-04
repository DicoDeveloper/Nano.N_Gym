using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoRiscoCoronarianoService : GymBaseService<AvaliacaoRiscoCoronariano>, IAvaliacaoRiscoCoronarianoService
    {
        private readonly IAvaliacaoRiscoCoronarianoRepository _repository;

        public AvaliacaoRiscoCoronarianoService(IAvaliacaoRiscoCoronarianoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoRiscoCoronariano avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
