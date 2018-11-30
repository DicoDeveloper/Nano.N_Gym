using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Domain.Interface.Service.Estoque;
using Nano.N_Base.Model.Entity.Estoque;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.Estoque
{
    internal class LimitadorEstoqueService : BaseService<LimitadorEstoque>, ILimitadorEstoqueService
    {
        private readonly ILimitadorEstoqueRepository _repository;

        public LimitadorEstoqueService(ILimitadorEstoqueRepository repository, IBaseValidation<LimitadorEstoque> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(LimitadorEstoque LimitadorEstoque)
        {
            // Executar verificacoes especificas
            return base.Save(LimitadorEstoque);
        }
    }
}
