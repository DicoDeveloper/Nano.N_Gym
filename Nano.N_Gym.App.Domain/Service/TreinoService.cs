using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class TreinoService : GymBaseService<Treino>, ITreinoService
    {
        private readonly ITreinoRepository _repository;

        public TreinoService(ITreinoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Treino treino)
        {
            // Executar verificacoes especificas
            return base.Save(treino);
        }
    }
}
