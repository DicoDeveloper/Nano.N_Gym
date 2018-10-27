using Nano.N_Base.Data.Interface.Sistema;
using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Data.Repository.Sistema
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
