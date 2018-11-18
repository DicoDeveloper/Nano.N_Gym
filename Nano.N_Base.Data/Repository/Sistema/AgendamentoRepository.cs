using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class AgendamentoRepository : BaseRepository<Agendamento>, IAgendamentoRepository
    {
        private readonly IAgendamentoContext _context;

        public AgendamentoRepository(IAgendamentoContext context) : base(context)
        {
            _context = context;
        }
    }
}
