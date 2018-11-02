using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ContatoRepository : BaseRepository<Contato>, IContatoRepository
    {
        private readonly IContatoContext _context;

        public ContatoRepository(IContatoContext context) : base(context)
        {
            _context = context;
        }
    }
}
