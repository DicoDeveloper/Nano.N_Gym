using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AgendamentoService : GymBaseService<Agendamento>, IAgendamentoService
    {
        private readonly IAgendamentoRepository _repository;

        public AgendamentoService(IAgendamentoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Agendamento agendamento)
        {
            // Executar verificacoes especificas
            return base.Save(agendamento);
        }
    }
}
