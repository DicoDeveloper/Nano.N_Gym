using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class PermissaoUsuarioService : ServiceBase<PermissaoUsuario>, IPermissaoUsuarioService
    {
        public PermissaoUsuarioService(IRepositoryBase<PermissaoUsuario> repository) : base(repository)
        {
        }
    }
}