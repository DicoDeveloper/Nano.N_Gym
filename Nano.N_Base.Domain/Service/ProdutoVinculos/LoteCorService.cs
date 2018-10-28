using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class LoteCorService : BaseService<LoteCor>, ILoteCorService
    {
        private readonly ILoteCorRepository _repository;

        public LoteCorService(ILoteCorRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(LoteCor lote)
        {
            // Executar verificacoes especificas
            return base.Save(lote);
        }
    }
}
