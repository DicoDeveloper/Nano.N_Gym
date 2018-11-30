using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class ProdutoService : BaseService<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository, IBaseValidation<Produto> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(Produto produto)
        {
            // Executar verificacoes especificas
            return base.Save(produto);
        }
    }
}
