using Nano.N_Base.Data.Interface.Fiscal;
using Nano.N_Base.Domain.Interface.Repository.Fiscal;
using Nano.N_Base.Model.Entity.Fiscal;

namespace Nano.N_Base.Data.Repository.Fiscal
{
    public class ModeloFiscalRepository : BaseRepository<ModeloFiscal>, IModeloFiscalRepository
    {
        private readonly IModeloFiscalContext _context;

        public ModeloFiscalRepository(IModeloFiscalContext context) : base(context)
        {
            _context = context;
        }
    }
}
