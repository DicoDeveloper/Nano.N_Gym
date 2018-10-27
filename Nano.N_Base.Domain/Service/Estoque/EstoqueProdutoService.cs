using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class EstoqueProdutoService : BaseService<Model.Entity.Estoque.EstoqueProduto>, IEstoqueProdutoService
    {
        private readonly IEstoqueProdutoRepository _repository;

        public EstoqueProdutoService(IEstoqueProdutoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(Model.Entity.Estoque.EstoqueProduto estoque)
        {
            // Executar verificacoes especificas
            return base.Save(estoque);
        }
    }
}
