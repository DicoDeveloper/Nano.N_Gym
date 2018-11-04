using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class MovimentoEstoqueService : BaseService<MovimentoEstoque>, IMovimentoEstoqueService
    {
        private readonly IMovimentoEstoqueRepository _repository;

        public MovimentoEstoqueService(IMovimentoEstoqueRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(MovimentoEstoque MovimentacaoEstoque)
        {
            // Executar verificacoes especificas
            return base.Save(MovimentacaoEstoque);
        }
    }
}
