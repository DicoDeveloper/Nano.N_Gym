using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioService(IFuncionarioRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Funcionario funcionario)
        {
            // Executar verificacoes especificas
            return base.Save(funcionario);
        }
    }
}
