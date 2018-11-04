using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AvaliacaoCompletaService : GymBaseService<AvaliacaoCompleta>, IAvaliacaoCompletaService
    {
        private readonly IAvaliacaoCompletaRepository _repository;

        public AvaliacaoCompletaService(IAvaliacaoCompletaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(AvaliacaoCompleta avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
