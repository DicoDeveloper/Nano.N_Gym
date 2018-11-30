using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class MovimentoEstoqueService : BaseService<MovimentoEstoque>, IMovimentoEstoqueService
    {
        private readonly IMovimentoEstoqueRepository _repository;

        public MovimentoEstoqueService(IMovimentoEstoqueRepository repository, IBaseValidation<MovimentoEstoque> validation) : base(repository, validation)
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
