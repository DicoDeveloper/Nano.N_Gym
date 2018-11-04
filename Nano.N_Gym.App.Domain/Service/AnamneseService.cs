using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AnamneseService : GymBaseService<Anamnese>, IAnamneseService
    {
        private readonly IAnamneseRepository _repository;

        public AnamneseService(IAnamneseRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Anamnese anamnese)
        {
            // Executar verificacoes especificas
            return base.Save(anamnese);
        }
    }
}
