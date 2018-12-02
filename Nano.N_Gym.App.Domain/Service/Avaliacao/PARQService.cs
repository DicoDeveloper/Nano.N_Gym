using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class PARQService : BaseService<PARQ>, IPARQService
    {
        private readonly IPARQRepository _repository;

        public PARQService(IPARQRepository repository, IBaseValidation<PARQ> validation) : base(repository, validation)
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
