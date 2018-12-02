using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class TurmaService : BaseService<Turma>, ITurmaService
    {
        private readonly ITurmaRepository _repository;

        public TurmaService(ITurmaRepository repository, IBaseValidation<Turma> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Turma turma)
        {
            // Executar verificacoes especificas
            return base.Save(turma);
        }
    }
}
