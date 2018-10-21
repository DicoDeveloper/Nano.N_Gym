using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
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
