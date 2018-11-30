using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class AtributoProdutoService : BaseService<AtributoProduto>, IAtributoProdutoService
    {
        private readonly IAtributoProdutoRepository _repository;

        public AtributoProdutoService(IAtributoProdutoRepository repository, IBaseValidation<AtributoProduto> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(AtributoProduto atributoProduto)
        {
            // Executar verificacoes especificas
            return base.Save(atributoProduto);
        }
    }
}
