using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ParametroEmpresaService : BaseService<ParametroEmpresa>, IParametroEmpresaService
    {
        private readonly IParametroEmpresaRepository _repository;

        public ParametroEmpresaService(IParametroEmpresaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(ParametroEmpresa ParametroEmpresa)
        {
            // Executar verificacoes especificas
            return base.Save(ParametroEmpresa);
        }
    }
}
