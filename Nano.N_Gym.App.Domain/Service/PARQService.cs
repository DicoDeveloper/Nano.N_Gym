using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class PARQService : GymBaseService<PARQ>, IPARQService
    {
        private readonly IPARQRepository _repository;

        public PARQService(IPARQRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(PARQ parq)
        {
            // Executar verificacoes especificas
            return base.Save(parq);
        }
    }
}
