using Nano.N_Base.Data.Interface.Fiscal;
using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Data.Repository.Fiscal
{
    public class DocumentoFiscalRepository : BaseRepository<DocumentoFiscal>, IDocumentoFiscalRepository
    {
        private readonly IDocumentoFiscalContext _context;

        public DocumentoFiscalRepository(IDocumentoFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
