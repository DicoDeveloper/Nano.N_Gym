using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ProficaoService : GymBaseService<Proficao>, IProficaoService
    {
        private readonly IProficaoRepository _repository;

        public ProficaoService(IProficaoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Proficao proficao)
        {
            // Executar verificacoes especificas
            return base.Save(proficao);
        }
    }
}
