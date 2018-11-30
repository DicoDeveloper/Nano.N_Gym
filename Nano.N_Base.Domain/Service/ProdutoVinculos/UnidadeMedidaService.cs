using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;
using Nano.N_Base.Validation.Interface;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class UnidadeMedidaService : BaseService<UnidadeMedida>, IUnidadeMedidaService
    {
        private readonly IUnidadeMedidaRepository _repository;

        public UnidadeMedidaService(IUnidadeMedidaRepository repository, IBaseValidation<UnidadeMedida> validation) : base(repository, validation)
        {
            _repository = repository;
        }

        public override bool Save(UnidadeMedida unidadeMedida)
        {
            // Executar verificacoes especificas
            return base.Save(unidadeMedida);
        }
    }
}
