using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
{
    public class ClienteBaseRepository : BaseRepository<ClienteBase>, IClienteBaseRepository
    {
        private readonly IClienteBaseContext _context;

        public ClienteBaseRepository(IClienteBaseContext context) : base(context)
        {
            _context = context;
        }
    }
}
