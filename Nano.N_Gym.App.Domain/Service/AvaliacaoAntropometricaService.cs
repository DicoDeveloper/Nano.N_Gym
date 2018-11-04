using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoAntropometricaService : GymBaseService<AvaliacaoAntropometrica>, IAvaliacaoAntropometricaService
    {
        private readonly IAvaliacaoAntropometricaRepository _repository;

        public AvaliacaoAntropometricaService(IAvaliacaoAntropometricaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoAntropometrica avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
