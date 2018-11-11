using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class RiscoCoronarianoService : GymBaseService<RiscoCoronariano>, IRiscoCoronarianoService
    {
        private readonly IRiscoCoronarianoRepository _repository;

        public RiscoCoronarianoService(IRiscoCoronarianoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(RiscoCoronariano avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
