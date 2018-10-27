using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class PermissaoUsuarioService : BaseService<PermissaoUsuario>, IPermissaoUsuarioService
    {
        private readonly IPermissaoUsuarioRepository _repository;

        public PermissaoUsuarioService(IPermissaoUsuarioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(PermissaoUsuario permissao)
        {
            // Executar verificacoes especificas
            return base.Save(permissao);
        }
    }
}
