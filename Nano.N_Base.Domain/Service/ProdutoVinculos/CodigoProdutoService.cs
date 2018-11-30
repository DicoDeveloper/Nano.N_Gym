using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class CodigoProdutoService : BaseService<CodigoProduto>, ICodigoProdutoService
    {
        private readonly ICodigoProdutoRepository _repository;

        public CodigoProdutoService(ICodigoProdutoRepository repository, IBaseValidation<CodigoProduto> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(CodigoProduto codigoProduto)
        {
            // Executar verificacoes especificas
            return base.Save(codigoProduto);
        }
    }
}
