using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class AgendamentoService : BaseService<Agendamento>, IAgendamentoService
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
