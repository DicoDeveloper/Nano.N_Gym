using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class PeriodoModalidadeService : GymBaseService<PeriodoModalidade>, IPeriodoModalidadeService
    {
        private readonly IPeriodoModalidadeRepository _repository;

        public PeriodoModalidadeService(IPeriodoModalidadeRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(PeriodoModalidade periodoModalidade)
        {
            // Executar verificacoes especificas
            return base.Save(periodoModalidade);
        }
    }
}
