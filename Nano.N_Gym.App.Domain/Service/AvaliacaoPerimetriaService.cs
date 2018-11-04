using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoPerimetriaService : GymBaseService<AvaliacaoPerimetria>, IAvaliacaoPerimetriaService
    {
        private readonly IAvaliacaoPerimetriaRepository _repository;

        public AvaliacaoPerimetriaService(IAvaliacaoPerimetriaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoPerimetria avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
