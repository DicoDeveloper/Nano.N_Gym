using Nano.N_Base.Data.Interface.Fiscal;
using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Data.Repository.Fiscal
{
    public class SerieFiscalRepository : BaseRepository<SerieFiscal>, ISerieFiscalRepository
    {
        private readonly ISerieFiscalContext _context;

        public SerieFiscalRepository(ISerieFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
