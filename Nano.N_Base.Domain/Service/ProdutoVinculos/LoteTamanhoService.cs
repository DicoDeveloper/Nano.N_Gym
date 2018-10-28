using Nano.N_Base.Domain.Interface.Repository.ProdutoVinculos;
using Nano.N_Base.Domain.Interface.Service.ProdutoVinculos;
using Nano.N_Base.Model.Entity.ProdutoVinculos;

namespace Nano.N_Base.Domain.Service.ProdutoVinculos
{
    internal class LoteTamanhoService : BaseService<LoteTamanho>, ILoteTamanhoService
    {
        private readonly ILoteTamanhoRepository _repository;

        public LoteTamanhoService(ILoteTamanhoRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(LoteTamanho lote)
        {
            // Executar verificacoes especificas
            return base.Save(lote);
        }
    }
}
