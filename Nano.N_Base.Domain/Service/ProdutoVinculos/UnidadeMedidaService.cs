using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class UnidadeMedidaService : BaseService<UnidadeMedida>, IUnidadeMedidaService
    {
        private readonly IUnidadeMedidaRepository _repository;

        public UnidadeMedidaService(IUnidadeMedidaRepository repository) : base(repository)
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
