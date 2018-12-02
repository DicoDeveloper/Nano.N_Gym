using Nano.N_Base.Validation;
using Nano.N_Gym.App.Domain.Interface.Repository;
using Nano.N_Gym.App.Domain.Interface.Validation;
using Nano.N_Gym.App.Model.Entity;

namespace Nano.N_Gym.App.Validation
{
    internal class AgendamentoValidation : BaseValidation<Agendamento>, IAgendamentoValidation
    {
        private readonly IAgendamentoRepository _repository;

        public override void Validate(Agendamento agendamento)
        {
            base.Validate(agendamento);
            
        }
    }
}
