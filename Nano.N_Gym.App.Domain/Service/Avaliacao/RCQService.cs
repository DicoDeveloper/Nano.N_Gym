using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class RCQService : GymBaseService<RCQ>, IRCQService
    {
        private readonly IRCQRepository _repository;

        public RCQService(IRCQRepository repository, IBaseValidation<RCQ> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(RCQ avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
