using Nano.N_Base.Data.Interface;
using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Data.Repository
{
    public class PermissaoUsuarioRepository : BaseRepository<PermissaoUsuario>, IPermissaoUsuarioRepository
    {
        private readonly IPermissaoUsuarioContext _context;

        public PermissaoUsuarioRepository(IPermissaoUsuarioContext context) : base(context)
        {
            _context = context;
        }
    }
}
