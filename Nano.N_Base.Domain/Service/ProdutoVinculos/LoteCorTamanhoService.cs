using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class LoteCorTamanhoService : BaseService<LoteCorTamanho>, ILoteCorTamanhoService
    {
        private readonly ILoteCorTamanhoRepository _repository;

        public LoteCorTamanhoService(ILoteCorTamanhoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(LoteCorTamanho lote)
        {
            // Executar verificacoes especificas
            return base.Save(lote);
        }
    }
}
