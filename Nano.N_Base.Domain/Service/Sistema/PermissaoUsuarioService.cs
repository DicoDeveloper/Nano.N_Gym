using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class PermissaoUsuarioService : BaseService<PermissaoUsuario>, IPermissaoUsuarioService
    {
        private readonly IPermissaoUsuarioRepository _repository;

        public PermissaoUsuarioService(IPermissaoUsuarioRepository repository, IBaseValidation<PermissaoUsuario> validation) : base(repository, validation)
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
