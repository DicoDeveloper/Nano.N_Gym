using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
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
