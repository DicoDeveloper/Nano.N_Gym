using Nano.N_Base.Data.Interface.Estoque;
using Nano.N_Base.Domain.Interface.Repository.Estoque;
using Nano.N_Base.Model.Entity.Estoque;

namespace Nano.N_Base.Data.Repository.Estoque
{
    public class InventarioRepository : BaseRepository<Inventario>, IInventarioRepository
    {
        private readonly IInventarioContext _context;

        public InventarioRepository(IInventarioContext context) : base(context)
        {
            _context = context;
        }
    }
}
