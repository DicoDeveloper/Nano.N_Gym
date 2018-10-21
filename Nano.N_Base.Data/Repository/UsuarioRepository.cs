using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        private readonly IUsuarioContext _context;

        public UsuarioRepository(IUsuarioContext context) : base(context)
        {
            _context = context;
        }
    }
}
