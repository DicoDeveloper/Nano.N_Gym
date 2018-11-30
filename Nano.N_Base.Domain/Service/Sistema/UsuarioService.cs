using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(IUsuarioRepository repository, IBaseValidation<Usuario> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Usuario usuario)
        {
            // Executar verificacoes especificas
            return base.Save(usuario);
        }
    }
}
