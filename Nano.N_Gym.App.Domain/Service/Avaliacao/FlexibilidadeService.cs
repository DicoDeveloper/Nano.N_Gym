using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class FlexibilidadeService : GymBaseService<Flexibilidade>, IFlexibilidadeService
    {
        private readonly IFlexibilidadeRepository _repository;

        public FlexibilidadeService(IFlexibilidadeRepository repository, IBaseValidation<Flexibilidade> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Flexibilidade flexibilidade)
        {
            // Executar verificacoes especificas
            return base.Save(flexibilidade);
        }
    }
}
