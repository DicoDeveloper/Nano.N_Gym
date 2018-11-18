using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class TurmaService : GymBaseService<Turma>, ITurmaService
    {
        private readonly ITurmaRepository _repository;

        public TurmaService(ITurmaRepository repository) : base(repository)
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
