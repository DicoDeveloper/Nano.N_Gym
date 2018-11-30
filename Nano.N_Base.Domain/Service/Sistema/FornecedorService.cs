using Nano.N_Base.Domain.Interface.Repository.Sistema;
using Nano.N_Base.Domain.Interface.Service.Sistema;
using Nano.N_Base.Model.Entity.Sistema;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Sistema
{
    internal class FornecedorService : BaseService<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository, IBaseValidation<Fornecedor> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Fornecedor fornecedor)
        {
            // Executar verificacoes especificas
            return base.Save(fornecedor);
        }
    }
}
