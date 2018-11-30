using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class EstoqueProdutoService : BaseService<EstoqueProduto>, IEstoqueProdutoService
    {
        private readonly IEstoqueProdutoRepository _repository;

        public EstoqueProdutoService(IEstoqueProdutoRepository repository, IBaseValidation<EstoqueProduto> validation) : base(repository, validation)
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
