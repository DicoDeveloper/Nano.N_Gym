using Nano.N_Base.Domain.Interface.Repository;
using Nano.N_Base.Domain.Interface.Service;
using Nano.N_Base.Model.Entity;

namespace Nano.N_Base.Domain.Service
{
    internal class EstoqueProdutoService : BaseService<EstoqueProduto>, IEstoqueProdutoService
    {
        private readonly IEstoqueProdutoRepository _repository;

        public EstoqueProdutoService(IEstoqueProdutoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(EstoqueProduto estoque)
        {
            // Executar verificacoes especificas
            return base.Save(estoque);
        }
    }
}
