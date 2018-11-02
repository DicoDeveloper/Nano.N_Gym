using Nano.N_Base.Data.Interface.Financeiro;
using Nano.N_Base.Domain.Interface.Repository.Financeiro;
using Nano.N_Base.Model.Entity.Financeiro;

namespace Nano.N_Base.Data.Repository.Financeiro
{
    public class DocumentoFinanceiroRepository : BaseRepository<DocumentoFinanceiro>, IDocumentoFinanceiroRepository
    {
        private readonly IDocumentoFinanceiroContext _context;

        public DocumentoFinanceiroRepository(IDocumentoFinanceiroContext context) : base(context)
        {
            _context = context;
        }
    }
}
