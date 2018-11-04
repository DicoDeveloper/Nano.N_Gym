using Nano.N_Base.Data.Interface.Fiscal;
using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Data.Repository.Fiscal
{
    public class OperacaoFiscalRepository : BaseRepository<OperacaoFiscal>, IOperacaoFiscalRepository
    {
        private readonly IOperacaoFiscalContext _context;

        public OperacaoFiscalRepository(IOperacaoFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
