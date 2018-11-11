using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
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
