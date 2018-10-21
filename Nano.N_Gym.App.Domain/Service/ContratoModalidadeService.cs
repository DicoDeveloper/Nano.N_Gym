using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class ContratoModalidadeService : GymBaseService<ContratoModalidade>, IContratoModalidadeService
    {
        private readonly IContratoModalidadeRepository _repository;

        public ContratoModalidadeService(IContratoModalidadeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(ContratoModalidade contratoModalidade)
        {
            // Executar verificacoes especificas
            return base.Save(contratoModalidade);
        }
    }
}
