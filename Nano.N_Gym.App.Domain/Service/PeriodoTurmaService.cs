using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class PeriodoTurmaService : BaseService<PeriodoTurma>, IPeriodoTurmaService
    {
        private readonly IPeriodoTurmaRepository _repository;

        public PeriodoTurmaService(IPeriodoTurmaRepository repository, IBaseValidation<PeriodoTurma> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(PeriodoTurma periodo)
        {
            // Executar verificacoes especificas
            return base.Save(periodo);
        }
    }
}
