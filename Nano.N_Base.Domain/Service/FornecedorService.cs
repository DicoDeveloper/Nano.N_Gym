using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
{
    internal class FornecedorService : BaseService<Fornecedor>, IFornecedorService
    {
        private readonly IFornecedorRepository _repository;

        public FornecedorService(IFornecedorRepository repository) : base(repository)
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
