using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Domain.Interface.Service.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Domain.Service.Fiscal
{
    internal class ItemDocumentoFiscalService : BaseService<ItemDocumentoFiscal>, IItemDocumentoFiscalService
    {
        private readonly IItemDocumentoFiscalRepository _repository;

        public ItemDocumentoFiscalService(IItemDocumentoFiscalRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public override bool Save(ItemDocumentoFiscal itemDocumentoFiscal)
        {
            // Executar verificacoes especificas
            return base.Save(itemDocumentoFiscal);
        }
    }
}
