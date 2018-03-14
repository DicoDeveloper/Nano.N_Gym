using N_Base.Domain.Interfaces.Repositories;
using N_Base.Domain.Interfaces.Services;
using N_Base.Entity.Objects;

namespace N_Base.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        public UsuarioService(IRepositoryBase<Usuario> repository) : base(repository)
        {
        }
    }
}