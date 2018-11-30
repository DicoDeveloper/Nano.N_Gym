using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _repository;

        public EmpresaService(IEmpresaRepository repository, IBaseValidation<Empresa> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Empresa empresa)
        {
            // Executar verificacoes especificas
            return base.Save(empresa);
        }
    }
}
