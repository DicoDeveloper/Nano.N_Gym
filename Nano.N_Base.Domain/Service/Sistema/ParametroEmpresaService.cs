using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class ParametroEmpresaService : BaseService<ParametroEmpresa>, IParametroEmpresaService
    {
        private readonly IParametroEmpresaRepository _repository;

        public ParametroEmpresaService(IParametroEmpresaRepository repository, IBaseValidation<ParametroEmpresa> validation) : base(repository, validation)
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
