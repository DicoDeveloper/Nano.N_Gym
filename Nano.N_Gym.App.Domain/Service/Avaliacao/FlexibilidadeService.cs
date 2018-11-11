using Nano.N_Gym.App.Domain.Interface.Repository.Avaliacao;
using Nano.N_Gym.App.Domain.Interface.Service.Avaliacao;
using Nano.N_Gym.App.Model.Entity.Avaliacao;

namespace Nano.N_Gym.App.Domain.Service.Avaliacao
{
    internal class FlexibilidadeService : GymBaseService<Flexibilidade>, IFlexibilidadeService
    {
        private readonly IFlexibilidadeRepository _repository;

        public FlexibilidadeService(IFlexibilidadeRepository repository) : base(repository)
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
