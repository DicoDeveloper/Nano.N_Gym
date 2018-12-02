using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class ForcaResistenciaMuscularService : BaseService<ForcaResistenciaMuscular>, IForcaResistenciaMuscularService
    {
        private readonly IForcaResistenciaMuscularRepository _repository;

        public ForcaResistenciaMuscularService(IForcaResistenciaMuscularRepository repository, IBaseValidation<ForcaResistenciaMuscular> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(ForcaResistenciaMuscular avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
