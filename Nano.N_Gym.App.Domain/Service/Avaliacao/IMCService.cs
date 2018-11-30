using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class IMCService : GymBaseService<IMC>, IIMCService
    {
        private readonly IIMCRepository _repository;

        public IMCService(IIMCRepository repository, IBaseValidation<IMC> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(IMC avaliacao)
        {
            // Executar verificacoes especificas
            return base.Save(avaliacao);
        }
    }
}
