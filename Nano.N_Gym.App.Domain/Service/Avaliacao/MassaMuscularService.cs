using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class MassaMuscularService : GymBaseService<MassaMuscular>, IMassaMuscularService
    {
        private readonly IMassaMuscularRepository _repository;

        public MassaMuscularService(IMassaMuscularRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(MassaMuscular avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
