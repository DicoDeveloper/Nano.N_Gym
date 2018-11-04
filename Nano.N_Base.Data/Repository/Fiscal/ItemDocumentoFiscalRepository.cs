using Nano.N_Base.Data.Interface.Fiscal;
using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Data.Repository.Fiscal
{
    public class ItemDocumentoFiscalRepository : BaseRepository<ItemDocumentoFiscal>, IItemDocumentoFiscalRepository
    {
        private readonly IItemDocumentoFiscalContext _context;

        public ItemDocumentoFiscalRepository(IItemDocumentoFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
