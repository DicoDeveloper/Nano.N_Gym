using Nano.N_Base.Domain.Service;
using Nano.N_Base.Validation.Interface;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Service;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Domain.Service
{
    internal class AgendamentoService : BaseService<Agendamento>, IAgendamentoService
    {
        private readonly IAgendamentoRepository _repository;

        public AgendamentoService(IAgendamentoRepository repository, IBaseValidation<Agendamento> validation) : base(repository, validation)
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
