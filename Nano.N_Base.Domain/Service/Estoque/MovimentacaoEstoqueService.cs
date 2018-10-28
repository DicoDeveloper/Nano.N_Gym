using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class MovimentacaoEstoqueService : BaseService<MovimentacaoEstoque>, IMovimentacaoEstoqueService
    {
        private readonly IMovimentacaoEstoqueRepository _repository;

        public MovimentacaoEstoqueService(IMovimentacaoEstoqueRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(MovimentacaoEstoque MovimentacaoEstoque)
        {
            // Executar verificacoes especificas
            return base.Save(MovimentacaoEstoque);
        }
    }
}
